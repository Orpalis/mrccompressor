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
using System.Windows.Forms;
using System.Threading;
using PassportPDF.Tools.Framework;
using PassportPDF.Tools.Framework.Configuration;
using PassportPDF.Tools.WinForm.Utilities;
using PassportPDF.Tools.WinForm.Controllers;
using PassportPDF.Tools.WinForm.Views;
using MRCCompressor.Views;
using MRCCompressor.Controller;

namespace MRCCompressor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            int argsCount = args.Length;
            bool autoRun;

            if (argsCount != 0)
            {
                FrameworkGlobals.ApplicationConfiguration = ConfigurationManager.ResetDefaultApplicationConfiguration();
                autoRun = true;
                FrameworkGlobals.ApplicationConfiguration.InputPath = "";
                FrameworkGlobals.ApplicationConfiguration.OutputPath = "";
            }
            else
            {
                autoRun = false;
            }

            Mutex mutex = null;
            bool owned = false;

            try
            {
                mutex = new Mutex(true, MRCCompressorGlobals.PASSPORT_PDF_APP_ID, out owned);

                if (!owned)
                {
                    DialogUtilities.ShowErrorMessage(FrameworkGlobals.MessagesLocalizer.GetString("programInstanceAlreadyRunning", FrameworkGlobals.ApplicationLanguage), FrameworkGlobals.MessagesLocalizer.GetString("caption_stop", FrameworkGlobals.ApplicationLanguage));
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
            }
            finally
            {
                if (mutex != null && owned)
                {
                    mutex.ReleaseMutex();
                }
            }

            IPassportPDFAppController controller = new MRCCompressorController(autoRun, args);
            frmMain view = new frmMain();
            ((IPassportPDFAppMainView)view).SetController(controller);
            controller.SetView(view);

            Application.EnableVisualStyles();
            Application.Run(view);
        }
    }
}
