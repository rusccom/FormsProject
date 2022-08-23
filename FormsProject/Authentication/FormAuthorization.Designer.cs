namespace FormsProject.Authentication
{
    partial class FormAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.lPassword = new System.Windows.Forms.Label();
            this.lUser = new System.Windows.Forms.Label();
            this.dcbLogin = new FormsProject.Controls.DataComboBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(255, 64);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 13;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(174, 64);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 12;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(85, 41);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(48, 13);
            this.lPassword.TabIndex = 11;
            this.lPassword.Text = "Пароль:";
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(85, 15);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(83, 13);
            this.lUser.TabIndex = 10;
            this.lUser.Text = "Пользователь:";
            // 
            // dcbLogin
            // 
            this.dcbLogin.FormattingEnabled = true;
            this.dcbLogin.Location = new System.Drawing.Point(174, 12);
            this.dcbLogin.Name = "dcbLogin";
            this.dcbLogin.Size = new System.Drawing.Size(239, 21);
            this.dcbLogin.TabIndex = 14;
            this.dcbLogin.TableName = "[system].[login]";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(174, 38);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(239, 20);
            this.tbPass.TabIndex = 15;
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 94);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.dcbLogin);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(441, 133);
            this.MinimumSize = new System.Drawing.Size(441, 133);
            this.Name = "FormAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lUser;
        private Controls.DataComboBox dcbLogin;
        private System.Windows.Forms.TextBox tbPass;
    }
}