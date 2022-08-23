namespace FormsProject.Forms.Documents
{
    partial class FormProducts
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
            this.lDocDate = new System.Windows.Forms.Label();
            this.dtpDocDate = new System.Windows.Forms.DateTimePicker();
            this.lNote = new System.Windows.Forms.Label();
            this.lCustomer = new System.Windows.Forms.Label();
            this.cbDone = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtbRate = new FormsProject.Controls.DataTextBox();
            this.cbAddRate = new System.Windows.Forms.CheckBox();
            this.dcbPriceSelect = new FormsProject.Controls.DataComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtbNote = new FormsProject.Controls.DataTextBox();
            this.dcbCustomer = new FormsProject.Controls.DataComboBox();
            this.tableResult = new FormsProject.Controls.TableView();
            this.dtbCode = new FormsProject.Controls.DataTextBox();
            this.tbUserItemsFilter = new System.Windows.Forms.TextBox();
            this.bUpload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tmcView = new FormsProject.Controls.TmcView();
            this.label1 = new System.Windows.Forms.Label();
            this.lDocumentSuma = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lCountRow = new System.Windows.Forms.Label();
            this.bSaveDoc = new System.Windows.Forms.Button();
            this.bPrintDoc = new System.Windows.Forms.Button();
            this.tbTmcView = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bReCalculatedDoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(174, 457);
            this.bApply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(93, 457);
            this.bCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(12, 457);
            this.bOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // lDocDate
            // 
            this.lDocDate.AutoSize = true;
            this.lDocDate.Location = new System.Drawing.Point(338, 18);
            this.lDocDate.Name = "lDocDate";
            this.lDocDate.Size = new System.Drawing.Size(18, 13);
            this.lDocDate.TabIndex = 22;
            this.lDocDate.Text = "от";
            // 
            // dtpDocDate
            // 
            this.dtpDocDate.Location = new System.Drawing.Point(380, 13);
            this.dtpDocDate.Name = "dtpDocDate";
            this.dtpDocDate.Size = new System.Drawing.Size(152, 20);
            this.dtpDocDate.TabIndex = 23;
            this.dtpDocDate.Tag = "[DocumentDate]";
            // 
            // lNote
            // 
            this.lNote.AutoSize = true;
            this.lNote.Location = new System.Drawing.Point(545, 18);
            this.lNote.Name = "lNote";
            this.lNote.Size = new System.Drawing.Size(35, 13);
            this.lNote.TabIndex = 24;
            this.lNote.Text = "Инфо";
            // 
            // lCustomer
            // 
            this.lCustomer.AutoSize = true;
            this.lCustomer.Location = new System.Drawing.Point(20, 41);
            this.lCustomer.Name = "lCustomer";
            this.lCustomer.Size = new System.Drawing.Size(65, 13);
            this.lCustomer.TabIndex = 26;
            this.lCustomer.Text = "Контрагент";
            // 
            // cbDone
            // 
            this.cbDone.AutoSize = true;
            this.cbDone.Location = new System.Drawing.Point(9, 18);
            this.cbDone.Name = "cbDone";
            this.cbDone.Size = new System.Drawing.Size(76, 17);
            this.cbDone.TabIndex = 29;
            this.cbDone.Tag = "[Done]";
            this.cbDone.Text = "Проведен";
            this.cbDone.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 8);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1124, 440);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.bReCalculatedDoc);
            this.groupBox2.Controls.Add(this.dtbRate);
            this.groupBox2.Controls.Add(this.cbAddRate);
            this.groupBox2.Controls.Add(this.dcbPriceSelect);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtbNote);
            this.groupBox2.Controls.Add(this.dcbCustomer);
            this.groupBox2.Controls.Add(this.tableResult);
            this.groupBox2.Controls.Add(this.dtbCode);
            this.groupBox2.Controls.Add(this.cbDone);
            this.groupBox2.Controls.Add(this.lNote);
            this.groupBox2.Controls.Add(this.lCustomer);
            this.groupBox2.Controls.Add(this.lDocDate);
            this.groupBox2.Controls.Add(this.dtpDocDate);
            this.groupBox2.Controls.Add(this.tbUserItemsFilter);
            this.groupBox2.Controls.Add(this.bUpload);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1118, 202);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "1";
            this.groupBox2.Text = "Документ";
            // 
            // dtbRate
            // 
            this.dtbRate.FieldName = null;
            this.dtbRate.IsSqlData = false;
            this.dtbRate.Location = new System.Drawing.Point(850, 41);
            this.dtbRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtbRate.Name = "dtbRate";
            this.dtbRate.NotNull = false;
            this.dtbRate.Size = new System.Drawing.Size(57, 20);
            this.dtbRate.TabIndex = 41;
            this.dtbRate.Visible = false;
            // 
            // cbAddRate
            // 
            this.cbAddRate.AutoSize = true;
            this.cbAddRate.Location = new System.Drawing.Point(750, 41);
            this.cbAddRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAddRate.Name = "cbAddRate";
            this.cbAddRate.Size = new System.Drawing.Size(101, 17);
            this.cbAddRate.TabIndex = 40;
            this.cbAddRate.Text = "Включить курс";
            this.cbAddRate.UseVisualStyleBackColor = true;
            // 
            // dcbPriceSelect
            // 
            this.dcbPriceSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dcbPriceSelect.FieldName = "";
            this.dcbPriceSelect.FormattingEnabled = true;
            this.dcbPriceSelect.Location = new System.Drawing.Point(961, 14);
            this.dcbPriceSelect.Modified = false;
            this.dcbPriceSelect.Name = "dcbPriceSelect";
            this.dcbPriceSelect.Size = new System.Drawing.Size(150, 21);
            this.dcbPriceSelect.TabIndex = 35;
            this.dcbPriceSelect.TableName = "[PriceType]";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(919, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена:";
            // 
            // dtbNote
            // 
            this.dtbNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtbNote.FieldName = "[note]";
            this.dtbNote.FieldType = FormsProject.Operations.FieldDataType.STRING;
            this.dtbNote.IsSqlData = false;
            this.dtbNote.Location = new System.Drawing.Point(585, 15);
            this.dtbNote.Name = "dtbNote";
            this.dtbNote.NotNull = false;
            this.dtbNote.Size = new System.Drawing.Size(322, 20);
            this.dtbNote.TabIndex = 34;
            // 
            // dcbCustomer
            // 
            this.dcbCustomer.FieldName = "[CustomerId]";
            this.dcbCustomer.FormattingEnabled = true;
            this.dcbCustomer.Location = new System.Drawing.Point(91, 40);
            this.dcbCustomer.Modified = false;
            this.dcbCustomer.Name = "dcbCustomer";
            this.dcbCustomer.Size = new System.Drawing.Size(228, 21);
            this.dcbCustomer.TabIndex = 33;
            this.dcbCustomer.TableName = "[Customer]";
            // 
            // tableResult
            // 
            this.tableResult.AllowUserToAddRows = false;
            this.tableResult.AllowUserToDeleteRows = false;
            this.tableResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableResult.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableResult.Location = new System.Drawing.Point(6, 67);
            this.tableResult.MultiSelect = false;
            this.tableResult.Name = "tableResult";
            this.tableResult.ReadOnly = true;
            this.tableResult.RowHeadersWidth = 51;
            this.tableResult.Size = new System.Drawing.Size(1105, 129);
            this.tableResult.TabIndex = 32;
            this.tableResult.Tag = 1;
            // 
            // dtbCode
            // 
            this.dtbCode.FieldName = "[code]";
            this.dtbCode.FieldType = FormsProject.Operations.FieldDataType.STRING;
            this.dtbCode.IsSqlData = false;
            this.dtbCode.Location = new System.Drawing.Point(91, 15);
            this.dtbCode.Name = "dtbCode";
            this.dtbCode.NotNull = true;
            this.dtbCode.Size = new System.Drawing.Size(228, 20);
            this.dtbCode.TabIndex = 31;
            // 
            // tbUserItemsFilter
            // 
            this.tbUserItemsFilter.Location = new System.Drawing.Point(380, 41);
            this.tbUserItemsFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUserItemsFilter.Name = "tbUserItemsFilter";
            this.tbUserItemsFilter.Size = new System.Drawing.Size(207, 20);
            this.tbUserItemsFilter.TabIndex = 38;
            // 
            // bUpload
            // 
            this.bUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bUpload.Location = new System.Drawing.Point(1028, 38);
            this.bUpload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bUpload.Name = "bUpload";
            this.bUpload.Size = new System.Drawing.Size(82, 23);
            this.bUpload.TabIndex = 39;
            this.bUpload.Text = "Загрузить";
            this.bUpload.UseVisualStyleBackColor = true;
            this.bUpload.Click += new System.EventHandler(this.bUpload_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Поиск";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tmcView);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1118, 221);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Товары";
            // 
            // tmcView
            // 
            this.tmcView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tmcView.Location = new System.Drawing.Point(6, 13);
            this.tmcView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tmcView.Name = "tmcView";
            this.tmcView.Size = new System.Drawing.Size(1106, 202);
            this.tmcView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(934, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Сумма документа:";
            // 
            // lDocumentSuma
            // 
            this.lDocumentSuma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lDocumentSuma.AutoSize = true;
            this.lDocumentSuma.Location = new System.Drawing.Point(1041, 454);
            this.lDocumentSuma.Name = "lDocumentSuma";
            this.lDocumentSuma.Size = new System.Drawing.Size(13, 13);
            this.lDocumentSuma.TabIndex = 32;
            this.lDocumentSuma.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(934, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Количество наименований:";
            // 
            // lCountRow
            // 
            this.lCountRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lCountRow.AutoSize = true;
            this.lCountRow.Location = new System.Drawing.Point(1086, 467);
            this.lCountRow.Name = "lCountRow";
            this.lCountRow.Size = new System.Drawing.Size(13, 13);
            this.lCountRow.TabIndex = 34;
            this.lCountRow.Text = "0";
            // 
            // bSaveDoc
            // 
            this.bSaveDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bSaveDoc.Location = new System.Drawing.Point(315, 457);
            this.bSaveDoc.Name = "bSaveDoc";
            this.bSaveDoc.Size = new System.Drawing.Size(75, 23);
            this.bSaveDoc.TabIndex = 35;
            this.bSaveDoc.Text = "Сохранить";
            this.bSaveDoc.UseVisualStyleBackColor = true;
            this.bSaveDoc.Click += new System.EventHandler(this.bSaveDoc_Click);
            // 
            // bPrintDoc
            // 
            this.bPrintDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bPrintDoc.Location = new System.Drawing.Point(396, 457);
            this.bPrintDoc.Name = "bPrintDoc";
            this.bPrintDoc.Size = new System.Drawing.Size(75, 23);
            this.bPrintDoc.TabIndex = 36;
            this.bPrintDoc.Text = "Печать";
            this.bPrintDoc.UseVisualStyleBackColor = true;
            this.bPrintDoc.Click += new System.EventHandler(this.bPrintDoc_Click);
            // 
            // tbTmcView
            // 
            this.tbTmcView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbTmcView.Location = new System.Drawing.Point(526, 457);
            this.tbTmcView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTmcView.Name = "tbTmcView";
            this.tbTmcView.Size = new System.Drawing.Size(207, 20);
            this.tbTmcView.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Поиск";
            // 
            // bReCalculatedDoc
            // 
            this.bReCalculatedDoc.Location = new System.Drawing.Point(592, 38);
            this.bReCalculatedDoc.Name = "bReCalculatedDoc";
            this.bReCalculatedDoc.Size = new System.Drawing.Size(153, 23);
            this.bReCalculatedDoc.TabIndex = 42;
            this.bReCalculatedDoc.Text = "Пересчитать цены";
            this.bReCalculatedDoc.UseVisualStyleBackColor = true;
            this.bReCalculatedDoc.Click += new System.EventHandler(this.bReCalculatedDoc_Click);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 489);
            this.Controls.Add(this.tbTmcView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bPrintDoc);
            this.Controls.Add(this.bSaveDoc);
            this.Controls.Add(this.lCountRow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lDocumentSuma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimumSize = new System.Drawing.Size(1154, 527);
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            this.Controls.SetChildIndex(this.bOk, 0);
            this.Controls.SetChildIndex(this.bCancel, 0);
            this.Controls.SetChildIndex(this.bApply, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lDocumentSuma, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lCountRow, 0);
            this.Controls.SetChildIndex(this.bSaveDoc, 0);
            this.Controls.SetChildIndex(this.bPrintDoc, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbTmcView, 0);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lDocDate;
        private System.Windows.Forms.DateTimePicker dtpDocDate;
        private System.Windows.Forms.Label lNote;
        private System.Windows.Forms.Label lCustomer;
        private System.Windows.Forms.CheckBox cbDone;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controls.TmcView tmcView;
        private Controls.TableView tableResult;
        private Controls.DataTextBox dtbCode;
        private Controls.DataComboBox dcbCustomer;
        private Controls.DataTextBox dtbNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lDocumentSuma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lCountRow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSaveDoc;
        private Controls.DataComboBox dcbPriceSelect;
        private System.Windows.Forms.Button bPrintDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUserItemsFilter;
        private System.Windows.Forms.TextBox tbTmcView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bUpload;
        private System.Windows.Forms.CheckBox cbAddRate;
        private Controls.DataTextBox dtbRate;
        private System.Windows.Forms.Button bReCalculatedDoc;
    }
}