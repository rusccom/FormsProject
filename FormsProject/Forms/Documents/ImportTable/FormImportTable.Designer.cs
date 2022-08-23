namespace FormsProject.Forms.Documents.ImportTable
{
    partial class FormImportTable
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
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.dcbTmcGroup = new FormsProject.Controls.DataComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // bOk
            // 
            this.bOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bOk.Location = new System.Drawing.Point(12, 562);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(103, 28);
            this.bOk.TabIndex = 1;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bCancel.Location = new System.Drawing.Point(121, 562);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(103, 28);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Новые позиции записать в группу";
            // 
            // dgvResult
            // 
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvResult.Location = new System.Drawing.Point(12, 37);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersWidth = 51;
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.Size = new System.Drawing.Size(1037, 519);
            this.dgvResult.TabIndex = 5;
            // 
            // dcbTmcGroup
            // 
            this.dcbTmcGroup.FieldName = "";
            this.dcbTmcGroup.FormattingEnabled = true;
            this.dcbTmcGroup.Location = new System.Drawing.Point(267, 7);
            this.dcbTmcGroup.Modified = false;
            this.dcbTmcGroup.Name = "dcbTmcGroup";
            this.dcbTmcGroup.Size = new System.Drawing.Size(238, 24);
            this.dcbTmcGroup.TabIndex = 3;
            this.dcbTmcGroup.TableName = "[TmcGroup]";
            // 
            // FormImportTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 597);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dcbTmcGroup);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.MinimumSize = new System.Drawing.Size(878, 436);
            this.Name = "FormImportTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма для импорта";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
        private Controls.DataComboBox dcbTmcGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvResult;
    }
}