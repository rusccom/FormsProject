namespace FormsProject.Forms.Documents
{
    partial class FormDocumentsListView
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
            this.tvResult = new FormsProject.Controls.TableView();
            ((System.ComponentModel.ISupportInitialize)(this.tvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tvResult
            // 
            this.tvResult.AllowUserToAddRows = false;
            this.tvResult.AllowUserToDeleteRows = false;
            this.tvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvResult.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tvResult.ColumnHeadersHeight = 29;
            this.tvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tvResult.Location = new System.Drawing.Point(16, 34);
            this.tvResult.Margin = new System.Windows.Forms.Padding(4);
            this.tvResult.MultiSelect = false;
            this.tvResult.Name = "tvResult";
            this.tvResult.ReadOnly = true;
            this.tvResult.RowHeadersWidth = 51;
            this.tvResult.Size = new System.Drawing.Size(1223, 513);
            this.tvResult.TabIndex = 21;
            // 
            // FormDocumentsListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 560);
            this.Controls.Add(this.tvResult);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MinimumSize = new System.Drawing.Size(1270, 607);
            this.Name = "FormDocumentsListView";
            this.Text = "FormDocumentsListView";
            this.Controls.SetChildIndex(this.tvResult, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.TableView tvResult;
    }
}