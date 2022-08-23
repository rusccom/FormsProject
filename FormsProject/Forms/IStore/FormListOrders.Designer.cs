namespace FormsProject.Forms.IStore
{
    partial class FormListOrders
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
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.bCancel = new System.Windows.Forms.Button();
            this.bPrint = new System.Windows.Forms.Button();
            this.bPrint2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lDeliveredLocal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lDeliveredPost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(12, 12);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersWidth = 51;
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.Size = new System.Drawing.Size(1202, 428);
            this.dgvResult.TabIndex = 0;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bCancel.Location = new System.Drawing.Point(12, 446);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(95, 31);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Закрыть";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bPrint
            // 
            this.bPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bPrint.Location = new System.Drawing.Point(113, 446);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(95, 31);
            this.bPrint.TabIndex = 2;
            this.bPrint.Text = "Печать 1";
            this.bPrint.UseVisualStyleBackColor = true;
            // 
            // bPrint2
            // 
            this.bPrint2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bPrint2.Location = new System.Drawing.Point(214, 446);
            this.bPrint2.Name = "bPrint2";
            this.bPrint2.Size = new System.Drawing.Size(95, 31);
            this.bPrint2.TabIndex = 3;
            this.bPrint2.Text = "Печать 2";
            this.bPrint2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Доставка Минск - ";
            // 
            // lDeliveredLocal
            // 
            this.lDeliveredLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lDeliveredLocal.AutoSize = true;
            this.lDeliveredLocal.Location = new System.Drawing.Point(468, 460);
            this.lDeliveredLocal.Name = "lDeliveredLocal";
            this.lDeliveredLocal.Size = new System.Drawing.Size(16, 17);
            this.lDeliveredLocal.TabIndex = 5;
            this.lDeliveredLocal.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Доставка почтой - ";
            // 
            // lDeliveredPost
            // 
            this.lDeliveredPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lDeliveredPost.AutoSize = true;
            this.lDeliveredPost.Location = new System.Drawing.Point(716, 460);
            this.lDeliveredPost.Name = "lDeliveredPost";
            this.lDeliveredPost.Size = new System.Drawing.Size(16, 17);
            this.lDeliveredPost.TabIndex = 7;
            this.lDeliveredPost.Text = "0";
            // 
            // FormListOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 489);
            this.Controls.Add(this.lDeliveredPost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lDeliveredLocal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bPrint2);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.dgvResult);
            this.MinimumSize = new System.Drawing.Size(1244, 536);
            this.Name = "FormListOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список заказов с интернет - магазина";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.Button bPrint2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lDeliveredLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lDeliveredPost;
    }
}