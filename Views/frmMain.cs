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
using PassportPDF.Tools.Framework;
using PassportPDF.Tools.WinForm.Views;

namespace MRCCompressor.Views
{
    public partial class frmMain : frmMainBase, IMrcCompressorMainView
    {
        private delegate void UpdateRatioDelegate(double ratio);

        private readonly UpdateRatioDelegate _compressionRatioUpdateEventHandler;


        public frmMain()
        {
            _compressionRatioUpdateEventHandler = UpdateReductionRatio;
            InitializeComponent();
            lbCompressionRatio.Visible = false;
            lbCompressionRatioValue.Visible = false;
        }


        protected override void LoadLabels()
        {
            base.LoadLabels();
            lbCompressionRatio.Text = MRCCompressorGlobals.LabelsLocalizer.GetString("label_lbCompressionRatio", FrameworkGlobals.ApplicationLanguage);
        }


        protected override void LockView()
        {
            base.LockView();
            lbCompressionRatioValue.Text = "0%";
            lbCompressionRatio.Visible = true;
            lbCompressionRatioValue.Visible = true;

        }


        protected override void UnlockView()
        {
            base.UnlockView();
            lbCompressionRatio.Visible = false;
            lbCompressionRatioValue.Visible = false;
        }


        private void UpdateReductionRatio(double updatedRatio)
        {
            if (updatedRatio < 0)
            {
                lbCompressionRatioValue.Text = "< 0%";
            }
            else
            {
                lbCompressionRatioValue.Text = Math.Round(updatedRatio, 2) + "%";
            }
        }


        void IMrcCompressorMainView.NotifyReductionRatioChange(double ratio)
        {
            if (InvokeRequired)
            {
                Invoke(_compressionRatioUpdateEventHandler, ratio);
            }
            else
            {
                UpdateReductionRatio(ratio);
            }
        }
    }
}
