namespace FormsProject.Forms.Directory
{
    partial class FormTmcView
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
            this.tvResult = new FormsProject.Controls.TmcView();
            this.SuspendLayout();
            // 
            // tvResult
            // 
            this.tvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvResult.Location = new System.Drawing.Point(16, 34);
            this.tvResult.Margin = new System.Windows.Forms.Padding(5);
            this.tvResult.Name = "tvResult";
            this.tvResult.Size = new System.Drawing.Size(1222, 512);
            this.tvResult.TabIndex = 0;
            // 
            // FormTmcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 560);
            this.Controls.Add(this.tvResult);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FormTmcView";
            this.Text = "FormTmcView";
            this.Controls.SetChildIndex(this.tvResult, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.TmcView tvResult;
    }
}