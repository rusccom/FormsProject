namespace FormsProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.userMenuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTMC = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiGroupTmc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClient = new System.Windows.Forms.ToolStripMenuItem();
            this.единицаИзмеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDocumentIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDocumentOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDocumentMoneyIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDocumentMoneyOut = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЗаказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReport = new System.Windows.Forms.ToolStripMenuItem();
            this.отчет1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остаткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiService = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.UserToolStripMenu = new System.Windows.Forms.ToolStrip();
            this.userMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // userMenuStrip
            // 
            this.userMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.userMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiDirectory,
            this.tsmiDocument,
            this.storeToolStripMenuItem,
            this.tsmiReport,
            this.tsmiService,
            this.tsmiHelp});
            this.userMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.userMenuStrip.Name = "userMenuStrip";
            this.userMenuStrip.Size = new System.Drawing.Size(912, 33);
            this.userMenuStrip.TabIndex = 1;
            this.userMenuStrip.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.AutoSize = false;
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(59, 25);
            this.tsmiFile.Text = "Файл";
            this.tsmiFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiFile.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(143, 28);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiDirectory
            // 
            this.tsmiDirectory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTMC,
            this.toolStripSeparator1,
            this.tsmiGroupTmc,
            this.tsmiClient,
            this.единицаИзмеренияToolStripMenuItem});
            this.tsmiDirectory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiDirectory.Name = "tsmiDirectory";
            this.tsmiDirectory.Size = new System.Drawing.Size(131, 29);
            this.tsmiDirectory.Text = "Справочники";
            this.tsmiDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsmiTMC
            // 
            this.tsmiTMC.Name = "tsmiTMC";
            this.tsmiTMC.Size = new System.Drawing.Size(253, 28);
            this.tsmiTMC.Text = "ТМЦ";
            this.tsmiTMC.Click += new System.EventHandler(this.tsmiTMC_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(250, 6);
            // 
            // tsmiGroupTmc
            // 
            this.tsmiGroupTmc.Name = "tsmiGroupTmc";
            this.tsmiGroupTmc.Size = new System.Drawing.Size(253, 28);
            this.tsmiGroupTmc.Text = "Группы ТМЦ";
            this.tsmiGroupTmc.Click += new System.EventHandler(this.tsmiGroupTmc_Click);
            // 
            // tsmiClient
            // 
            this.tsmiClient.Name = "tsmiClient";
            this.tsmiClient.Size = new System.Drawing.Size(253, 28);
            this.tsmiClient.Text = "Контрагенты";
            this.tsmiClient.Click += new System.EventHandler(this.tsmiClient_Click);
            // 
            // единицаИзмеренияToolStripMenuItem
            // 
            this.единицаИзмеренияToolStripMenuItem.Name = "единицаИзмеренияToolStripMenuItem";
            this.единицаИзмеренияToolStripMenuItem.Size = new System.Drawing.Size(253, 28);
            this.единицаИзмеренияToolStripMenuItem.Text = "Единица измерения";
            this.единицаИзмеренияToolStripMenuItem.Click += new System.EventHandler(this.единицаИзмеренияToolStripMenuItem_Click);
            // 
            // tsmiDocument
            // 
            this.tsmiDocument.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDocumentIn,
            this.tsmiDocumentOut,
            this.toolStripSeparator2,
            this.tsmiDocumentMoneyIn,
            this.tsmiDocumentMoneyOut});
            this.tsmiDocument.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiDocument.Name = "tsmiDocument";
            this.tsmiDocument.Size = new System.Drawing.Size(112, 29);
            this.tsmiDocument.Text = "Документы";
            // 
            // tsmiDocumentIn
            // 
            this.tsmiDocumentIn.Name = "tsmiDocumentIn";
            this.tsmiDocumentIn.Size = new System.Drawing.Size(212, 28);
            this.tsmiDocumentIn.Text = "Приход товара";
            this.tsmiDocumentIn.Click += new System.EventHandler(this.tsmiDocumentIn_Click);
            // 
            // tsmiDocumentOut
            // 
            this.tsmiDocumentOut.Name = "tsmiDocumentOut";
            this.tsmiDocumentOut.Size = new System.Drawing.Size(212, 28);
            this.tsmiDocumentOut.Text = "Расход товара";
            this.tsmiDocumentOut.Click += new System.EventHandler(this.tsmiDocumentOut_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // tsmiDocumentMoneyIn
            // 
            this.tsmiDocumentMoneyIn.Name = "tsmiDocumentMoneyIn";
            this.tsmiDocumentMoneyIn.Size = new System.Drawing.Size(212, 28);
            this.tsmiDocumentMoneyIn.Text = "Приход кассы";
            this.tsmiDocumentMoneyIn.Click += new System.EventHandler(this.tsmiDocumentMoneyIn_Click);
            // 
            // tsmiDocumentMoneyOut
            // 
            this.tsmiDocumentMoneyOut.Name = "tsmiDocumentMoneyOut";
            this.tsmiDocumentMoneyOut.Size = new System.Drawing.Size(212, 28);
            this.tsmiDocumentMoneyOut.Text = "Расход кассы";
            this.tsmiDocumentMoneyOut.Click += new System.EventHandler(this.tsmiDocumentMoneyOut_Click);
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокЗаказовToolStripMenuItem});
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(187, 29);
            this.storeToolStripMenuItem.Text = "Интернет-магазин";
            // 
            // списокЗаказовToolStripMenuItem
            // 
            this.списокЗаказовToolStripMenuItem.Name = "списокЗаказовToolStripMenuItem";
            this.списокЗаказовToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.списокЗаказовToolStripMenuItem.Text = "Список заказов";
            this.списокЗаказовToolStripMenuItem.Click += new System.EventHandler(this.списокЗаказовToolStripMenuItem_Click);
            // 
            // tsmiReport
            // 
            this.tsmiReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчет1ToolStripMenuItem,
            this.остаткиToolStripMenuItem});
            this.tsmiReport.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiReport.Name = "tsmiReport";
            this.tsmiReport.Size = new System.Drawing.Size(82, 29);
            this.tsmiReport.Text = "Отчеты";
            // 
            // отчет1ToolStripMenuItem
            // 
            this.отчет1ToolStripMenuItem.Name = "отчет1ToolStripMenuItem";
            this.отчет1ToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.отчет1ToolStripMenuItem.Text = "Отчет №1";
            this.отчет1ToolStripMenuItem.Click += new System.EventHandler(this.отчет1ToolStripMenuItem_Click);
            // 
            // остаткиToolStripMenuItem
            // 
            this.остаткиToolStripMenuItem.Name = "остаткиToolStripMenuItem";
            this.остаткиToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.остаткиToolStripMenuItem.Text = "Остатки";
            this.остаткиToolStripMenuItem.Click += new System.EventHandler(this.остаткиToolStripMenuItem_Click);
            // 
            // tsmiService
            // 
            this.tsmiService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUsers});
            this.tsmiService.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiService.Name = "tsmiService";
            this.tsmiService.Size = new System.Drawing.Size(81, 29);
            this.tsmiService.Text = "Сервис";
            // 
            // tsmiUsers
            // 
            this.tsmiUsers.Name = "tsmiUsers";
            this.tsmiUsers.Size = new System.Drawing.Size(205, 28);
            this.tsmiUsers.Text = "Пользователи";
            this.tsmiUsers.Click += new System.EventHandler(this.tsmiUsers_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(90, 29);
            this.tsmiHelp.Text = "Справка";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(201, 28);
            this.tsmiAbout.Text = "О программе";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // UserToolStripMenu
            // 
            this.UserToolStripMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserToolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.UserToolStripMenu.Location = new System.Drawing.Point(0, 542);
            this.UserToolStripMenu.Name = "UserToolStripMenu";
            this.UserToolStripMenu.Size = new System.Drawing.Size(912, 25);
            this.UserToolStripMenu.TabIndex = 3;
            this.UserToolStripMenu.Text = "toolStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 567);
            this.Controls.Add(this.UserToolStripMenu);
            this.Controls.Add(this.userMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.userMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(927, 605);
            this.Name = "MainForm";
            this.Text = "База";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.userMenuStrip.ResumeLayout(false);
            this.userMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDirectory;
        private System.Windows.Forms.ToolStripMenuItem tsmiTMC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiGroupTmc;
        private System.Windows.Forms.ToolStripMenuItem tsmiClient;
        private System.Windows.Forms.ToolStripMenuItem tsmiDocument;
        private System.Windows.Forms.ToolStripMenuItem tsmiDocumentIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiDocumentOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiDocumentMoneyIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiDocumentMoneyOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiReport;
        private System.Windows.Forms.ToolStripMenuItem tsmiService;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        public System.Windows.Forms.ToolStrip UserToolStripMenu;
        private System.Windows.Forms.MenuStrip userMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem единицаИзмеренияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчет1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остаткиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЗаказовToolStripMenuItem;
    }
}

