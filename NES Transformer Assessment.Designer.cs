namespace TransformerAssessment
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderDia = new System.Windows.Forms.FolderBrowserDialog();
            this.panel_Config = new System.Windows.Forms.Panel();
            this.panel_Analyze = new System.Windows.Forms.Panel();
            this.tp_Main = new System.Windows.Forms.TabControl();
            this.tp_Analyze = new System.Windows.Forms.TabPage();
            this.tp_Config = new System.Windows.Forms.TabPage();
            this.tlp_Config_bg = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Config_folderSelect = new System.Windows.Forms.TableLayoutPanel();
            this.b_RefreshTestData = new System.Windows.Forms.Button();
            this.b_RefreshEquipment = new System.Windows.Forms.Button();
            this.button_TestDataFile = new System.Windows.Forms.Button();
            this.button_EquipmentFile = new System.Windows.Forms.Button();
            this.tb_EquipmentFile_BG = new System.Windows.Forms.TextBox();
            this.button_NormsFolder = new System.Windows.Forms.Button();
            this.tb_NormsFolder_BG = new System.Windows.Forms.TextBox();
            this.b_RefreshNorms = new System.Windows.Forms.Button();
            this.tb_TestDataFile_BG = new System.Windows.Forms.TextBox();
            this.tlp_Config_normSelect = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_NormSelect = new System.Windows.Forms.ListBox();
            this.lab_Norms = new System.Windows.Forms.Label();
            this.dg_NormDisplay = new System.Windows.Forms.DataGridView();
            this.tp_Equipment = new System.Windows.Forms.TabPage();
            this.tlp_Equiment_bg = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.l_chooseXFMR = new System.Windows.Forms.Label();
            this.l_chooseXFMREquip = new System.Windows.Forms.Label();
            this.cb_xfmrSelection = new System.Windows.Forms.ComboBox();
            this.cb_xfmrEquipSelect = new System.Windows.Forms.ComboBox();
            this.dgv_EquipDisplay = new System.Windows.Forms.DataGridView();
            this.tp_Data = new System.Windows.Forms.TabPage();
            this.tlp_Data = new System.Windows.Forms.TableLayoutPanel();
            this.l_SelectedEquipment = new System.Windows.Forms.Label();
            this.equipmentSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tlp_Analyze_bg = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel_Config.SuspendLayout();
            this.panel_Analyze.SuspendLayout();
            this.tp_Main.SuspendLayout();
            this.tp_Analyze.SuspendLayout();
            this.tp_Config.SuspendLayout();
            this.tlp_Config_bg.SuspendLayout();
            this.tlp_Config_folderSelect.SuspendLayout();
            this.tlp_Config_normSelect.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_NormDisplay)).BeginInit();
            this.tp_Equipment.SuspendLayout();
            this.tlp_Equiment_bg.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EquipDisplay)).BeginInit();
            this.tp_Data.SuspendLayout();
            this.tlp_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_File
            // 
            this.menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Quit});
            this.menu_File.Name = "menu_File";
            this.menu_File.Size = new System.Drawing.Size(37, 20);
            this.menu_File.Text = "&File";
            // 
            // menu_Quit
            // 
            this.menu_Quit.Name = "menu_Quit";
            this.menu_Quit.Size = new System.Drawing.Size(97, 22);
            this.menu_Quit.Text = "&Quit";
            this.menu_Quit.Click += new System.EventHandler(this.menu_Quit_Click);
            // 
            // openFolderDia
            // 
            this.openFolderDia.ShowNewFolderButton = false;
            // 
            // panel_Config
            // 
            this.panel_Config.Controls.Add(this.panel_Analyze);
            this.panel_Config.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Config.Location = new System.Drawing.Point(0, 24);
            this.panel_Config.Name = "panel_Config";
            this.panel_Config.Size = new System.Drawing.Size(1184, 738);
            this.panel_Config.TabIndex = 3;
            // 
            // panel_Analyze
            // 
            this.panel_Analyze.Controls.Add(this.tp_Main);
            this.panel_Analyze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Analyze.Location = new System.Drawing.Point(0, 0);
            this.panel_Analyze.Name = "panel_Analyze";
            this.panel_Analyze.Size = new System.Drawing.Size(1184, 738);
            this.panel_Analyze.TabIndex = 6;
            // 
            // tp_Main
            // 
            this.tp_Main.Controls.Add(this.tp_Analyze);
            this.tp_Main.Controls.Add(this.tp_Config);
            this.tp_Main.Controls.Add(this.tp_Equipment);
            this.tp_Main.Controls.Add(this.tp_Data);
            this.tp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tp_Main.Location = new System.Drawing.Point(0, 0);
            this.tp_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tp_Main.Name = "tp_Main";
            this.tp_Main.SelectedIndex = 0;
            this.tp_Main.Size = new System.Drawing.Size(1184, 738);
            this.tp_Main.TabIndex = 0;
            // 
            // tp_Analyze
            // 
            this.tp_Analyze.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tp_Analyze.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tp_Analyze.Controls.Add(this.tlp_Analyze_bg);
            this.tp_Analyze.Location = new System.Drawing.Point(4, 22);
            this.tp_Analyze.Margin = new System.Windows.Forms.Padding(0);
            this.tp_Analyze.Name = "tp_Analyze";
            this.tp_Analyze.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Analyze.Size = new System.Drawing.Size(1176, 712);
            this.tp_Analyze.TabIndex = 0;
            this.tp_Analyze.Text = "Analyze";
            // 
            // tp_Config
            // 
            this.tp_Config.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tp_Config.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tp_Config.Controls.Add(this.tlp_Config_bg);
            this.tp_Config.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tp_Config.Location = new System.Drawing.Point(4, 22);
            this.tp_Config.Margin = new System.Windows.Forms.Padding(0);
            this.tp_Config.Name = "tp_Config";
            this.tp_Config.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Config.Size = new System.Drawing.Size(1176, 712);
            this.tp_Config.TabIndex = 1;
            this.tp_Config.Text = "Config";
            // 
            // tlp_Config_bg
            // 
            this.tlp_Config_bg.ColumnCount = 3;
            this.tlp_Config_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Config_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 900F));
            this.tlp_Config_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Config_bg.Controls.Add(this.tlp_Config_folderSelect, 1, 0);
            this.tlp_Config_bg.Controls.Add(this.tlp_Config_normSelect, 1, 1);
            this.tlp_Config_bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Config_bg.Location = new System.Drawing.Point(3, 3);
            this.tlp_Config_bg.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Config_bg.Name = "tlp_Config_bg";
            this.tlp_Config_bg.RowCount = 2;
            this.tlp_Config_bg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tlp_Config_bg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Config_bg.Size = new System.Drawing.Size(1166, 702);
            this.tlp_Config_bg.TabIndex = 12;
            // 
            // tlp_Config_folderSelect
            // 
            this.tlp_Config_folderSelect.ColumnCount = 3;
            this.tlp_Config_folderSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlp_Config_folderSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Config_folderSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlp_Config_folderSelect.Controls.Add(this.b_RefreshTestData, 2, 2);
            this.tlp_Config_folderSelect.Controls.Add(this.b_RefreshEquipment, 2, 1);
            this.tlp_Config_folderSelect.Controls.Add(this.button_TestDataFile, 0, 2);
            this.tlp_Config_folderSelect.Controls.Add(this.button_EquipmentFile, 0, 1);
            this.tlp_Config_folderSelect.Controls.Add(this.tb_EquipmentFile_BG, 1, 1);
            this.tlp_Config_folderSelect.Controls.Add(this.button_NormsFolder, 0, 0);
            this.tlp_Config_folderSelect.Controls.Add(this.tb_NormsFolder_BG, 1, 0);
            this.tlp_Config_folderSelect.Controls.Add(this.b_RefreshNorms, 2, 0);
            this.tlp_Config_folderSelect.Controls.Add(this.tb_TestDataFile_BG, 1, 2);
            this.tlp_Config_folderSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Config_folderSelect.Location = new System.Drawing.Point(133, 0);
            this.tlp_Config_folderSelect.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Config_folderSelect.Name = "tlp_Config_folderSelect";
            this.tlp_Config_folderSelect.RowCount = 3;
            this.tlp_Config_folderSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlp_Config_folderSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlp_Config_folderSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Config_folderSelect.Size = new System.Drawing.Size(900, 89);
            this.tlp_Config_folderSelect.TabIndex = 0;
            // 
            // b_RefreshTestData
            // 
            this.b_RefreshTestData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_RefreshTestData.Location = new System.Drawing.Point(776, 61);
            this.b_RefreshTestData.Name = "b_RefreshTestData";
            this.b_RefreshTestData.Size = new System.Drawing.Size(121, 23);
            this.b_RefreshTestData.TabIndex = 10;
            this.b_RefreshTestData.Text = "Refresh Test Data";
            this.b_RefreshTestData.UseVisualStyleBackColor = true;
            this.b_RefreshTestData.Click += new System.EventHandler(this.b_RefreshTestData_Click);
            // 
            // b_RefreshEquipment
            // 
            this.b_RefreshEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_RefreshEquipment.Location = new System.Drawing.Point(776, 32);
            this.b_RefreshEquipment.Name = "b_RefreshEquipment";
            this.b_RefreshEquipment.Size = new System.Drawing.Size(121, 23);
            this.b_RefreshEquipment.TabIndex = 9;
            this.b_RefreshEquipment.Text = "Refresh Equipment";
            this.b_RefreshEquipment.UseVisualStyleBackColor = true;
            this.b_RefreshEquipment.Click += new System.EventHandler(this.b_RefreshEquipment_Click);
            // 
            // button_TestDataFile
            // 
            this.button_TestDataFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_TestDataFile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_TestDataFile.Location = new System.Drawing.Point(3, 62);
            this.button_TestDataFile.Name = "button_TestDataFile";
            this.button_TestDataFile.Size = new System.Drawing.Size(124, 23);
            this.button_TestDataFile.TabIndex = 6;
            this.button_TestDataFile.Text = "Test Data File";
            this.button_TestDataFile.UseVisualStyleBackColor = true;
            this.button_TestDataFile.Click += new System.EventHandler(this.button_TestDataFile_Click);
            // 
            // button_EquipmentFile
            // 
            this.button_EquipmentFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_EquipmentFile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_EquipmentFile.Location = new System.Drawing.Point(3, 32);
            this.button_EquipmentFile.Name = "button_EquipmentFile";
            this.button_EquipmentFile.Size = new System.Drawing.Size(124, 23);
            this.button_EquipmentFile.TabIndex = 1;
            this.button_EquipmentFile.Text = "Equipment File";
            this.button_EquipmentFile.UseVisualStyleBackColor = true;
            this.button_EquipmentFile.Click += new System.EventHandler(this.button_EquipmentFile_Click);
            // 
            // tb_EquipmentFile_BG
            // 
            this.tb_EquipmentFile_BG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_EquipmentFile_BG.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_EquipmentFile_BG.CausesValidation = false;
            this.tb_EquipmentFile_BG.Enabled = false;
            this.tb_EquipmentFile_BG.Location = new System.Drawing.Point(133, 33);
            this.tb_EquipmentFile_BG.Name = "tb_EquipmentFile_BG";
            this.tb_EquipmentFile_BG.Size = new System.Drawing.Size(634, 20);
            this.tb_EquipmentFile_BG.TabIndex = 5;
            this.tb_EquipmentFile_BG.Text = "Equipment File";
            // 
            // button_NormsFolder
            // 
            this.button_NormsFolder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_NormsFolder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_NormsFolder.Location = new System.Drawing.Point(3, 3);
            this.button_NormsFolder.Name = "button_NormsFolder";
            this.button_NormsFolder.Size = new System.Drawing.Size(124, 23);
            this.button_NormsFolder.TabIndex = 0;
            this.button_NormsFolder.Text = "Norms Folder";
            this.button_NormsFolder.UseVisualStyleBackColor = true;
            this.button_NormsFolder.Click += new System.EventHandler(this.button_NormsFolder_Click);
            // 
            // tb_NormsFolder_BG
            // 
            this.tb_NormsFolder_BG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_NormsFolder_BG.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_NormsFolder_BG.CausesValidation = false;
            this.tb_NormsFolder_BG.Enabled = false;
            this.tb_NormsFolder_BG.Location = new System.Drawing.Point(133, 4);
            this.tb_NormsFolder_BG.Name = "tb_NormsFolder_BG";
            this.tb_NormsFolder_BG.ReadOnly = true;
            this.tb_NormsFolder_BG.Size = new System.Drawing.Size(634, 20);
            this.tb_NormsFolder_BG.TabIndex = 4;
            this.tb_NormsFolder_BG.Text = "Norms Folder";
            // 
            // b_RefreshNorms
            // 
            this.b_RefreshNorms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_RefreshNorms.Location = new System.Drawing.Point(776, 3);
            this.b_RefreshNorms.Name = "b_RefreshNorms";
            this.b_RefreshNorms.Size = new System.Drawing.Size(121, 23);
            this.b_RefreshNorms.TabIndex = 8;
            this.b_RefreshNorms.Text = "Refresh Norms";
            this.b_RefreshNorms.UseVisualStyleBackColor = true;
            this.b_RefreshNorms.Click += new System.EventHandler(this.b_RefreshNorms_Click);
            // 
            // tb_TestDataFile_BG
            // 
            this.tb_TestDataFile_BG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_TestDataFile_BG.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_TestDataFile_BG.CausesValidation = false;
            this.tb_TestDataFile_BG.Enabled = false;
            this.tb_TestDataFile_BG.Location = new System.Drawing.Point(133, 63);
            this.tb_TestDataFile_BG.Name = "tb_TestDataFile_BG";
            this.tb_TestDataFile_BG.Size = new System.Drawing.Size(634, 20);
            this.tb_TestDataFile_BG.TabIndex = 7;
            this.tb_TestDataFile_BG.Text = "Test Data File";
            // 
            // tlp_Config_normSelect
            // 
            this.tlp_Config_normSelect.ColumnCount = 2;
            this.tlp_Config_normSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tlp_Config_normSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Config_normSelect.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlp_Config_normSelect.Controls.Add(this.dg_NormDisplay, 1, 0);
            this.tlp_Config_normSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Config_normSelect.Location = new System.Drawing.Point(133, 89);
            this.tlp_Config_normSelect.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Config_normSelect.Name = "tlp_Config_normSelect";
            this.tlp_Config_normSelect.RowCount = 1;
            this.tlp_Config_normSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Config_normSelect.Size = new System.Drawing.Size(900, 613);
            this.tlp_Config_normSelect.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lb_NormSelect, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lab_Norms, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(198, 613);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lb_NormSelect
            // 
            this.lb_NormSelect.FormattingEnabled = true;
            this.lb_NormSelect.Location = new System.Drawing.Point(3, 22);
            this.lb_NormSelect.Name = "lb_NormSelect";
            this.lb_NormSelect.Size = new System.Drawing.Size(192, 186);
            this.lb_NormSelect.TabIndex = 9;
            this.lb_NormSelect.SelectedIndexChanged += new System.EventHandler(this.lb_NormSelect_SelectedIndexChanged);
            // 
            // lab_Norms
            // 
            this.lab_Norms.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_Norms.AutoSize = true;
            this.lab_Norms.Location = new System.Drawing.Point(3, 3);
            this.lab_Norms.Name = "lab_Norms";
            this.lab_Norms.Size = new System.Drawing.Size(127, 13);
            this.lab_Norms.TabIndex = 8;
            this.lab_Norms.Text = "Norms Currently Compiled";
            // 
            // dg_NormDisplay
            // 
            this.dg_NormDisplay.AllowUserToAddRows = false;
            this.dg_NormDisplay.AllowUserToDeleteRows = false;
            this.dg_NormDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_NormDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_NormDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_NormDisplay.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_NormDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_NormDisplay.Location = new System.Drawing.Point(201, 0);
            this.dg_NormDisplay.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.dg_NormDisplay.Name = "dg_NormDisplay";
            this.dg_NormDisplay.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_NormDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_NormDisplay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_NormDisplay.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_NormDisplay.Size = new System.Drawing.Size(696, 610);
            this.dg_NormDisplay.TabIndex = 11;
            // 
            // tp_Equipment
            // 
            this.tp_Equipment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tp_Equipment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tp_Equipment.Controls.Add(this.tlp_Equiment_bg);
            this.tp_Equipment.Location = new System.Drawing.Point(4, 22);
            this.tp_Equipment.Name = "tp_Equipment";
            this.tp_Equipment.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Equipment.Size = new System.Drawing.Size(1176, 712);
            this.tp_Equipment.TabIndex = 2;
            this.tp_Equipment.Text = "Equipment";
            // 
            // tlp_Equiment_bg
            // 
            this.tlp_Equiment_bg.ColumnCount = 3;
            this.tlp_Equiment_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Equiment_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 900F));
            this.tlp_Equiment_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Equiment_bg.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tlp_Equiment_bg.Controls.Add(this.dgv_EquipDisplay, 1, 1);
            this.tlp_Equiment_bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Equiment_bg.Location = new System.Drawing.Point(3, 3);
            this.tlp_Equiment_bg.Name = "tlp_Equiment_bg";
            this.tlp_Equiment_bg.RowCount = 2;
            this.tlp_Equiment_bg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tlp_Equiment_bg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Equiment_bg.Size = new System.Drawing.Size(1166, 702);
            this.tlp_Equiment_bg.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.l_chooseXFMR, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.l_chooseXFMREquip, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cb_xfmrSelection, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cb_xfmrEquipSelect, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(133, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.61404F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.38596F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(900, 57);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // l_chooseXFMR
            // 
            this.l_chooseXFMR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.l_chooseXFMR.AutoSize = true;
            this.l_chooseXFMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_chooseXFMR.Location = new System.Drawing.Point(67, 6);
            this.l_chooseXFMR.Name = "l_chooseXFMR";
            this.l_chooseXFMR.Size = new System.Drawing.Size(78, 13);
            this.l_chooseXFMR.TabIndex = 0;
            this.l_chooseXFMR.Text = "Transformer:";
            // 
            // l_chooseXFMREquip
            // 
            this.l_chooseXFMREquip.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.l_chooseXFMREquip.AutoSize = true;
            this.l_chooseXFMREquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_chooseXFMREquip.Location = new System.Drawing.Point(4, 35);
            this.l_chooseXFMREquip.Name = "l_chooseXFMREquip";
            this.l_chooseXFMREquip.Size = new System.Drawing.Size(141, 13);
            this.l_chooseXFMREquip.TabIndex = 1;
            this.l_chooseXFMREquip.Text = "Transformer Equipment:";
            // 
            // cb_xfmrSelection
            // 
            this.cb_xfmrSelection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_xfmrSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_xfmrSelection.FormattingEnabled = true;
            this.cb_xfmrSelection.Location = new System.Drawing.Point(151, 3);
            this.cb_xfmrSelection.Name = "cb_xfmrSelection";
            this.cb_xfmrSelection.Size = new System.Drawing.Size(246, 21);
            this.cb_xfmrSelection.TabIndex = 2;
            this.cb_xfmrSelection.SelectionChangeCommitted += new System.EventHandler(this.cb_xfmrSelection_SelectedIndexChanged);
            // 
            // cb_xfmrEquipSelect
            // 
            this.cb_xfmrEquipSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_xfmrEquipSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_xfmrEquipSelect.FormattingEnabled = true;
            this.cb_xfmrEquipSelect.Location = new System.Drawing.Point(151, 31);
            this.cb_xfmrEquipSelect.Name = "cb_xfmrEquipSelect";
            this.cb_xfmrEquipSelect.Size = new System.Drawing.Size(246, 21);
            this.cb_xfmrEquipSelect.TabIndex = 3;
            this.cb_xfmrEquipSelect.SelectionChangeCommitted += new System.EventHandler(this.cb_xfmrEquipSelect_SelectedIndexChanged);
            // 
            // dgv_EquipDisplay
            // 
            this.dgv_EquipDisplay.AllowUserToAddRows = false;
            this.dgv_EquipDisplay.AllowUserToDeleteRows = false;
            this.dgv_EquipDisplay.AllowUserToResizeRows = false;
            this.dgv_EquipDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_EquipDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_EquipDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_EquipDisplay.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_EquipDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_EquipDisplay.Location = new System.Drawing.Point(136, 60);
            this.dgv_EquipDisplay.Name = "dgv_EquipDisplay";
            this.dgv_EquipDisplay.RowHeadersVisible = false;
            this.dgv_EquipDisplay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_EquipDisplay.Size = new System.Drawing.Size(894, 639);
            this.dgv_EquipDisplay.TabIndex = 1;
            // 
            // tp_Data
            // 
            this.tp_Data.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tp_Data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tp_Data.Controls.Add(this.tlp_Data);
            this.tp_Data.Location = new System.Drawing.Point(4, 22);
            this.tp_Data.Name = "tp_Data";
            this.tp_Data.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Data.Size = new System.Drawing.Size(1176, 712);
            this.tp_Data.TabIndex = 3;
            this.tp_Data.Text = "Data";
            // 
            // tlp_Data
            // 
            this.tlp_Data.ColumnCount = 3;
            this.tlp_Data.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Data.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 900F));
            this.tlp_Data.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Data.Controls.Add(this.l_SelectedEquipment, 1, 0);
            this.tlp_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Data.Location = new System.Drawing.Point(3, 3);
            this.tlp_Data.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Data.Name = "tlp_Data";
            this.tlp_Data.RowCount = 2;
            this.tlp_Data.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tlp_Data.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Data.Size = new System.Drawing.Size(1166, 702);
            this.tlp_Data.TabIndex = 0;
            // 
            // l_SelectedEquipment
            // 
            this.l_SelectedEquipment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.l_SelectedEquipment.AutoSize = true;
            this.l_SelectedEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_SelectedEquipment.Location = new System.Drawing.Point(523, 6);
            this.l_SelectedEquipment.Name = "l_SelectedEquipment";
            this.l_SelectedEquipment.Size = new System.Drawing.Size(120, 13);
            this.l_SelectedEquipment.TabIndex = 1;
            this.l_SelectedEquipment.Text = "Selected Equipment";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.InitialDirectory = "Application.StartupPath";
            // 
            // tlp_Analyze_bg
            // 
            this.tlp_Analyze_bg.ColumnCount = 3;
            this.tlp_Analyze_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Analyze_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 900F));
            this.tlp_Analyze_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Analyze_bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Analyze_bg.Location = new System.Drawing.Point(3, 3);
            this.tlp_Analyze_bg.Name = "tlp_Analyze_bg";
            this.tlp_Analyze_bg.RowCount = 2;
            this.tlp_Analyze_bg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Analyze_bg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Analyze_bg.Size = new System.Drawing.Size(1166, 702);
            this.tlp_Analyze_bg.TabIndex = 0;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.panel_Config);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormHome";
            this.ShowIcon = false;
            this.Text = "NES Transformer Assessment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Config.ResumeLayout(false);
            this.panel_Analyze.ResumeLayout(false);
            this.tp_Main.ResumeLayout(false);
            this.tp_Analyze.ResumeLayout(false);
            this.tp_Config.ResumeLayout(false);
            this.tlp_Config_bg.ResumeLayout(false);
            this.tlp_Config_folderSelect.ResumeLayout(false);
            this.tlp_Config_folderSelect.PerformLayout();
            this.tlp_Config_normSelect.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_NormDisplay)).EndInit();
            this.tp_Equipment.ResumeLayout(false);
            this.tlp_Equiment_bg.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EquipDisplay)).EndInit();
            this.tp_Data.ResumeLayout(false);
            this.tlp_Data.ResumeLayout(false);
            this.tlp_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_File;
        private System.Windows.Forms.ToolStripMenuItem menu_Quit;
        private System.Windows.Forms.Panel panel_Config;
        public System.Windows.Forms.FolderBrowserDialog openFolderDia;
        private System.Windows.Forms.Panel panel_Analyze;
        private System.Windows.Forms.BindingSource equipmentSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tp_Main;
        private System.Windows.Forms.TabPage tp_Analyze;
        private System.Windows.Forms.TabPage tp_Config;
        private System.Windows.Forms.TableLayoutPanel tlp_Config_bg;
        private System.Windows.Forms.TableLayoutPanel tlp_Config_folderSelect;
        private System.Windows.Forms.Button button_TestDataFile;
        private System.Windows.Forms.Button button_EquipmentFile;
        private System.Windows.Forms.TextBox tb_EquipmentFile_BG;
        private System.Windows.Forms.Button button_NormsFolder;
        private System.Windows.Forms.TextBox tb_NormsFolder_BG;
        private System.Windows.Forms.TextBox tb_TestDataFile_BG;
        private System.Windows.Forms.TableLayoutPanel tlp_Config_normSelect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lb_NormSelect;
        private System.Windows.Forms.Label lab_Norms;
        private System.Windows.Forms.DataGridView dg_NormDisplay;
        private System.Windows.Forms.TabPage tp_Equipment;
        private System.Windows.Forms.TableLayoutPanel tlp_Equiment_bg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label l_chooseXFMR;
        private System.Windows.Forms.Label l_chooseXFMREquip;
        private System.Windows.Forms.ComboBox cb_xfmrSelection;
        private System.Windows.Forms.ComboBox cb_xfmrEquipSelect;
        private System.Windows.Forms.DataGridView dgv_EquipDisplay;
        private System.Windows.Forms.TabPage tp_Data;
        private System.Windows.Forms.TableLayoutPanel tlp_Data;
        private System.Windows.Forms.Label l_SelectedEquipment;
        private System.Windows.Forms.Button b_RefreshNorms;
        private System.Windows.Forms.Button b_RefreshTestData;
        private System.Windows.Forms.Button b_RefreshEquipment;
        private System.Windows.Forms.TableLayoutPanel tlp_Analyze_bg;

    }
}

