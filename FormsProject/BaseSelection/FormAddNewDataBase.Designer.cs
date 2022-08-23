namespace FormsProject.BaseSelection
{
    partial class FormAddNewDataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddNewDataBase));
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lName = new System.Windows.Forms.Label();
            this.lServer = new System.Windows.Forms.Label();
            this.lDataBase = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbBase = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(166, 116);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 0;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(247, 116);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(100, 15);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(60, 13);
            this.lName.TabIndex = 2;
            this.lName.Text = "Название:";
            // 
            // lServer
            // 
            this.lServer.AutoSize = true;
            this.lServer.Location = new System.Drawing.Point(100, 41);
            this.lServer.Name = "lServer";
            this.lServer.Size = new System.Drawing.Size(47, 13);
            this.lServer.TabIndex = 3;
            this.lServer.Text = "Сервер:";
            // 
            // lDataBase
            // 
            this.lDataBase.AutoSize = true;
            this.lDataBase.Location = new System.Drawing.Point(100, 93);
            this.lDataBase.Name = "lDataBase";
            this.lDataBase.Size = new System.Drawing.Size(35, 13);
            this.lDataBase.TabIndex = 4;
            this.lDataBase.Text = "База:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(166, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(379, 20);
            this.tbName.TabIndex = 5;
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(166, 38);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(379, 20);
            this.tbServer.TabIndex = 6;
            // 
            // tbBase
            // 
            this.tbBase.Location = new System.Drawing.Point(166, 90);
            this.tbBase.Name = "tbBase";
            this.tbBase.Size = new System.Drawing.Size(379, 20);
            this.tbBase.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(166, 64);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(379, 20);
            this.tbPass.TabIndex = 10;
            // 
            // lPass
            // 
            this.lPass.AutoSize = true;
            this.lPass.Location = new System.Drawing.Point(100, 67);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(48, 13);
            this.lPass.TabIndex = 9;
            this.lPass.Text = "Пароль:";
            // 
            // FormAddNewDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 148);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.lPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbBase);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lDataBase);
            this.Controls.Add(this.lServer);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(573, 187);
            this.MinimumSize = new System.Drawing.Size(573, 187);
            this.Name = "FormAddNewDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "База данных:";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lServer;
        private System.Windows.Forms.Label lDataBase;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.TextBox tbServer;
        public System.Windows.Forms.TextBox tbBase;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lPass;
    }
}