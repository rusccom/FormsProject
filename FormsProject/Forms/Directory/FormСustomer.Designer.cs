namespace FormsProject.Forms.Directory
{
    partial class FormСustomer
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
            this.lName = new System.Windows.Forms.Label();
            this.linfo = new System.Windows.Forms.Label();
            this.lNote = new System.Windows.Forms.Label();
            this.dtbName = new FormsProject.Controls.DataTextBox();
            this.dtbAddress = new FormsProject.Controls.DataTextBox();
            this.dtbInfo = new FormsProject.Controls.DataTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dcbPriceType = new FormsProject.Controls.DataComboBox();
            this.SuspendLayout();
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(174, 164);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(93, 164);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(12, 164);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(9, 15);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(65, 13);
            this.lName.TabIndex = 20;
            this.lName.Text = "Контрагент";
            // 
            // linfo
            // 
            this.linfo.AutoSize = true;
            this.linfo.Location = new System.Drawing.Point(9, 68);
            this.linfo.Name = "linfo";
            this.linfo.Size = new System.Drawing.Size(56, 13);
            this.linfo.TabIndex = 22;
            this.linfo.Text = "Контакты";
            // 
            // lNote
            // 
            this.lNote.AutoSize = true;
            this.lNote.Location = new System.Drawing.Point(9, 94);
            this.lNote.Name = "lNote";
            this.lNote.Size = new System.Drawing.Size(63, 13);
            this.lNote.TabIndex = 24;
            this.lNote.Text = "Доп. инфо.";
            // 
            // dtbName
            // 
            this.dtbName.FieldName = "[name]";
            this.dtbName.FieldType = FormsProject.Operations.FieldDataType.STRING;
            this.dtbName.Location = new System.Drawing.Point(80, 12);
            this.dtbName.Name = "dtbName";
            this.dtbName.NotNull = false;
            this.dtbName.Size = new System.Drawing.Size(376, 20);
            this.dtbName.TabIndex = 25;
            // 
            // dtbAddress
            // 
            this.dtbAddress.FieldName = "[address]";
            this.dtbAddress.FieldType = FormsProject.Operations.FieldDataType.STRING;
            this.dtbAddress.Location = new System.Drawing.Point(80, 65);
            this.dtbAddress.Name = "dtbAddress";
            this.dtbAddress.NotNull = false;
            this.dtbAddress.Size = new System.Drawing.Size(376, 20);
            this.dtbAddress.TabIndex = 26;
            // 
            // dtbInfo
            // 
            this.dtbInfo.FieldName = "[info]";
            this.dtbInfo.FieldType = FormsProject.Operations.FieldDataType.STRING;
            this.dtbInfo.Location = new System.Drawing.Point(80, 91);
            this.dtbInfo.Multiline = true;
            this.dtbInfo.Name = "dtbInfo";
            this.dtbInfo.NotNull = false;
            this.dtbInfo.Size = new System.Drawing.Size(376, 66);
            this.dtbInfo.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Тип цены";
            // 
            // dcbPriceType
            // 
            this.dcbPriceType.FieldName = "[PriceTypeId]";
            this.dcbPriceType.FormattingEnabled = true;
            this.dcbPriceType.Location = new System.Drawing.Point(80, 38);
            this.dcbPriceType.Modified = false;
            this.dcbPriceType.Name = "dcbPriceType";
            this.dcbPriceType.Size = new System.Drawing.Size(169, 21);
            this.dcbPriceType.TabIndex = 30;
            this.dcbPriceType.TableName = "[PriceType]";
            // 
            // FormСustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 199);
            this.Controls.Add(this.dcbPriceType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtbInfo);
            this.Controls.Add(this.dtbAddress);
            this.Controls.Add(this.dtbName);
            this.Controls.Add(this.lNote);
            this.Controls.Add(this.linfo);
            this.Controls.Add(this.lName);
            this.MinimumSize = new System.Drawing.Size(484, 238);
            this.Name = "FormСustomer";
            this.Text = "Контрагент";
            this.Controls.SetChildIndex(this.bOk, 0);
            this.Controls.SetChildIndex(this.bCancel, 0);
            this.Controls.SetChildIndex(this.bApply, 0);
            this.Controls.SetChildIndex(this.lName, 0);
            this.Controls.SetChildIndex(this.linfo, 0);
            this.Controls.SetChildIndex(this.lNote, 0);
            this.Controls.SetChildIndex(this.dtbName, 0);
            this.Controls.SetChildIndex(this.dtbAddress, 0);
            this.Controls.SetChildIndex(this.dtbInfo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dcbPriceType, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label linfo;
        private System.Windows.Forms.Label lNote;
        private Controls.DataTextBox dtbName;
        private Controls.DataTextBox dtbAddress;
        private Controls.DataTextBox dtbInfo;
        private System.Windows.Forms.Label label1;
        private Controls.DataComboBox dcbPriceType;
    }
}