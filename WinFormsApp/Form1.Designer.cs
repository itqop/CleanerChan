namespace WinFormsApp
{
    partial class Antimalware
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Antimalware));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Quarantine = new System.Windows.Forms.Button();
            this.btn_Close2 = new System.Windows.Forms.Button();
            this.btn_Logs = new System.Windows.Forms.Button();
            this.btn_Main = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Svor = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_Scan = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_FullScan = new System.Windows.Forms.Button();
            this.progress_Scan = new System.Windows.Forms.ProgressBar();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.txt_Line = new System.Windows.Forms.TextBox();
            this.btn_Scan = new System.Windows.Forms.Button();
            this.btn_Explore = new System.Windows.Forms.Button();
            this.btn_Delete_Viruses = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Journal = new System.Windows.Forms.ListView();
            this.panel_Quar = new System.Windows.Forms.Panel();
            this.btn_Del_One = new System.Windows.Forms.Button();
            this.btn_Recovery = new System.Windows.Forms.Button();
            this.Quar_Box = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_Scan.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_Quar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btn_Quarantine);
            this.panel1.Controls.Add(this.btn_Close2);
            this.panel1.Controls.Add(this.btn_Logs);
            this.panel1.Controls.Add(this.btn_Main);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 422);
            this.panel1.TabIndex = 7;
            // 
            // btn_Quarantine
            // 
            this.btn_Quarantine.FlatAppearance.BorderSize = 0;
            this.btn_Quarantine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quarantine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Quarantine.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Quarantine.Location = new System.Drawing.Point(6, 311);
            this.btn_Quarantine.Name = "btn_Quarantine";
            this.btn_Quarantine.Size = new System.Drawing.Size(208, 47);
            this.btn_Quarantine.TabIndex = 13;
            this.btn_Quarantine.Text = "Карантин";
            this.btn_Quarantine.UseVisualStyleBackColor = true;
            this.btn_Quarantine.Click += new System.EventHandler(this.btn_Quarantine_Click);
            // 
            // btn_Close2
            // 
            this.btn_Close2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Close2.FlatAppearance.BorderSize = 0;
            this.btn_Close2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Close2.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Close2.Location = new System.Drawing.Point(3, 372);
            this.btn_Close2.Name = "btn_Close2";
            this.btn_Close2.Size = new System.Drawing.Size(208, 47);
            this.btn_Close2.TabIndex = 12;
            this.btn_Close2.Text = "Выход";
            this.btn_Close2.UseVisualStyleBackColor = false;
            this.btn_Close2.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Logs
            // 
            this.btn_Logs.FlatAppearance.BorderSize = 0;
            this.btn_Logs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Logs.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Logs.Location = new System.Drawing.Point(3, 258);
            this.btn_Logs.Name = "btn_Logs";
            this.btn_Logs.Size = new System.Drawing.Size(211, 47);
            this.btn_Logs.TabIndex = 11;
            this.btn_Logs.Text = "Журнал защиты";
            this.btn_Logs.UseVisualStyleBackColor = true;
            this.btn_Logs.Click += new System.EventHandler(this.btn_Logs_Click);
            // 
            // btn_Main
            // 
            this.btn_Main.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Main.FlatAppearance.BorderSize = 0;
            this.btn_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Main.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Main.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Main.Location = new System.Drawing.Point(3, 205);
            this.btn_Main.Name = "btn_Main";
            this.btn_Main.Size = new System.Drawing.Size(211, 47);
            this.btn_Main.TabIndex = 10;
            this.btn_Main.Text = "Сканирование";
            this.btn_Main.UseVisualStyleBackColor = false;
            this.btn_Main.Click += new System.EventHandler(this.btn_Main_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WinFormsApp.Properties.Resources._123;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(3, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 153);
            this.panel3.TabIndex = 9;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Close.Location = new System.Drawing.Point(865, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(40, 40);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseEnter += new System.EventHandler(this.btn_Close_Enter);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_Close_Leave);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_Svor);
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 40);
            this.panel2.TabIndex = 8;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "CleanerChan";
            // 
            // btn_Svor
            // 
            this.btn_Svor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Svor.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Svor.FlatAppearance.BorderSize = 0;
            this.btn_Svor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Svor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Svor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Svor.Location = new System.Drawing.Point(825, 0);
            this.btn_Svor.Name = "btn_Svor";
            this.btn_Svor.Size = new System.Drawing.Size(40, 40);
            this.btn_Svor.TabIndex = 9;
            this.btn_Svor.Text = "_";
            this.btn_Svor.UseVisualStyleBackColor = false;
            this.btn_Svor.Click += new System.EventHandler(this.btn_Svor_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // panel_Scan
            // 
            this.panel_Scan.BackColor = System.Drawing.Color.ForestGreen;
            this.panel_Scan.Controls.Add(this.label2);
            this.panel_Scan.Controls.Add(this.btn_Play);
            this.panel_Scan.Controls.Add(this.btn_FullScan);
            this.panel_Scan.Controls.Add(this.progress_Scan);
            this.panel_Scan.Controls.Add(this.btn_Pause);
            this.panel_Scan.Controls.Add(this.btn_Stop);
            this.panel_Scan.Controls.Add(this.txt_Line);
            this.panel_Scan.Controls.Add(this.btn_Scan);
            this.panel_Scan.Controls.Add(this.btn_Explore);
            this.panel_Scan.Location = new System.Drawing.Point(213, 37);
            this.panel_Scan.Name = "panel_Scan";
            this.panel_Scan.Size = new System.Drawing.Size(691, 385);
            this.panel_Scan.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(421, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "ИЛИ";
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Play.Enabled = false;
            this.btn_Play.FlatAppearance.BorderSize = 0;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Play.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Play.Location = new System.Drawing.Point(142, 271);
            this.btn_Play.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(114, 41);
            this.btn_Play.TabIndex = 9;
            this.btn_Play.Text = "Пуск";
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_FullScan
            // 
            this.btn_FullScan.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_FullScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FullScan.FlatAppearance.BorderSize = 0;
            this.btn_FullScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FullScan.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_FullScan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_FullScan.Location = new System.Drawing.Point(502, 49);
            this.btn_FullScan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_FullScan.Name = "btn_FullScan";
            this.btn_FullScan.Size = new System.Drawing.Size(149, 64);
            this.btn_FullScan.TabIndex = 8;
            this.btn_FullScan.Text = "Полное сканирование";
            this.btn_FullScan.UseVisualStyleBackColor = false;
            this.btn_FullScan.Click += new System.EventHandler(this.btn_FullScan_Click);
            // 
            // progress_Scan
            // 
            this.progress_Scan.BackColor = System.Drawing.Color.ForestGreen;
            this.progress_Scan.Location = new System.Drawing.Point(142, 218);
            this.progress_Scan.Name = "progress_Scan";
            this.progress_Scan.Size = new System.Drawing.Size(392, 29);
            this.progress_Scan.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progress_Scan.TabIndex = 7;
            // 
            // btn_Pause
            // 
            this.btn_Pause.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pause.Enabled = false;
            this.btn_Pause.FlatAppearance.BorderSize = 0;
            this.btn_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pause.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Pause.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Pause.Location = new System.Drawing.Point(281, 271);
            this.btn_Pause.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(114, 41);
            this.btn_Pause.TabIndex = 5;
            this.btn_Pause.Text = "Пауза";
            this.btn_Pause.UseVisualStyleBackColor = false;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stop.Enabled = false;
            this.btn_Stop.FlatAppearance.BorderSize = 0;
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stop.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Stop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Stop.Location = new System.Drawing.Point(420, 271);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(114, 41);
            this.btn_Stop.TabIndex = 6;
            this.btn_Stop.Text = "Стоп";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // txt_Line
            // 
            this.txt_Line.Enabled = false;
            this.txt_Line.Location = new System.Drawing.Point(34, 37);
            this.txt_Line.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Line.Name = "txt_Line";
            this.txt_Line.ReadOnly = true;
            this.txt_Line.Size = new System.Drawing.Size(371, 27);
            this.txt_Line.TabIndex = 1;
            this.txt_Line.TextChanged += new System.EventHandler(this.txt_Line_TextChanged);
            // 
            // btn_Scan
            // 
            this.btn_Scan.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Scan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Scan.Enabled = false;
            this.btn_Scan.FlatAppearance.BorderSize = 0;
            this.btn_Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Scan.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Scan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Scan.Location = new System.Drawing.Point(198, 83);
            this.btn_Scan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(154, 47);
            this.btn_Scan.TabIndex = 0;
            this.btn_Scan.Text = "Сканировать";
            this.btn_Scan.UseVisualStyleBackColor = false;
            this.btn_Scan.Click += new System.EventHandler(this.btn_Scan_Click);
            // 
            // btn_Explore
            // 
            this.btn_Explore.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Explore.FlatAppearance.BorderSize = 0;
            this.btn_Explore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Explore.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Explore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Explore.Location = new System.Drawing.Point(78, 83);
            this.btn_Explore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Explore.Name = "btn_Explore";
            this.btn_Explore.Size = new System.Drawing.Size(114, 47);
            this.btn_Explore.TabIndex = 2;
            this.btn_Explore.Text = "Обзор";
            this.btn_Explore.UseVisualStyleBackColor = false;
            this.btn_Explore.Click += new System.EventHandler(this.btn_Explore_Click);
            // 
            // btn_Delete_Viruses
            // 
            this.btn_Delete_Viruses.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Delete_Viruses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete_Viruses.FlatAppearance.BorderSize = 0;
            this.btn_Delete_Viruses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete_Viruses.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete_Viruses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Delete_Viruses.Location = new System.Drawing.Point(468, 300);
            this.btn_Delete_Viruses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete_Viruses.Name = "btn_Delete_Viruses";
            this.btn_Delete_Viruses.Size = new System.Drawing.Size(166, 61);
            this.btn_Delete_Viruses.TabIndex = 11;
            this.btn_Delete_Viruses.Text = "Удалить все вирусы";
            this.btn_Delete_Viruses.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.ForestGreen;
            this.panel4.Controls.Add(this.Journal);
            this.panel4.Location = new System.Drawing.Point(213, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(691, 385);
            this.panel4.TabIndex = 12;
            this.panel4.Visible = false;
            // 
            // Journal
            // 
            this.Journal.Location = new System.Drawing.Point(34, 37);
            this.Journal.Name = "Journal";
            this.Journal.Size = new System.Drawing.Size(617, 312);
            this.Journal.TabIndex = 0;
            this.Journal.UseCompatibleStateImageBehavior = false;
            // 
            // panel_Quar
            // 
            this.panel_Quar.BackColor = System.Drawing.Color.ForestGreen;
            this.panel_Quar.Controls.Add(this.btn_Del_One);
            this.panel_Quar.Controls.Add(this.btn_Recovery);
            this.panel_Quar.Controls.Add(this.Quar_Box);
            this.panel_Quar.Controls.Add(this.btn_Delete_Viruses);
            this.panel_Quar.Location = new System.Drawing.Point(213, 37);
            this.panel_Quar.Name = "panel_Quar";
            this.panel_Quar.Size = new System.Drawing.Size(691, 385);
            this.panel_Quar.TabIndex = 13;
            this.panel_Quar.Visible = false;
            // 
            // btn_Del_One
            // 
            this.btn_Del_One.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Del_One.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Del_One.FlatAppearance.BorderSize = 0;
            this.btn_Del_One.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Del_One.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Del_One.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Del_One.Location = new System.Drawing.Point(229, 310);
            this.btn_Del_One.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Del_One.Name = "btn_Del_One";
            this.btn_Del_One.Size = new System.Drawing.Size(166, 41);
            this.btn_Del_One.TabIndex = 13;
            this.btn_Del_One.Text = "Удалить вирус";
            this.btn_Del_One.UseVisualStyleBackColor = false;
            this.btn_Del_One.Click += new System.EventHandler(this.btn_Del_One_Click);
            // 
            // btn_Recovery
            // 
            this.btn_Recovery.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Recovery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Recovery.FlatAppearance.BorderSize = 0;
            this.btn_Recovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recovery.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Recovery.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Recovery.Location = new System.Drawing.Point(57, 310);
            this.btn_Recovery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Recovery.Name = "btn_Recovery";
            this.btn_Recovery.Size = new System.Drawing.Size(166, 41);
            this.btn_Recovery.TabIndex = 12;
            this.btn_Recovery.Text = "Восстановить";
            this.btn_Recovery.UseVisualStyleBackColor = false;
            this.btn_Recovery.Click += new System.EventHandler(this.btn_Recovery_Click);
            // 
            // Quar_Box
            // 
            this.Quar_Box.FormattingEnabled = true;
            this.Quar_Box.ItemHeight = 20;
            this.Quar_Box.Location = new System.Drawing.Point(34, 37);
            this.Quar_Box.Name = "Quar_Box";
            this.Quar_Box.Size = new System.Drawing.Size(616, 244);
            this.Quar_Box.TabIndex = 0;
            // 
            // Antimalware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 421);
            this.Controls.Add(this.panel_Quar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Scan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Antimalware";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CleanerChan";
            this.Load += new System.EventHandler(this.Antimalware_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_Scan.ResumeLayout(false);
            this.panel_Scan.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel_Quar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button btn_Close;
        private Panel panel2;
        private Button btn_Svor;
        private Button btn_Logs;
        private Button btn_Main;
        private Panel panel3;
        private Label label1;
        private Button btn_Close2;
        private Button btn_Quarantine;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel_Scan;
        private Label label2;
        private Button btn_Play;
        private Button btn_FullScan;
        private ProgressBar progress_Scan;
        private Button btn_Pause;
        private Button btn_Stop;
        private TextBox txt_Line;
        private Button btn_Scan;
        private Button btn_Explore;
        private Button btn_Delete_Viruses;
        private Panel panel4;
        private ListView Journal;
        private Panel panel_Quar;
        private ListBox Quar_Box;
        private Button btn_Del_One;
        private Button btn_Recovery;
    }
}