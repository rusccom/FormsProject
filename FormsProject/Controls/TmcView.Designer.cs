namespace FormsProject.Controls
{
    partial class TmcView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TmcGroup = new System.Windows.Forms.TreeView();
            this.TmcList = new FormsProject.Controls.TableView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TmcList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TmcGroup);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TmcList);
            this.splitContainer1.Size = new System.Drawing.Size(670, 268);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 0;
            // 
            // TmcGroup
            // 
            this.TmcGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TmcGroup.Location = new System.Drawing.Point(0, 0);
            this.TmcGroup.Name = "TmcGroup";
            this.TmcGroup.Size = new System.Drawing.Size(150, 268);
            this.TmcGroup.TabIndex = 0;
            // 
            // TmcList
            // 
            this.TmcList.AllowUserToAddRows = false;
            this.TmcList.AllowUserToDeleteRows = false;
            this.TmcList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.TmcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TmcList.Location = new System.Drawing.Point(0, 0);
            this.TmcList.MultiSelect = false;
            this.TmcList.Name = "TmcList";
            this.TmcList.ReadOnly = true;
            this.TmcList.Size = new System.Drawing.Size(516, 268);
            this.TmcList.TabIndex = 0;
            // 
            // TmcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "TmcView";
            this.Size = new System.Drawing.Size(670, 268);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TmcList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TreeView TmcGroup;
        public TableView TmcList;
    }
}
