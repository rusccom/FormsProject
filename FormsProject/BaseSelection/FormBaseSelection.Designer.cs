namespace FormsProject.BaseSelection
{
    partial class FormBaseSelection
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDataBase = new System.Windows.Forms.ListBox();
            this.lDataServer = new System.Windows.Forms.Label();
            this.lDataBase = new System.Windows.Forms.Label();
            this.lBase = new System.Windows.Forms.Label();
            this.lServer = new System.Windows.Forms.Label();
            this.bOk = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lbDataBase);
            this.groupBox1.Controls.Add(this.lDataServer);
            this.groupBox1.Controls.Add(this.lDataBase);
            this.groupBox1.Controls.Add(this.lBase);
            this.groupBox1.Controls.Add(this.lServer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информационные базы";
            // 
            // lbDataBase
            // 
            this.lbDataBase.FormattingEnabled = true;
            this.lbDataBase.Location = new System.Drawing.Point(6, 19);
            this.lbDataBase.Name = "lbDataBase";
            this.lbDataBase.Size = new System.Drawing.Size(322, 238);
            this.lbDataBase.TabIndex = 4;
            // 
            // lDataServer
            // 
            this.lDataServer.AutoSize = true;
            this.lDataServer.Location = new System.Drawing.Point(59, 263);
            this.lDataServer.Name = "lDataServer";
            this.lDataServer.Size = new System.Drawing.Size(16, 13);
            this.lDataServer.TabIndex = 3;
            this.lDataServer.Text = "...";
            // 
            // lDataBase
            // 
            this.lDataBase.AutoSize = true;
            this.lDataBase.Location = new System.Drawing.Point(59, 276);
            this.lDataBase.Name = "lDataBase";
            this.lDataBase.Size = new System.Drawing.Size(16, 13);
            this.lDataBase.TabIndex = 2;
            this.lDataBase.Text = "...";
            // 
            // lBase
            // 
            this.lBase.AutoSize = true;
            this.lBase.Location = new System.Drawing.Point(6, 276);
            this.lBase.Name = "lBase";
            this.lBase.Size = new System.Drawing.Size(35, 13);
            this.lBase.TabIndex = 1;
            this.lBase.Text = "База:";
            // 
            // lServer
            // 
            this.lServer.AutoSize = true;
            this.lServer.Location = new System.Drawing.Point(6, 263);
            this.lServer.Name = "lServer";
            this.lServer.Size = new System.Drawing.Size(47, 13);
            this.lServer.TabIndex = 0;
            this.lServer.Text = "Сервер:";
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(352, 17);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(108, 23);
            this.bOk.TabIndex = 1;
            this.bOk.Text = "Войти";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(352, 102);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(108, 23);
            this.bAdd.TabIndex = 2;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(352, 131);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(108, 23);
            this.bEdit.TabIndex = 3;
            this.bEdit.Text = "Изменить";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(352, 160);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(108, 23);
            this.bDelete.TabIndex = 4;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(352, 290);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(108, 23);
            this.bExit.TabIndex = 5;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // FormBaseSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 325);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(488, 364);
            this.MinimumSize = new System.Drawing.Size(488, 364);
            this.Name = "FormBaseSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор информационной базы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbDataBase;
        private System.Windows.Forms.Label lDataServer;
        private System.Windows.Forms.Label lDataBase;
        private System.Windows.Forms.Label lBase;
        private System.Windows.Forms.Label lServer;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bExit;
    }
}