namespace FormsProject.Forms.Documents
{
    partial class FormMoneyDocuments
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
            this.cbDone = new System.Windows.Forms.CheckBox();
            this.lCustomer = new System.Windows.Forms.Label();
            this.lNote = new System.Windows.Forms.Label();
            this.dtpDocDate = new System.Windows.Forms.DateTimePicker();
            this.lDocDate = new System.Windows.Forms.Label();
            this.lNumber = new System.Windows.Forms.Label();
            this.dcbCustomer = new FormsProject.Controls.DataComboBox();
            this.dtbCode = new FormsProject.Controls.DataTextBox();
            this.dtbNote = new FormsProject.Controls.DataTextBox();
            this.dtbSuma = new FormsProject.Controls.DataTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCash = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(174, 228);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(93, 228);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(12, 228);
            // 
            // cbDone
            // 
            this.cbDone.AutoSize = true;
            this.cbDone.Location = new System.Drawing.Point(276, 42);
            this.cbDone.Name = "cbDone";
            this.cbDone.Size = new System.Drawing.Size(75, 17);
            this.cbDone.TabIndex = 39;
            this.cbDone.Tag = "[Done]";
            this.cbDone.Text = "Оплачено";
            this.cbDone.UseVisualStyleBackColor = true;
            // 
            // lCustomer
            // 
            this.lCustomer.AutoSize = true;
            this.lCustomer.Location = new System.Drawing.Point(12, 41);
            this.lCustomer.Name = "lCustomer";
            this.lCustomer.Size = new System.Drawing.Size(65, 13);
            this.lCustomer.TabIndex = 36;
            this.lCustomer.Text = "Контрагент";
            // 
            // lNote
            // 
            this.lNote.AutoSize = true;
            this.lNote.Location = new System.Drawing.Point(12, 150);
            this.lNote.Name = "lNote";
            this.lNote.Size = new System.Drawing.Size(35, 13);
            this.lNote.TabIndex = 34;
            this.lNote.Text = "Инфо";
            // 
            // dtpDocDate
            // 
            this.dtpDocDate.Location = new System.Drawing.Point(276, 12);
            this.dtpDocDate.Name = "dtpDocDate";
            this.dtpDocDate.Size = new System.Drawing.Size(152, 20);
            this.dtpDocDate.TabIndex = 33;
            this.dtpDocDate.Tag = "[DocumentDate]";
            // 
            // lDocDate
            // 
            this.lDocDate.AutoSize = true;
            this.lDocDate.Location = new System.Drawing.Point(252, 15);
            this.lDocDate.Name = "lDocDate";
            this.lDocDate.Size = new System.Drawing.Size(18, 13);
            this.lDocDate.TabIndex = 32;
            this.lDocDate.Text = "от";
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(12, 15);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(41, 13);
            this.lNumber.TabIndex = 30;
            this.lNumber.Text = "Номер";
            // 
            // dcbCustomer
            // 
            this.dcbCustomer.FieldName = "[CustomerId]";
            this.dcbCustomer.FormattingEnabled = true;
            this.dcbCustomer.Location = new System.Drawing.Point(84, 38);
            this.dcbCustomer.Modified = false;
            this.dcbCustomer.Name = "dcbCustomer";
            this.dcbCustomer.Size = new System.Drawing.Size(165, 21);
            this.dcbCustomer.TabIndex = 41;
            this.dcbCustomer.TableName = "[Customer]";
            // 
            // dtbCode
            // 
            this.dtbCode.FieldName = "[code]";
            this.dtbCode.FieldType = FormsProject.Operations.FieldDataType.STRING;
            this.dtbCode.Location = new System.Drawing.Point(84, 12);
            this.dtbCode.Name = "dtbCode";
            this.dtbCode.NotNull = false;
            this.dtbCode.Size = new System.Drawing.Size(165, 20);
            this.dtbCode.TabIndex = 42;
            // 
            // dtbNote
            // 
            this.dtbNote.FieldName = "[note]";
            this.dtbNote.FieldType = FormsProject.Operations.FieldDataType.STRING;
            this.dtbNote.Location = new System.Drawing.Point(12, 166);
            this.dtbNote.Multiline = true;
            this.dtbNote.Name = "dtbNote";
            this.dtbNote.NotNull = false;
            this.dtbNote.Size = new System.Drawing.Size(416, 56);
            this.dtbNote.TabIndex = 43;
            // 
            // dtbSuma
            // 
            this.dtbSuma.FieldName = "[suma]";
            this.dtbSuma.FieldType = FormsProject.Operations.FieldDataType.DECIMAL;
            this.dtbSuma.Location = new System.Drawing.Point(69, 19);
            this.dtbSuma.Name = "dtbSuma";
            this.dtbSuma.NotNull = false;
            this.dtbSuma.Size = new System.Drawing.Size(155, 20);
            this.dtbSuma.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Сумма";
            // 
            // cbCash
            // 
            this.cbCash.AutoSize = true;
            this.cbCash.Location = new System.Drawing.Point(69, 45);
            this.cbCash.Name = "cbCash";
            this.cbCash.Size = new System.Drawing.Size(63, 17);
            this.cbCash.TabIndex = 46;
            this.cbCash.Tag = "[NonCash]";
            this.cbCash.Text = "Безнал";
            this.cbCash.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtbSuma);
            this.groupBox1.Controls.Add(this.cbCash);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 73);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Деньги";
            // 
            // FormMoneyDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 263);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtbNote);
            this.Controls.Add(this.dtbCode);
            this.Controls.Add(this.dcbCustomer);
            this.Controls.Add(this.cbDone);
            this.Controls.Add(this.lCustomer);
            this.Controls.Add(this.lNote);
            this.Controls.Add(this.dtpDocDate);
            this.Controls.Add(this.lDocDate);
            this.Controls.Add(this.lNumber);
            this.Name = "FormMoneyDocuments";
            this.Text = "FormMoney";
            this.Controls.SetChildIndex(this.bOk, 0);
            this.Controls.SetChildIndex(this.bCancel, 0);
            this.Controls.SetChildIndex(this.bApply, 0);
            this.Controls.SetChildIndex(this.lNumber, 0);
            this.Controls.SetChildIndex(this.lDocDate, 0);
            this.Controls.SetChildIndex(this.dtpDocDate, 0);
            this.Controls.SetChildIndex(this.lNote, 0);
            this.Controls.SetChildIndex(this.lCustomer, 0);
            this.Controls.SetChildIndex(this.cbDone, 0);
            this.Controls.SetChildIndex(this.dcbCustomer, 0);
            this.Controls.SetChildIndex(this.dtbCode, 0);
            this.Controls.SetChildIndex(this.dtbNote, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbDone;
        private System.Windows.Forms.Label lCustomer;
        private System.Windows.Forms.Label lNote;
        private System.Windows.Forms.DateTimePicker dtpDocDate;
        private System.Windows.Forms.Label lDocDate;
        private System.Windows.Forms.Label lNumber;
        private Controls.DataComboBox dcbCustomer;
        private Controls.DataTextBox dtbCode;
        private Controls.DataTextBox dtbNote;
        private Controls.DataTextBox dtbSuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbCash;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}