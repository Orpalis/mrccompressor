/**********************************************************************
 * Project:                  Image To PDF MRC
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
using PassportPDF.Model;
using PassportPDF.Tools.Framework;
using PassportPDF.Tools.Framework.Configuration;
using PassportPDF.Tools.WinForm.Views;

namespace MRCCompressor.Views
{
    public partial class frmOptions : frmOptionsBase
    {
        public frmOptions() : base(Properties.Resources.banner_mrc_compressor)
        {
            InitializeComponent();
        }


        public override void LoadLabels()
        {
            base.LoadLabels();

            tabCompression.Text = MRCCompressorGlobals.LabelsLocalizer.GetString("label_tabCompression", FrameworkGlobals.ApplicationLanguage);
            tabOutputFormat.Text = MRCCompressorGlobals.LabelsLocalizer.GetString("label_tabOutputFormat", FrameworkGlobals.ApplicationLanguage);
            lbBitonalCompressionScheme.Text = MRCCompressorGlobals.LabelsLocalizer.GetString("label_lbBitonalCompressionScheme", FrameworkGlobals.ApplicationLanguage);
            lbColorCompressionScheme.Text = MRCCompressorGlobals.LabelsLocalizer.GetString("label_lbColorCompressionScheme", FrameworkGlobals.ApplicationLanguage);
            lbDpi.Text = MRCCompressorGlobals.LabelsLocalizer.GetString("label_lbDpi", FrameworkGlobals.ApplicationLanguage);
            lbImageQuality.Text = MRCCompressorGlobals.LabelsLocalizer.GetString("label_lbImageQuality", FrameworkGlobals.ApplicationLanguage);
            lbPdfVersion.Text = MRCCompressorGlobals.LabelsLocalizer.GetString("label_lbPdfVersion", FrameworkGlobals.ApplicationLanguage);
            chkDownscaleImages.Text = MRCCompressorGlobals.LabelsLocalizer.GetString("label_chkDownscaleImages", FrameworkGlobals.ApplicationLanguage);
            lbResolution.Text = MRCCompressorGlobals.LabelsLocalizer.GetString("label_lbResolution", FrameworkGlobals.ApplicationLanguage);
            chkFastWebView.Text = MRCCompressorGlobals.LabelsLocalizer.GetString("label_chkFastWebView", FrameworkGlobals.ApplicationLanguage);

            PopulateComboBoxes();
        }


        public override void LoadConfiguration()
        {
            base.LoadConfiguration();

            chkFastWebView.Checked = MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.FastWebView;
            chkDownscaleImages.Checked = MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.DownscaleImages;
            nuDownscaleResolution.Value = MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.DownscaleResolution;
            nuImageQuality.Value = MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.ImageQuality;
            SetSelectedItemsInComboBoxes();
        }


        protected override void ApplyConfigurationChanges()
        {
            base.ApplyConfigurationChanges();

            string selectedPdfOutputVersion = (string)cmbPdfVersion.Items[cmbPdfVersion.SelectedIndex];

            foreach (var entry in MRCCompressorGlobals.AvailableOutputPdfVersions)
            {
                if (entry.Value == selectedPdfOutputVersion)
                {
                    MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.Conformance = entry.Key;
                }
            }

            if (cmbBitonalCompressionScheme.SelectedIndex == 0)
            {
                MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.BitonalImageCompression = ImageSaveAsPDFParameters.BitonalImageCompressionEnum.None;
            }
            else
            {
                string selectedBitonalCompressionScheme = (string)cmbBitonalCompressionScheme.Items[cmbBitonalCompressionScheme.SelectedIndex];

                foreach (var entry in MRCCompressorGlobals.AvailableBitonalCompressionSchemes)
                {
                    if (entry.Value == selectedBitonalCompressionScheme)
                    {
                        MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.BitonalImageCompression = entry.Key;
                    }
                }
            }

            if (cmbColorCompressionScheme.SelectedIndex == 0)
            {
                MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.ColorImageCompression = ImageSaveAsPDFParameters.ColorImageCompressionEnum.None;
            }
            else
            {
                string selectedColorCompressionScheme = (string)cmbColorCompressionScheme.Items[cmbColorCompressionScheme.SelectedIndex];

                foreach (var entry in MRCCompressorGlobals.AvailableColorCompressionSchemes)
                {
                    if (entry.Value == selectedColorCompressionScheme)
                    {
                        MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.ColorImageCompression = entry.Key;
                    }
                }
            }

            MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.FastWebView = chkFastWebView.Checked;
            MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.DownscaleImages = chkDownscaleImages.Checked;
            MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.DownscaleResolution = (int)nuDownscaleResolution.Value;
            MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.ImageQuality = (int)nuImageQuality.Value;

            Dispose();
        }


        protected override void ResetDefaultConfiguration()
        {
            base.ResetDefaultConfiguration();

            MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration = ConfigurationManager.ResetDefaultImageSaveAsPDFActionConfiguration();
            MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.AdvancedImageCompression = ImageSaveAsPDFParameters.AdvancedImageCompressionEnum.MRC;

            LoadConfiguration();
        }


        private void PopulateComboBoxes()
        {
            foreach (var pdfVersion in MRCCompressorGlobals.AvailableOutputPdfVersions.Values)
            {
                cmbPdfVersion.Items.Add(pdfVersion);
            }

            cmbColorCompressionScheme.Items.Add(MRCCompressorGlobals.LabelsLocalizer.GetString("label_noCompression", FrameworkGlobals.ApplicationLanguage));
            foreach (var colorCompressionScheme in MRCCompressorGlobals.AvailableColorCompressionSchemes.Values)
            {
                cmbColorCompressionScheme.Items.Add(colorCompressionScheme);
            }

            cmbBitonalCompressionScheme.Items.Add(MRCCompressorGlobals.LabelsLocalizer.GetString("label_noCompression", FrameworkGlobals.ApplicationLanguage));
            foreach (var bitonalCompressionScheme in MRCCompressorGlobals.AvailableBitonalCompressionSchemes.Values)
            {
                cmbBitonalCompressionScheme.Items.Add(bitonalCompressionScheme);
            }
        }


        private void SetSelectedItemsInComboBoxes()
        {
            int index = 0;

            foreach (var entry in MRCCompressorGlobals.AvailableOutputPdfVersions)
            {
                if (entry.Key == MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.Conformance)
                {
                    cmbPdfVersion.SelectedIndex = index;
                }
                index++;
            }

            if (MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.BitonalImageCompression == ImageSaveAsPDFParameters.BitonalImageCompressionEnum.None)
            {
                cmbBitonalCompressionScheme.SelectedIndex = 0;
            }
            else
            {
                index = 1;
                foreach (var entry in MRCCompressorGlobals.AvailableBitonalCompressionSchemes)
                {
                    if (entry.Key == MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.BitonalImageCompression)
                    {
                        cmbBitonalCompressionScheme.SelectedIndex = index;
                    }
                    index++;
                }
            }

            if (MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.ColorImageCompression == ImageSaveAsPDFParameters.ColorImageCompressionEnum.None)
            {
                cmbColorCompressionScheme.SelectedIndex = 1;
            }
            else
            {
                index = 1;
                foreach (var entry in MRCCompressorGlobals.AvailableColorCompressionSchemes)
                {
                    if (entry.Key == MRCCompressorGlobals.ImageSaveAsPDFActionConfiguration.ColorImageCompression)
                    {
                        cmbColorCompressionScheme.SelectedIndex = index;
                    }
                    index++;
                }
            }
        }
    }
}
