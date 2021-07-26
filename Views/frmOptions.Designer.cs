namespace MRCCompressor.Views
{
    partial class frmOptions : PassportPDF.Tools.WinForm.Views.frmOptionsBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCompression = new System.Windows.Forms.TabPage();
            this.nuImageQuality = new System.Windows.Forms.NumericUpDown();
            this.lbImageQuality = new System.Windows.Forms.Label();
            this.lbColorCompressionScheme = new System.Windows.Forms.Label();
            this.cmbBitonalCompressionScheme = new System.Windows.Forms.ComboBox();
            this.lbBitonalCompressionScheme = new System.Windows.Forms.Label();
            this.cmbColorCompressionScheme = new System.Windows.Forms.ComboBox();
            this.panelCompression = new System.Windows.Forms.Panel();
            this.chkPreserveSmoothing = new System.Windows.Forms.CheckBox();
            this.nuPms = new System.Windows.Forms.NumericUpDown();
            this.lbPms = new System.Windows.Forms.Label();
            this.lbResolution = new System.Windows.Forms.Label();
            this.nuDownscaleResolution = new System.Windows.Forms.NumericUpDown();
            this.lbDpi = new System.Windows.Forms.Label();
            this.chkDownscaleImages = new System.Windows.Forms.CheckBox();
            this.tabOutputFormat = new System.Windows.Forms.TabPage();
            this.cmbPdfVersion = new System.Windows.Forms.ComboBox();
            this.lbPdfVersion = new System.Windows.Forms.Label();
            this.chkFastWebView = new System.Windows.Forms.CheckBox();
            this.panelOutputFormat = new System.Windows.Forms.Panel();
            this.chkAutoRotate = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabCompression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuImageQuality)).BeginInit();
            this.panelCompression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDownscaleResolution)).BeginInit();
            this.tabOutputFormat.SuspendLayout();
            this.panelOutputFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGeneral
            // 
            this.tabGeneral.Location = new System.Drawing.Point(4, 24);
            this.tabGeneral.Size = new System.Drawing.Size(567, 252);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCompression);
            this.tabControl1.Controls.Add(this.tabOutputFormat);
            this.tabControl1.Controls.SetChildIndex(this.tabOutputFormat, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabCompression, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabGeneral, 0);
            // 
            // tabCompression
            // 
            this.tabCompression.Controls.Add(this.nuImageQuality);
            this.tabCompression.Controls.Add(this.lbImageQuality);
            this.tabCompression.Controls.Add(this.lbColorCompressionScheme);
            this.tabCompression.Controls.Add(this.cmbBitonalCompressionScheme);
            this.tabCompression.Controls.Add(this.lbBitonalCompressionScheme);
            this.tabCompression.Controls.Add(this.cmbColorCompressionScheme);
            this.tabCompression.Controls.Add(this.panelCompression);
            this.tabCompression.Location = new System.Drawing.Point(4, 24);
            this.tabCompression.Name = "tabCompression";
            this.tabCompression.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompression.Size = new System.Drawing.Size(567, 252);
            this.tabCompression.TabIndex = 3;
            this.tabCompression.Text = "Compression";
            this.tabCompression.UseVisualStyleBackColor = true;
            // 
            // nuImageQuality
            // 
            this.nuImageQuality.Location = new System.Drawing.Point(63, 13);
            this.nuImageQuality.Name = "nuImageQuality";
            this.nuImageQuality.Size = new System.Drawing.Size(50, 23);
            this.nuImageQuality.TabIndex = 23;
            this.nuImageQuality.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbImageQuality
            // 
            this.lbImageQuality.AutoSize = true;
            this.lbImageQuality.Location = new System.Drawing.Point(15, 15);
            this.lbImageQuality.Name = "lbImageQuality";
            this.lbImageQuality.Size = new System.Drawing.Size(48, 15);
            this.lbImageQuality.TabIndex = 22;
            this.lbImageQuality.Text = "Quality:";
            // 
            // lbColorCompressionScheme
            // 
            this.lbColorCompressionScheme.AutoSize = true;
            this.lbColorCompressionScheme.Location = new System.Drawing.Point(15, 43);
            this.lbColorCompressionScheme.Name = "lbColorCompressionScheme";
            this.lbColorCompressionScheme.Size = new System.Drawing.Size(195, 15);
            this.lbColorCompressionScheme.TabIndex = 20;
            this.lbColorCompressionScheme.Text = "Color images compression scheme:";
            // 
            // cmbBitonalCompressionScheme
            // 
            this.cmbBitonalCompressionScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBitonalCompressionScheme.FormattingEnabled = true;
            this.cmbBitonalCompressionScheme.Location = new System.Drawing.Point(18, 110);
            this.cmbBitonalCompressionScheme.Name = "cmbBitonalCompressionScheme";
            this.cmbBitonalCompressionScheme.Size = new System.Drawing.Size(123, 23);
            this.cmbBitonalCompressionScheme.TabIndex = 17;
            // 
            // lbBitonalCompressionScheme
            // 
            this.lbBitonalCompressionScheme.AutoSize = true;
            this.lbBitonalCompressionScheme.Location = new System.Drawing.Point(15, 88);
            this.lbBitonalCompressionScheme.Name = "lbBitonalCompressionScheme";
            this.lbBitonalCompressionScheme.Size = new System.Drawing.Size(249, 15);
            this.lbBitonalCompressionScheme.TabIndex = 14;
            this.lbBitonalCompressionScheme.Text = "Black and white images compression scheme:";
            // 
            // cmbColorCompressionScheme
            // 
            this.cmbColorCompressionScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorCompressionScheme.FormattingEnabled = true;
            this.cmbColorCompressionScheme.Location = new System.Drawing.Point(18, 65);
            this.cmbColorCompressionScheme.Name = "cmbColorCompressionScheme";
            this.cmbColorCompressionScheme.Size = new System.Drawing.Size(124, 23);
            this.cmbColorCompressionScheme.TabIndex = 8;
            // 
            // panelCompression
            // 
            this.panelCompression.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCompression.Controls.Add(this.chkPreserveSmoothing);
            this.panelCompression.Controls.Add(this.nuPms);
            this.panelCompression.Controls.Add(this.lbPms);
            this.panelCompression.Controls.Add(this.lbResolution);
            this.panelCompression.Controls.Add(this.nuDownscaleResolution);
            this.panelCompression.Controls.Add(this.lbDpi);
            this.panelCompression.Controls.Add(this.chkDownscaleImages);
            this.panelCompression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCompression.Location = new System.Drawing.Point(3, 3);
            this.panelCompression.Name = "panelCompression";
            this.panelCompression.Padding = new System.Windows.Forms.Padding(3);
            this.panelCompression.Size = new System.Drawing.Size(561, 246);
            this.panelCompression.TabIndex = 25;
            // 
            // chkPreserveSmoothing
            // 
            this.chkPreserveSmoothing.AutoSize = true;
            this.chkPreserveSmoothing.Location = new System.Drawing.Point(14, 182);
            this.chkPreserveSmoothing.Name = "chkPreserveSmoothing";
            this.chkPreserveSmoothing.Size = new System.Drawing.Size(131, 19);
            this.chkPreserveSmoothing.TabIndex = 24;
            this.chkPreserveSmoothing.Text = "Preserve smoothing";
            this.chkPreserveSmoothing.UseVisualStyleBackColor = true;
            // 
            // nuPms
            // 
            this.nuPms.DecimalPlaces = 2;
            this.nuPms.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nuPms.Location = new System.Drawing.Point(15, 155);
            this.nuPms.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuPms.Name = "nuPms";
            this.nuPms.Size = new System.Drawing.Size(50, 23);
            this.nuPms.TabIndex = 17;
            this.nuPms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbPms
            // 
            this.lbPms.AutoSize = true;
            this.lbPms.Location = new System.Drawing.Point(11, 136);
            this.lbPms.Name = "lbPms";
            this.lbPms.Size = new System.Drawing.Size(268, 15);
            this.lbPms.TabIndex = 1;
            this.lbPms.Text = "JBIG2 pattern matching and substitution treshold:";
            // 
            // lbResolution
            // 
            this.lbResolution.AutoSize = true;
            this.lbResolution.Location = new System.Drawing.Point(273, 35);
            this.lbResolution.Name = "lbResolution";
            this.lbResolution.Size = new System.Drawing.Size(123, 15);
            this.lbResolution.TabIndex = 15;
            this.lbResolution.Text = "Downscale resolution:";
            // 
            // nuDownscaleResolution
            // 
            this.nuDownscaleResolution.Location = new System.Drawing.Point(398, 31);
            this.nuDownscaleResolution.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.nuDownscaleResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuDownscaleResolution.Name = "nuDownscaleResolution";
            this.nuDownscaleResolution.Size = new System.Drawing.Size(50, 23);
            this.nuDownscaleResolution.TabIndex = 16;
            this.nuDownscaleResolution.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // lbDpi
            // 
            this.lbDpi.AutoSize = true;
            this.lbDpi.Location = new System.Drawing.Point(450, 31);
            this.lbDpi.Name = "lbDpi";
            this.lbDpi.Size = new System.Drawing.Size(24, 15);
            this.lbDpi.TabIndex = 19;
            this.lbDpi.Text = "dpi";
            // 
            // chkDownscaleImages
            // 
            this.chkDownscaleImages.AutoSize = true;
            this.chkDownscaleImages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkDownscaleImages.Location = new System.Drawing.Point(274, 9);
            this.chkDownscaleImages.Name = "chkDownscaleImages";
            this.chkDownscaleImages.Size = new System.Drawing.Size(124, 19);
            this.chkDownscaleImages.TabIndex = 18;
            this.chkDownscaleImages.Text = "Downscale images";
            this.chkDownscaleImages.UseVisualStyleBackColor = true;
            this.chkDownscaleImages.CheckedChanged += new System.EventHandler(this.chkDownscaleImages_CheckedChanged);
            // 
            // tabOutputFormat
            // 
            this.tabOutputFormat.Controls.Add(this.cmbPdfVersion);
            this.tabOutputFormat.Controls.Add(this.lbPdfVersion);
            this.tabOutputFormat.Controls.Add(this.chkFastWebView);
            this.tabOutputFormat.Controls.Add(this.panelOutputFormat);
            this.tabOutputFormat.Location = new System.Drawing.Point(4, 24);
            this.tabOutputFormat.Name = "tabOutputFormat";
            this.tabOutputFormat.Padding = new System.Windows.Forms.Padding(3);
            this.tabOutputFormat.Size = new System.Drawing.Size(567, 252);
            this.tabOutputFormat.TabIndex = 4;
            this.tabOutputFormat.Text = "Output Format";
            this.tabOutputFormat.UseVisualStyleBackColor = true;
            // 
            // cmbPdfVersion
            // 
            this.cmbPdfVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPdfVersion.FormattingEnabled = true;
            this.cmbPdfVersion.Location = new System.Drawing.Point(87, 11);
            this.cmbPdfVersion.Name = "cmbPdfVersion";
            this.cmbPdfVersion.Size = new System.Drawing.Size(130, 23);
            this.cmbPdfVersion.TabIndex = 27;
            // 
            // lbPdfVersion
            // 
            this.lbPdfVersion.AutoSize = true;
            this.lbPdfVersion.Location = new System.Drawing.Point(15, 15);
            this.lbPdfVersion.Name = "lbPdfVersion";
            this.lbPdfVersion.Size = new System.Drawing.Size(72, 15);
            this.lbPdfVersion.TabIndex = 28;
            this.lbPdfVersion.Text = "PDF version:";
            // 
            // chkFastWebView
            // 
            this.chkFastWebView.AutoSize = true;
            this.chkFastWebView.Location = new System.Drawing.Point(17, 44);
            this.chkFastWebView.Name = "chkFastWebView";
            this.chkFastWebView.Size = new System.Drawing.Size(135, 19);
            this.chkFastWebView.TabIndex = 26;
            this.chkFastWebView.Text = "Enable fast web view";
            this.chkFastWebView.UseVisualStyleBackColor = true;
            // 
            // panelOutputFormat
            // 
            this.panelOutputFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOutputFormat.Controls.Add(this.chkAutoRotate);
            this.panelOutputFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutputFormat.Location = new System.Drawing.Point(3, 3);
            this.panelOutputFormat.Name = "panelOutputFormat";
            this.panelOutputFormat.Padding = new System.Windows.Forms.Padding(3);
            this.panelOutputFormat.Size = new System.Drawing.Size(561, 246);
            this.panelOutputFormat.TabIndex = 29;
            // 
            // chkAutoRotate
            // 
            this.chkAutoRotate.AutoSize = true;
            this.chkAutoRotate.Location = new System.Drawing.Point(13, 65);
            this.chkAutoRotate.Name = "chkAutoRotate";
            this.chkAutoRotate.Size = new System.Drawing.Size(168, 19);
            this.chkAutoRotate.TabIndex = 27;
            this.chkAutoRotate.Text = "Automatically rotate pages";
            this.chkAutoRotate.UseVisualStyleBackColor = true;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(580, 397);
            this.Name = "frmOptions";
            this.Text = "PassportPDF MRC Compressor - Options";
            this.tabControl1.ResumeLayout(false);
            this.tabCompression.ResumeLayout(false);
            this.tabCompression.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuImageQuality)).EndInit();
            this.panelCompression.ResumeLayout(false);
            this.panelCompression.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDownscaleResolution)).EndInit();
            this.tabOutputFormat.ResumeLayout(false);
            this.tabOutputFormat.PerformLayout();
            this.panelOutputFormat.ResumeLayout(false);
            this.panelOutputFormat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabCompression;
        private System.Windows.Forms.Label lbColorCompressionScheme;
        private System.Windows.Forms.Label lbDpi;
        private System.Windows.Forms.CheckBox chkDownscaleImages;
        private System.Windows.Forms.ComboBox cmbBitonalCompressionScheme;
        private System.Windows.Forms.NumericUpDown nuDownscaleResolution;
        private System.Windows.Forms.Label lbResolution;
        private System.Windows.Forms.Label lbBitonalCompressionScheme;
        private System.Windows.Forms.ComboBox cmbColorCompressionScheme;
        private System.Windows.Forms.Label lbImageQuality;
        private System.Windows.Forms.NumericUpDown nuImageQuality;
        private System.Windows.Forms.TabPage tabOutputFormat;
        private System.Windows.Forms.ComboBox cmbPdfVersion;
        private System.Windows.Forms.Label lbPdfVersion;
        private System.Windows.Forms.CheckBox chkFastWebView;
        private System.Windows.Forms.CheckBox chkPreserveSmoothing;
        private System.Windows.Forms.Panel panelCompression;
        private System.Windows.Forms.Panel panelOutputFormat;
        private System.Windows.Forms.NumericUpDown nuPms;
        private System.Windows.Forms.Label lbPms;
        private System.Windows.Forms.CheckBox chkAutoRotate;
    }
}