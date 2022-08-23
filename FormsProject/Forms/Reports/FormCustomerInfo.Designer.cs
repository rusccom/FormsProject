namespace FormsProject.Forms.Reports
{
    partial class FormCustomerInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lallBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lpIn = new System.Windows.Forms.Label();
            this.lpOut = new System.Windows.Forms.Label();
            this.lmIn = new System.Windows.Forms.Label();
            this.lmOut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lNonCashIn = new System.Windows.Forms.Label();
            this.lNonCashOut = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFrom.Size = new System.Drawing.Size(265, 22);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(450, 2);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpTo.Size = new System.Drawing.Size(265, 22);
            // 
            // groupBox1
            // 
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(1222, 412);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 491);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Баланс:";
            // 
            // lallBalance
            // 
            this.lallBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lallBalance.AutoSize = true;
            this.lallBalance.Location = new System.Drawing.Point(145, 491);
            this.lallBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lallBalance.Name = "lallBalance";
            this.lallBalance.Size = new System.Drawing.Size(20, 17);
            this.lallBalance.TabIndex = 4;
            this.lallBalance.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Получил денег:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Выплатил:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Купил:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Продал нам:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lpIn);
            this.groupBox2.Controls.Add(this.lpOut);
            this.groupBox2.Controls.Add(this.lmIn);
            this.groupBox2.Controls.Add(this.lmOut);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(972, 455);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(267, 92);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "За период";
            // 
            // lpIn
            // 
            this.lpIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lpIn.AutoSize = true;
            this.lpIn.Location = new System.Drawing.Point(128, 20);
            this.lpIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lpIn.Name = "lpIn";
            this.lpIn.Size = new System.Drawing.Size(20, 17);
            this.lpIn.TabIndex = 13;
            this.lpIn.Text = "...";
            // 
            // lpOut
            // 
            this.lpOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lpOut.AutoSize = true;
            this.lpOut.Location = new System.Drawing.Point(128, 36);
            this.lpOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lpOut.Name = "lpOut";
            this.lpOut.Size = new System.Drawing.Size(20, 17);
            this.lpOut.TabIndex = 12;
            this.lpOut.Text = "...";
            // 
            // lmIn
            // 
            this.lmIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lmIn.AutoSize = true;
            this.lmIn.Location = new System.Drawing.Point(128, 52);
            this.lmIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lmIn.Name = "lmIn";
            this.lmIn.Size = new System.Drawing.Size(20, 17);
            this.lmIn.TabIndex = 11;
            this.lmIn.Text = "...";
            // 
            // lmOut
            // 
            this.lmOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lmOut.AutoSize = true;
            this.lmOut.Location = new System.Drawing.Point(128, 68);
            this.lmOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lmOut.Name = "lmOut";
            this.lmOut.Size = new System.Drawing.Size(20, 17);
            this.lmOut.TabIndex = 10;
            this.lmOut.Text = "...";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 507);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Он долг безнал:";
            // 
            // lNonCashIn
            // 
            this.lNonCashIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lNonCashIn.AutoSize = true;
            this.lNonCashIn.Location = new System.Drawing.Point(145, 507);
            this.lNonCashIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNonCashIn.Name = "lNonCashIn";
            this.lNonCashIn.Size = new System.Drawing.Size(20, 17);
            this.lNonCashIn.TabIndex = 11;
            this.lNonCashIn.Text = "...";
            // 
            // lNonCashOut
            // 
            this.lNonCashOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lNonCashOut.AutoSize = true;
            this.lNonCashOut.Location = new System.Drawing.Point(145, 523);
            this.lNonCashOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNonCashOut.Name = "lNonCashOut";
            this.lNonCashOut.Size = new System.Drawing.Size(20, 17);
            this.lNonCashOut.TabIndex = 12;
            this.lNonCashOut.Text = "...";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 523);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Мы долг безнал:";
            // 
            // FormCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 560);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lNonCashOut);
            this.Controls.Add(this.lNonCashIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lallBalance);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MinimumSize = new System.Drawing.Size(1270, 607);
            this.Name = "FormCustomerInfo";
            this.Text = "FormCustomerInfo";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lallBalance, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lNonCashIn, 0);
            this.Controls.SetChildIndex(this.lNonCashOut, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lallBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lpIn;
        private System.Windows.Forms.Label lpOut;
        private System.Windows.Forms.Label lmIn;
        private System.Windows.Forms.Label lmOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lNonCashIn;
        private System.Windows.Forms.Label lNonCashOut;
        private System.Windows.Forms.Label label9;
    }
}