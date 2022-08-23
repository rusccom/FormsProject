namespace FormsProject.Forms.Directory
{
    partial class FormUnit
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new FormsProject.Controls.DataTextBox();
            this.tbDescription = new FormsProject.Controls.DataTextBox();
            this.SuspendLayout();
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(174, 69);
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(93, 69);
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(12, 69);
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Описание";
            // 
            // tbName
            // 
            this.tbName.FieldName = "[name]";
            this.tbName.FieldType = FormsProject.Operations.FieldDataType.STRING;
            this.tbName.Location = new System.Drawing.Point(75, 12);
            this.tbName.Name = "tbName";
            this.tbName.NotNull = false;
            this.tbName.Size = new System.Drawing.Size(206, 20);
            this.tbName.TabIndex = 22;
            this.tbName.Tag = "";
            // 
            // tbDescription
            // 
            this.tbDescription.FieldName = "[Description]";
            this.tbDescription.FieldType = FormsProject.Operations.FieldDataType.STRING;
            this.tbDescription.Location = new System.Drawing.Point(75, 38);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.NotNull = false;
            this.tbDescription.Size = new System.Drawing.Size(206, 20);
            this.tbDescription.TabIndex = 23;
            this.tbDescription.Tag = "";
            // 
            // FormUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 104);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(306, 143);
            this.Name = "FormUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Единица измерения";
            this.Controls.SetChildIndex(this.bOk, 0);
            this.Controls.SetChildIndex(this.bCancel, 0);
            this.Controls.SetChildIndex(this.bApply, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbName, 0);
            this.Controls.SetChildIndex(this.tbDescription, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Controls.DataTextBox tbName;
        private Controls.DataTextBox tbDescription;
    }
}