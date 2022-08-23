namespace FormsProject.Forms.Directory
{
    partial class FormTmcGroup
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
            this.dtbName = new FormsProject.Controls.DataTextBox();
            this.dcbGroupId = new FormsProject.Controls.DataComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(174, 67);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(93, 67);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(12, 67);
            // 
            // dtbName
            // 
            this.dtbName.FieldName = "[name]";
            this.dtbName.FieldType = FormsProject.Operations.FieldDataType.STRING;
            this.dtbName.Location = new System.Drawing.Point(113, 12);
            this.dtbName.Name = "dtbName";
            this.dtbName.NotNull = false;
            this.dtbName.Size = new System.Drawing.Size(191, 20);
            this.dtbName.TabIndex = 20;
            // 
            // dcbGroupId
            // 
            this.dcbGroupId.FieldName = "[GroupId]";
            this.dcbGroupId.FormattingEnabled = true;
            this.dcbGroupId.Location = new System.Drawing.Point(113, 38);
            this.dcbGroupId.Name = "dcbGroupId";
            this.dcbGroupId.Size = new System.Drawing.Size(191, 21);
            this.dcbGroupId.TabIndex = 21;
            this.dcbGroupId.TableName = "[TmcGroup]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Группа";
            // 
            // FormTmcGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 102);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dcbGroupId);
            this.Controls.Add(this.dtbName);
            this.MinimumSize = new System.Drawing.Size(334, 141);
            this.Name = "FormTmcGroup";
            this.Text = "FormTmcGroup";
            this.Controls.SetChildIndex(this.bOk, 0);
            this.Controls.SetChildIndex(this.bCancel, 0);
            this.Controls.SetChildIndex(this.bApply, 0);
            this.Controls.SetChildIndex(this.dtbName, 0);
            this.Controls.SetChildIndex(this.dcbGroupId, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.DataTextBox dtbName;
        private Controls.DataComboBox dcbGroupId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}