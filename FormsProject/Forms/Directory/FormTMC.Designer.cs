namespace FormsProject.Forms.Directory
{
    partial class FormTMC
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
            this.lCode = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lUnit = new System.Windows.Forms.Label();
            this.lMinQuantity = new System.Windows.Forms.Label();
            this.lPrice0 = new System.Windows.Forms.Label();
            this.lPrice1 = new System.Windows.Forms.Label();
            this.lPrice2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dcbUnitId = new FormsProject.Controls.DataComboBox();
            this.dtbCode = new FormsProject.Controls.DataTextBox();
            this.dtbName = new FormsProject.Controls.DataTextBox();
            this.dtbPrice = new FormsProject.Controls.DataTextBox();
            this.dtbPrice1 = new FormsProject.Controls.DataTextBox();
            this.dtbPrice2 = new FormsProject.Controls.DataTextBox();
            this.dtbPrice3 = new FormsProject.Controls.DataTextBox();
            this.dataTextBox7 = new FormsProject.Controls.DataTextBox();
            this.dataTextBox3 = new FormsProject.Controls.DataTextBox();
            this.dataTextBox5 = new FormsProject.Controls.DataTextBox();
            this.dataTextBox6 = new FormsProject.Controls.DataTextBox();
            this.dataComboBox1 = new FormsProject.Controls.DataComboBox();
            this.dcbGroup = new FormsProject.Controls.DataComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(174, 220);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(93, 220);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(12, 220);
            // 
            // lCode
            // 
            this.lCode.AutoSize = true;
            this.lCode.Location = new System.Drawing.Point(12, 12);
            this.lCode.Name = "lCode";
            this.lCode.Size = new System.Drawing.Size(48, 13);
            this.lCode.TabIndex = 1;
            this.lCode.Text = "Артикул";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(12, 38);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(83, 13);
            this.lName.TabIndex = 3;
            this.lName.Text = "Наименование";
            // 
            // lUnit
            // 
            this.lUnit.AutoSize = true;
            this.lUnit.Location = new System.Drawing.Point(12, 107);
            this.lUnit.Name = "lUnit";
            this.lUnit.Size = new System.Drawing.Size(109, 13);
            this.lUnit.TabIndex = 5;
            this.lUnit.Text = "Единица измерения";
            // 
            // lMinQuantity
            // 
            this.lMinQuantity.AutoSize = true;
            this.lMinQuantity.Location = new System.Drawing.Point(12, 135);
            this.lMinQuantity.Name = "lMinQuantity";
            this.lMinQuantity.Size = new System.Drawing.Size(113, 13);
            this.lMinQuantity.TabIndex = 7;
            this.lMinQuantity.Text = "Минимальный запас";
            // 
            // lPrice0
            // 
            this.lPrice0.AutoSize = true;
            this.lPrice0.Location = new System.Drawing.Point(389, 80);
            this.lPrice0.Name = "lPrice0";
            this.lPrice0.Size = new System.Drawing.Size(93, 13);
            this.lPrice0.TabIndex = 9;
            this.lPrice0.Text = "Закупочная цена";
            // 
            // lPrice1
            // 
            this.lPrice1.AutoSize = true;
            this.lPrice1.Location = new System.Drawing.Point(389, 106);
            this.lPrice1.Name = "lPrice1";
            this.lPrice1.Size = new System.Drawing.Size(42, 13);
            this.lPrice1.TabIndex = 11;
            this.lPrice1.Text = "Цена 1";
            // 
            // lPrice2
            // 
            this.lPrice2.AutoSize = true;
            this.lPrice2.Location = new System.Drawing.Point(389, 132);
            this.lPrice2.Name = "lPrice2";
            this.lPrice2.Size = new System.Drawing.Size(42, 13);
            this.lPrice2.TabIndex = 13;
            this.lPrice2.Text = "Цена 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Цена 3";
            // 
            // dcbUnitId
            // 
            this.dcbUnitId.FieldName = "[UnitId]";
            this.dcbUnitId.FormattingEnabled = true;
            this.dcbUnitId.Location = new System.Drawing.Point(130, 104);
            this.dcbUnitId.Modified = false;
            this.dcbUnitId.Name = "dcbUnitId";
            this.dcbUnitId.Size = new System.Drawing.Size(179, 21);
            this.dcbUnitId.TabIndex = 25;
            this.dcbUnitId.TableName = "[Unit]";
            // 
            // dtbCode
            // 
            this.dtbCode.FieldName = "[code]";
            this.dtbCode.FieldType = FormsProject.Operations.FieldDataType.STRING;
            this.dtbCode.Location = new System.Drawing.Point(130, 9);
            this.dtbCode.Name = "dtbCode";
            this.dtbCode.NotNull = false;
            this.dtbCode.Size = new System.Drawing.Size(179, 20);
            this.dtbCode.TabIndex = 26;
            // 
            // dtbName
            // 
            this.dtbName.FieldName = "[name]";
            this.dtbName.FieldType = FormsProject.Operations.FieldDataType.STRING;
            this.dtbName.Location = new System.Drawing.Point(130, 35);
            this.dtbName.Multiline = true;
            this.dtbName.Name = "dtbName";
            this.dtbName.NotNull = false;
            this.dtbName.Size = new System.Drawing.Size(458, 36);
            this.dtbName.TabIndex = 27;
            // 
            // dtbPrice
            // 
            this.dtbPrice.FieldName = "[price]";
            this.dtbPrice.FieldType = FormsProject.Operations.FieldDataType.DECIMAL;
            this.dtbPrice.Location = new System.Drawing.Point(488, 77);
            this.dtbPrice.Name = "dtbPrice";
            this.dtbPrice.NotNull = false;
            this.dtbPrice.Size = new System.Drawing.Size(100, 20);
            this.dtbPrice.TabIndex = 28;
            // 
            // dtbPrice1
            // 
            this.dtbPrice1.FieldName = "[price1]";
            this.dtbPrice1.FieldType = FormsProject.Operations.FieldDataType.DECIMAL;
            this.dtbPrice1.Location = new System.Drawing.Point(488, 103);
            this.dtbPrice1.Name = "dtbPrice1";
            this.dtbPrice1.NotNull = false;
            this.dtbPrice1.Size = new System.Drawing.Size(100, 20);
            this.dtbPrice1.TabIndex = 29;
            // 
            // dtbPrice2
            // 
            this.dtbPrice2.FieldName = "[price2]";
            this.dtbPrice2.FieldType = FormsProject.Operations.FieldDataType.DECIMAL;
            this.dtbPrice2.Location = new System.Drawing.Point(488, 129);
            this.dtbPrice2.Name = "dtbPrice2";
            this.dtbPrice2.NotNull = false;
            this.dtbPrice2.Size = new System.Drawing.Size(100, 20);
            this.dtbPrice2.TabIndex = 30;
            // 
            // dtbPrice3
            // 
            this.dtbPrice3.FieldName = "[price3]";
            this.dtbPrice3.FieldType = FormsProject.Operations.FieldDataType.DECIMAL;
            this.dtbPrice3.Location = new System.Drawing.Point(488, 155);
            this.dtbPrice3.Name = "dtbPrice3";
            this.dtbPrice3.NotNull = false;
            this.dtbPrice3.Size = new System.Drawing.Size(100, 20);
            this.dtbPrice3.TabIndex = 31;
            // 
            // dataTextBox7
            // 
            this.dataTextBox7.FieldName = "[MinQuantity]";
            this.dataTextBox7.FieldType = FormsProject.Operations.FieldDataType.DECIMAL;
            this.dataTextBox7.Location = new System.Drawing.Point(130, 132);
            this.dataTextBox7.Name = "dataTextBox7";
            this.dataTextBox7.NotNull = false;
            this.dataTextBox7.Size = new System.Drawing.Size(97, 20);
            this.dataTextBox7.TabIndex = 32;
            // 
            // dataTextBox3
            // 
            this.dataTextBox3.FieldName = "[price]";
            this.dataTextBox3.FieldType = FormsProject.Operations.FieldDataType.DECIMAL;
            this.dataTextBox3.Location = new System.Drawing.Point(111, 77);
            this.dataTextBox3.Name = "dataTextBox3";
            this.dataTextBox3.NotNull = false;
            this.dataTextBox3.Size = new System.Drawing.Size(100, 20);
            this.dataTextBox3.TabIndex = 28;
            // 
            // dataTextBox5
            // 
            this.dataTextBox5.FieldName = "[price2]";
            this.dataTextBox5.FieldType = FormsProject.Operations.FieldDataType.DECIMAL;
            this.dataTextBox5.Location = new System.Drawing.Point(111, 129);
            this.dataTextBox5.Name = "dataTextBox5";
            this.dataTextBox5.NotNull = false;
            this.dataTextBox5.Size = new System.Drawing.Size(100, 20);
            this.dataTextBox5.TabIndex = 30;
            // 
            // dataTextBox6
            // 
            this.dataTextBox6.FieldName = "[price3]";
            this.dataTextBox6.FieldType = FormsProject.Operations.FieldDataType.DECIMAL;
            this.dataTextBox6.Location = new System.Drawing.Point(111, 155);
            this.dataTextBox6.Name = "dataTextBox6";
            this.dataTextBox6.NotNull = false;
            this.dataTextBox6.Size = new System.Drawing.Size(100, 20);
            this.dataTextBox6.TabIndex = 31;
            // 
            // dataComboBox1
            // 
            this.dataComboBox1.FieldName = null;
            this.dataComboBox1.FormattingEnabled = true;
            this.dataComboBox1.Location = new System.Drawing.Point(491, 77);
            this.dataComboBox1.Modified = false;
            this.dataComboBox1.Name = "dataComboBox1";
            this.dataComboBox1.Size = new System.Drawing.Size(97, 21);
            this.dataComboBox1.TabIndex = 25;
            this.dataComboBox1.TableName = null;
            // 
            // dcbGroup
            // 
            this.dcbGroup.FieldName = "[GroupId]";
            this.dcbGroup.FormattingEnabled = true;
            this.dcbGroup.Location = new System.Drawing.Point(130, 77);
            this.dcbGroup.Modified = false;
            this.dcbGroup.Name = "dcbGroup";
            this.dcbGroup.Size = new System.Drawing.Size(253, 21);
            this.dcbGroup.TabIndex = 34;
            this.dcbGroup.TableName = "[TmcGroup]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Группа";
            // 
            // FormTMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 255);
            this.Controls.Add(this.dcbGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataTextBox7);
            this.Controls.Add(this.dtbPrice3);
            this.Controls.Add(this.dtbPrice2);
            this.Controls.Add(this.dtbPrice1);
            this.Controls.Add(this.dtbPrice);
            this.Controls.Add(this.dtbName);
            this.Controls.Add(this.dtbCode);
            this.Controls.Add(this.dcbUnitId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lPrice2);
            this.Controls.Add(this.lPrice1);
            this.Controls.Add(this.lPrice0);
            this.Controls.Add(this.lMinQuantity);
            this.Controls.Add(this.lUnit);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(619, 294);
            this.Name = "FormTMC";
            this.Text = "ТМЦ";
            this.Controls.SetChildIndex(this.bOk, 0);
            this.Controls.SetChildIndex(this.bCancel, 0);
            this.Controls.SetChildIndex(this.bApply, 0);
            this.Controls.SetChildIndex(this.lCode, 0);
            this.Controls.SetChildIndex(this.lName, 0);
            this.Controls.SetChildIndex(this.lUnit, 0);
            this.Controls.SetChildIndex(this.lMinQuantity, 0);
            this.Controls.SetChildIndex(this.lPrice0, 0);
            this.Controls.SetChildIndex(this.lPrice1, 0);
            this.Controls.SetChildIndex(this.lPrice2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dcbUnitId, 0);
            this.Controls.SetChildIndex(this.dtbCode, 0);
            this.Controls.SetChildIndex(this.dtbName, 0);
            this.Controls.SetChildIndex(this.dtbPrice, 0);
            this.Controls.SetChildIndex(this.dtbPrice1, 0);
            this.Controls.SetChildIndex(this.dtbPrice2, 0);
            this.Controls.SetChildIndex(this.dtbPrice3, 0);
            this.Controls.SetChildIndex(this.dataTextBox7, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dcbGroup, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lCode;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lUnit;
        private System.Windows.Forms.Label lMinQuantity;
        private System.Windows.Forms.Label lPrice0;
        private System.Windows.Forms.Label lPrice1;
        private System.Windows.Forms.Label lPrice2;
        private System.Windows.Forms.Label label1;
        private Controls.DataComboBox dcbUnitId;
        private Controls.DataTextBox dtbCode;
        private Controls.DataTextBox dtbName;
        private Controls.DataTextBox dtbPrice;
        private Controls.DataTextBox dtbPrice1;
        private Controls.DataTextBox dtbPrice2;
        private Controls.DataTextBox dtbPrice3;
        private Controls.DataTextBox dataTextBox7;
        private Controls.DataTextBox dataTextBox3;
        private Controls.DataTextBox dataTextBox5;
        private Controls.DataTextBox dataTextBox6;
        private Controls.DataComboBox dataComboBox1;
        private Controls.DataComboBox dcbGroup;
        private System.Windows.Forms.Label label2;
    }
}