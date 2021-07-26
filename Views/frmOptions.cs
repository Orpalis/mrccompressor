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
            chkPreserveSmoothing.Text = MRCCompressorGlobals.LabelsLocalizer.GetString("label_chkPreserveSmoothing", FrameworkGlobals.ApplicationLanguage);
            lbPms.Text = MRCCompressorGlobals.LabelsLocalizer.GetString("label_lbPms", FrameworkGlobals.ApplicationLanguage);
            PopulateComboBoxes();
        }


        public override void LoadConfiguration()
        {
            base.LoadConfiguration();

            chkFastWebView.Checked = MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.FastWebView;
            chkDownscaleImages.Checked = MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.DownscaleImages;
            nuDownscaleResolution.Value = MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.DownscaleResolution;
            nuImageQuality.Value = MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.ImageQuality;
            chkPreserveSmoothing.Checked = MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.PreserveSmoothing;
            nuDownscaleResolution.Enabled = MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.DownscaleImages;
            lbResolution.Enabled = MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.DownscaleImages;
            lbDpi.Enabled = MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.DownscaleImages;
            nuPms.Value = (decimal)MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.JBIG2PMSTreshold;
            chkAutoRotate.Checked = MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.AutoRotate;

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
                    MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.Conformance = entry.Key;
                }
            }

            if (cmbBitonalCompressionScheme.SelectedIndex == 0)
            {
                MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.BitonalImageCompression = PdfImageCompressionScheme.None;
            }
            else
            {
                string selectedBitonalCompressionScheme = (string)cmbBitonalCompressionScheme.Items[cmbBitonalCompressionScheme.SelectedIndex];

                foreach (var entry in MRCCompressorGlobals.AvailableBitonalCompressionSchemes)
                {
                    if (entry.Value == selectedBitonalCompressionScheme)
                    {
                        MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.BitonalImageCompression = entry.Key;
                    }
                }
            }

            if (cmbColorCompressionScheme.SelectedIndex == 0)
            {
                MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.ColorImageCompression = PdfImageCompressionScheme.None;
            }
            else
            {
                string selectedColorCompressionScheme = (string)cmbColorCompressionScheme.Items[cmbColorCompressionScheme.SelectedIndex];

                foreach (var entry in MRCCompressorGlobals.AvailableColorCompressionSchemes)
                {
                    if (entry.Value == selectedColorCompressionScheme)
                    {
                        MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.ColorImageCompression = entry.Key;
                    }
                }
            }

            MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.FastWebView = chkFastWebView.Checked;
            MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.DownscaleImages = chkDownscaleImages.Checked;
            MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.DownscaleResolution = (int)nuDownscaleResolution.Value;
            MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.ImageQuality = (int)nuImageQuality.Value;
            MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.PreserveSmoothing = chkPreserveSmoothing.Checked;
            MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.JBIG2PMSTreshold = (float)nuPms.Value;
            MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.AutoRotate = chkAutoRotate.Checked;

            Dispose();
        }


        protected override void ResetDefaultConfiguration()
        {
            base.ResetDefaultConfiguration();

            MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration = ConfigurationManager.ResetDefaultImageSaveAsPDFMRCActionConfiguration();

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
                if (entry.Key == MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.Conformance)
                {
                    cmbPdfVersion.SelectedIndex = index;
                }
                index++;
            }

            if (MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.BitonalImageCompression == PdfImageCompressionScheme.None)
            {
                cmbBitonalCompressionScheme.SelectedIndex = 0;
            }
            else
            {
                index = 1;
                foreach (var entry in MRCCompressorGlobals.AvailableBitonalCompressionSchemes)
                {
                    if (entry.Key == MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.BitonalImageCompression)
                    {
                        cmbBitonalCompressionScheme.SelectedIndex = index;
                    }
                    index++;
                }
            }

            if (MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.ColorImageCompression == PdfImageCompressionScheme.None)
            {
                cmbColorCompressionScheme.SelectedIndex = 0;
            }
            else
            {
                index = 1;
                foreach (var entry in MRCCompressorGlobals.AvailableColorCompressionSchemes)
                {
                    if (entry.Key == MRCCompressorGlobals.ImageSaveAsPDFMRCActionConfiguration.ColorImageCompression)
                    {
                        cmbColorCompressionScheme.SelectedIndex = index;
                    }
                    index++;
                }
            }
        }


        private void chkDownscaleImages_CheckedChanged(object sender, EventArgs e)
        {
            nuDownscaleResolution.Enabled = chkDownscaleImages.Checked;
            lbResolution.Enabled = chkDownscaleImages.Checked;
            lbDpi.Enabled = chkDownscaleImages.Checked;
        }
    }
}
