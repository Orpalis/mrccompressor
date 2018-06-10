/**********************************************************************
 * Project:                  MRCCompressor
 * Authors:                 - Evan Carrère.
 *                          - Loïc Carrère.
 *
 * (C) Copyright 2018, ORPALIS.
 ** Licensed under the Apache License, Version 2.0 (the "License");
 ** you may not use this file except in compliance with the License.
 ** You may obtain a copy of the License at
 ** http://www.apache.org/licenses/LICENSE-2.0
 ** Unless required by applicable law or agreed to in writing, software
 ** distributed under the License is distributed on an "AS IS" BASIS,
 ** WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 ** See the License for the specific language governing permissions and
 ** limitations under the License.
 *
 **********************************************************************/

using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MRCCompressor.Views;
using PassportPDF.Tools.Framework;
using PassportPDF.Tools.Framework.Business;
using PassportPDF.Tools.Framework.Configuration;
using PassportPDF.Tools.Framework.Models;
using PassportPDF.Tools.Framework.Utilities;
using PassportPDF.Tools.WinForm.Controllers;
using PassportPDF.Tools.WinForm.Models;
using PassportPDF.Tools.WinForm.Utilities;

namespace MRCCompressor.Controller
{
    internal sealed class MRCCompressorController : PassportPDFAppControllerBase
    {
        public MRCCompressorController(bool autoRun, string[] args) : base(
            new PassportPDFDesktopAppInformation(
                MRCCompressorGlobals.PRODUCT_NAME, MRCCompressorGlobals.PASSPORT_PDF_APP_ID,
                MRCCompressorGlobals.APP_EXECUTABLE_NAME, MRCCompressorGlobals.SOURCE_CODE_URL,
                AssemblyUtilities.GetVersion(), Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location),
                Properties.Resources.mrc_compressor_final_logo, MRCCompressorGlobals.INPUT_FILE_TYPE,
                MRCCompressorGlobals.GetApplicationConfigurationFilePath(), autoRun, args))
        { }

        protected override bool InitializeAppConfiguration()
        {
            if (!base.InitializeAppConfiguration())
            {
                return false;
            }

            if (!_appInfo.AutoRun)
            {
                try
                {
                    MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration = (ImageSaveAsPDFActionConfiguration)ConfigurationManager.InitializeConfigurationInstanceEx(MRCCompressorGlobals.GetSaveAsPDFActionConfigurationFilePath(), typeof(ImageSaveAsPDFActionConfiguration));
                }
                catch (Exception)
                {
                    MessageBox.Show(FrameworkGlobals.MessagesLocalizer.GetString("readImageSaveAsPDFConfigurationFailure", FrameworkGlobals.ApplicationConfiguration.Language), FrameworkGlobals.MessagesLocalizer.GetString("readConfigurationFailureTitle", FrameworkGlobals.ApplicationConfiguration.Language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration = ConfigurationManager.ResetDefaultImageSaveAsPDFActionConfiguration();
                }
            }
            else
            {
                MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration = ConfigurationManager.ResetDefaultImageSaveAsPDFActionConfiguration();
                CommandLineParsingUtilities.ParseCommandLineArgs(_appInfo.CommandLineArguments, FrameworkGlobals.ApplicationConfiguration, imageSaveAsPdfActionConfiguration: MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration);

                if (FrameworkGlobals.ApplicationConfiguration.MinimizedWindow)
                {
                    _view.Minimize();
                }
            }

            return true;
        }


        protected override OperationsWorkflow GetOperationWorkflow()
        {
            return OperationsWorkflowUtilities.CreateImageToPDFMRCWorkflow(MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration);
        }


        protected override void OnOptionsFormOpeningRequested()
        {
            using (frmOptions frmOptions = new frmOptions())
            {
                frmOptions.LoadLabels();

                try
                {
                    frmOptions.LoadConfiguration();
                }
                catch
                {
                    MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration = ConfigurationManager.ResetDefaultImageSaveAsPDFActionConfiguration();
                    MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.AdvancedImageCompression = PassportPDF.Model.ImageSaveAsPDFParameters.AdvancedImageCompressionEnum.MRC;
                    frmOptions.LoadConfiguration();
                }

                frmOptions.ShowDialog(_view.WindowInstance);
            }
        }


        protected override void OnFileOperationsCompletion(FileOperationsResult fileOperationsResult)
        {
            base.OnFileOperationsCompletion(fileOperationsResult);

            UpdateCompressionStats(fileOperationsResult.InputFileSize, fileOperationsResult.OutputFileSize);

            string operationsCompletionMessage = LogMessagesUtils.GetGenericFileOperationsCompletionText(fileOperationsResult);
            if (FrameworkGlobals.ApplicationConfiguration.TimestampLogs)
            {
                operationsCompletionMessage = LogMessagesUtils.TimeStampLogMessage(operationsCompletionMessage);
            }

            _view.NotifyOperationCompletion(operationsCompletionMessage);

            if (!string.IsNullOrEmpty(FrameworkGlobals.ApplicationConfiguration.LogsPath))
            {
                FrameworkGlobals.LogsManager.LogMessage(operationsCompletionMessage);
            }

            ((IMrcCompressorMainView)_view).NotifyReductionRatioChange(100 - _operationsStats.ReductionRatio);
        }


        protected override void OnOperationsCompletion()
        {
            base.OnOperationsCompletion();

            string elapsedTime = ParsingUtils.GetElapsedTimeString(_stopwatch.Elapsed);

            _view.NotifyOperationsResult(LogMessagesUtils.GetImagePdfMrcCompressionWorkResultMessage(_operationsStats.ProcessedFileCount, _operationsStats.SuccesfullyProcessedFileCount, _operationsStats.UnsuccesfullyProcessedFileCount, _operationsStats.TotalInputSize, _operationsStats.TotalOutputSize, elapsedTime));

            string detailedWorkCompletionMessage = LogMessagesUtils.GetImagePdfMrcCompressionWorkResultMessageDetailed(_operationsStats.ProcessedFileCount, _operationsStats.SuccesfullyProcessedFileCount, _operationsStats.UnsuccesfullyProcessedFileCount, _operationsStats.TotalInputSize, _operationsStats.TotalOutputSize, elapsedTime);

            if (!_appInfo.AutoRun)
            {
                DialogUtilities.ShowInformationMessage(detailedWorkCompletionMessage, FrameworkGlobals.MessagesLocalizer.GetString("processTerminated", FrameworkGlobals.ApplicationLanguage));
                _view.UnlockView();
            }
            else
            {
                Console.Write(detailedWorkCompletionMessage);
                _view.ExitApplication();
            }
        }


        protected override void HandleApplicationClosing()
        {
            base.HandleApplicationClosing();

            if (!_appInfo.AutoRun &&
                (!ConfigurationManager.SaveConfiguration(MRCCompressorGlobals.GetApplicationConfigurationFilePath(), FrameworkGlobals.ApplicationConfiguration) ||
                !ConfigurationManager.SaveConfiguration(MRCCompressorGlobals.GetSaveAsPDFActionConfigurationFilePath(), MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration)))
            {
                MessageBox.Show(FrameworkGlobals.MessagesLocalizer.GetString("saveConfigurationFailure", FrameworkGlobals.ApplicationConfiguration.Language), FrameworkGlobals.MessagesLocalizer.GetString("saveConfigurationFailureTitle", FrameworkGlobals.ApplicationConfiguration.Language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateCompressionStats(float inputSize, float outputSize)
        {
            _operationsStats.TotalInputSize += inputSize;
            _operationsStats.TotalOutputSize += outputSize;
            _operationsStats.ReductionRatio = StatsComputationUtilities.ComputeReductionRatio(_operationsStats.TotalInputSize, _operationsStats.TotalOutputSize);
        }
    }
}
