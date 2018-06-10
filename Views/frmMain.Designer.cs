namespace MRCCompressor.Views
{
    partial class frmMain
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
            this.lbCompressionRatio = new System.Windows.Forms.Label();
            this.lbCompressionRatioValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCompressionRatio
            // 
            this.lbCompressionRatio.AutoSize = true;
            this.lbCompressionRatio.Location = new System.Drawing.Point(349, 94);
            this.lbCompressionRatio.Name = "lbCompressionRatio";
            this.lbCompressionRatio.Size = new System.Drawing.Size(73, 13);
            this.lbCompressionRatio.TabIndex = 36;
            this.lbCompressionRatio.Text = "Saved space:";
            // 
            // lbCompressionRatioValue
            // 
            this.lbCompressionRatioValue.AutoSize = true;
            this.lbCompressionRatioValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompressionRatioValue.Location = new System.Drawing.Point(422, 87);
            this.lbCompressionRatioValue.Name = "lbCompressionRatioValue";
            this.lbCompressionRatioValue.Size = new System.Drawing.Size(70, 24);
            this.lbCompressionRatioValue.TabIndex = 37;
            this.lbCompressionRatioValue.Text = "99.99%";
            this.lbCompressionRatioValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(497, 388);
            this.Controls.Add(this.lbCompressionRatioValue);
            this.Controls.Add(this.lbCompressionRatio);
            this.Name = "frmMain";
            this.Text = "Passport PDF Image To PDF MRC";
            this.Controls.SetChildIndex(this.lbCompressionRatio, 0);
            this.Controls.SetChildIndex(this.lbCompressionRatioValue, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCompressionRatio;
        private System.Windows.Forms.Label lbCompressionRatioValue;
    }
}

