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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderDia = new System.Windows.Forms.FolderBrowserDialog();
            this.panel_Config = new System.Windows.Forms.Panel();
            this.panel_Analyze = new System.Windows.Forms.Panel();
            this.tp_Main = new System.Windows.Forms.TabControl();
            this.tp_Analyze = new System.Windows.Forms.TabPage();
            this.tlp_Analyze_bg = new System.Windows.Forms.TableLayoutPanel();
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
            this.tp_EquipmentSelect_bg = new System.Windows.Forms.TabPage();
            this.tlp_Equiment_bg = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_XfmrEquipSelect = new System.Windows.Forms.TableLayoutPanel();
            this.l_chooseXFMR = new System.Windows.Forms.Label();
            this.l_chooseXFMREquip = new System.Windows.Forms.Label();
            this.cb_xfmrSelection = new System.Windows.Forms.ComboBox();
            this.cb_xfmrEquipSelect = new System.Windows.Forms.ComboBox();
            this.dgv_EquipDisplay = new System.Windows.Forms.DataGridView();
            this.tp_TOA = new System.Windows.Forms.TabPage();
            this.tlp_Data = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.l_SelectedEquipment = new System.Windows.Forms.Label();
            this.panel_TOA_center = new System.Windows.Forms.Panel();
            this.tlp_Data_centerColumn = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_TOA_Moisture = new System.Windows.Forms.TableLayoutPanel();
            this.l_moist_date = new System.Windows.Forms.Label();
            this.l_moist_temp = new System.Windows.Forms.Label();
            this.l_moist_moisture = new System.Windows.Forms.Label();
            this.l_moist_relSat = new System.Windows.Forms.Label();
            this.tlp_TOA_FluidQuality = new System.Windows.Forms.TableLayoutPanel();
            this.l_fq_date = new System.Windows.Forms.Label();
            this.l_fq_temp = new System.Windows.Forms.Label();
            this.l_fq_d1826 = new System.Windows.Forms.Label();
            this.l_fq_acidNum = new System.Windows.Forms.Label();
            this.l_fq_ift = new System.Windows.Forms.Label();
            this.l_fq_spGrav = new System.Windows.Forms.Label();
            this.l_fq_color = new System.Windows.Forms.Label();
            this.l_fq_visual = new System.Windows.Forms.Label();
            this.l_fq_moisture = new System.Windows.Forms.Label();
            this.tlp_TOA_gasAnalysis = new System.Windows.Forms.TableLayoutPanel();
            this.l_gas_sampleDate = new System.Windows.Forms.Label();
            this.l_gas_fluidTemp = new System.Windows.Forms.Label();
            this.l_gas_h2 = new System.Windows.Forms.Label();
            this.l_gas_ch4 = new System.Windows.Forms.Label();
            this.l_gas_c2h6 = new System.Windows.Forms.Label();
            this.l_gas_c2h4 = new System.Windows.Forms.Label();
            this.l_gas_c2h2 = new System.Windows.Forms.Label();
            this.l_gas_co = new System.Windows.Forms.Label();
            this.l_gas_co2 = new System.Windows.Forms.Label();
            this.l_gas_o2 = new System.Windows.Forms.Label();
            this.l_gas_n2 = new System.Windows.Forms.Label();
            this.l_gas_o2_n2 = new System.Windows.Forms.Label();
            this.l_TOA_header = new System.Windows.Forms.Label();
            this.l_GasAnalysis = new System.Windows.Forms.Label();
            this.l_FluidQuality = new System.Windows.Forms.Label();
            this.l_Moisture = new System.Windows.Forms.Label();
            this.tlp_TOA_fluidAnalysisReport = new System.Windows.Forms.TableLayoutPanel();
            this.l_remarks = new System.Windows.Forms.Label();
            this.l_opsCount = new System.Windows.Forms.Label();
            this.l_oilPresType = new System.Windows.Forms.Label();
            this.l_model = new System.Windows.Forms.Label();
            this.l_yearMfg = new System.Windows.Forms.Label();
            this.l_mfr = new System.Windows.Forms.Label();
            this.l_norm = new System.Windows.Forms.Label();
            this.l_serialNum = new System.Windows.Forms.Label();
            this.l_equipNum = new System.Windows.Forms.Label();
            this.l_FAR_equipmentNum = new System.Windows.Forms.Label();
            this.l_FAR_serialNum = new System.Windows.Forms.Label();
            this.l_FAR_normUsed = new System.Windows.Forms.Label();
            this.l_FAR_manufacturer = new System.Windows.Forms.Label();
            this.l_FAR_yrManufactured = new System.Windows.Forms.Label();
            this.l_FAR_model = new System.Windows.Forms.Label();
            this.l_FAR_oilPresType = new System.Windows.Forms.Label();
            this.l_FAR_opsCount = new System.Windows.Forms.Label();
            this.l_FAR_equipmentRemarks = new System.Windows.Forms.Label();
            this.equipmentSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tp_coefficients = new System.Windows.Forms.TabPage();
            this.tlp_Coeff_bg = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Coeff_center = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Analyze_center = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel_Config.SuspendLayout();
            this.panel_Analyze.SuspendLayout();
            this.tp_Main.SuspendLayout();
            this.tp_Analyze.SuspendLayout();
            this.tlp_Analyze_bg.SuspendLayout();
            this.tp_Config.SuspendLayout();
            this.tlp_Config_bg.SuspendLayout();
            this.tlp_Config_folderSelect.SuspendLayout();
            this.tlp_Config_normSelect.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_NormDisplay)).BeginInit();
            this.tp_EquipmentSelect_bg.SuspendLayout();
            this.tlp_Equiment_bg.SuspendLayout();
            this.tlp_XfmrEquipSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EquipDisplay)).BeginInit();
            this.tp_TOA.SuspendLayout();
            this.tlp_Data.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_TOA_center.SuspendLayout();
            this.tlp_Data_centerColumn.SuspendLayout();
            this.tlp_TOA_Moisture.SuspendLayout();
            this.tlp_TOA_FluidQuality.SuspendLayout();
            this.tlp_TOA_gasAnalysis.SuspendLayout();
            this.tlp_TOA_fluidAnalysisReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentSource)).BeginInit();
            this.tp_coefficients.SuspendLayout();
            this.tlp_Coeff_bg.SuspendLayout();
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
            this.tp_Main.Controls.Add(this.tp_EquipmentSelect_bg);
            this.tp_Main.Controls.Add(this.tp_TOA);
            this.tp_Main.Controls.Add(this.tp_coefficients);
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
            this.tp_Analyze.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tp_Analyze.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tp_Analyze.Controls.Add(this.tlp_Analyze_bg);
            this.tp_Analyze.Location = new System.Drawing.Point(4, 22);
            this.tp_Analyze.Margin = new System.Windows.Forms.Padding(0);
            this.tp_Analyze.Name = "tp_Analyze";
            this.tp_Analyze.Size = new System.Drawing.Size(1176, 712);
            this.tp_Analyze.TabIndex = 0;
            this.tp_Analyze.Text = "Analyze";
            // 
            // tlp_Analyze_bg
            // 
            this.tlp_Analyze_bg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tlp_Analyze_bg.ColumnCount = 3;
            this.tlp_Analyze_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Analyze_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 900F));
            this.tlp_Analyze_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Analyze_bg.Controls.Add(this.tlp_Analyze_center, 1, 0);
            this.tlp_Analyze_bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Analyze_bg.Location = new System.Drawing.Point(0, 0);
            this.tlp_Analyze_bg.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Analyze_bg.Name = "tlp_Analyze_bg";
            this.tlp_Analyze_bg.RowCount = 1;
            this.tlp_Analyze_bg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Analyze_bg.Size = new System.Drawing.Size(1172, 708);
            this.tlp_Analyze_bg.TabIndex = 0;
            // 
            // tp_Config
            // 
            this.tp_Config.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tp_Config.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tp_Config.Controls.Add(this.tlp_Config_bg);
            this.tp_Config.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tp_Config.Location = new System.Drawing.Point(4, 22);
            this.tp_Config.Margin = new System.Windows.Forms.Padding(0);
            this.tp_Config.Name = "tp_Config";
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
            this.tlp_Config_bg.Location = new System.Drawing.Point(0, 0);
            this.tlp_Config_bg.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Config_bg.Name = "tlp_Config_bg";
            this.tlp_Config_bg.RowCount = 2;
            this.tlp_Config_bg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tlp_Config_bg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Config_bg.Size = new System.Drawing.Size(1172, 708);
            this.tlp_Config_bg.TabIndex = 12;
            // 
            // tlp_Config_folderSelect
            // 
            this.tlp_Config_folderSelect.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.tlp_Config_folderSelect.Location = new System.Drawing.Point(136, 0);
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
            this.tlp_Config_normSelect.Location = new System.Drawing.Point(136, 89);
            this.tlp_Config_normSelect.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Config_normSelect.Name = "tlp_Config_normSelect";
            this.tlp_Config_normSelect.RowCount = 1;
            this.tlp_Config_normSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Config_normSelect.Size = new System.Drawing.Size(900, 619);
            this.tlp_Config_normSelect.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(198, 619);
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
            this.lab_Norms.Size = new System.Drawing.Size(130, 13);
            this.lab_Norms.TabIndex = 8;
            this.lab_Norms.Text = "Norms Currently Compiled:";
            // 
            // dg_NormDisplay
            // 
            this.dg_NormDisplay.AllowUserToAddRows = false;
            this.dg_NormDisplay.AllowUserToDeleteRows = false;
            this.dg_NormDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dg_NormDisplay.BackgroundColor = System.Drawing.SystemColors.ControlLight;
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
            this.dg_NormDisplay.Location = new System.Drawing.Point(198, 0);
            this.dg_NormDisplay.Margin = new System.Windows.Forms.Padding(0);
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
            this.dg_NormDisplay.Size = new System.Drawing.Size(702, 619);
            this.dg_NormDisplay.TabIndex = 11;
            // 
            // tp_EquipmentSelect_bg
            // 
            this.tp_EquipmentSelect_bg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tp_EquipmentSelect_bg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tp_EquipmentSelect_bg.Controls.Add(this.tlp_Equiment_bg);
            this.tp_EquipmentSelect_bg.Location = new System.Drawing.Point(4, 22);
            this.tp_EquipmentSelect_bg.Margin = new System.Windows.Forms.Padding(0);
            this.tp_EquipmentSelect_bg.Name = "tp_EquipmentSelect_bg";
            this.tp_EquipmentSelect_bg.Size = new System.Drawing.Size(1176, 712);
            this.tp_EquipmentSelect_bg.TabIndex = 2;
            this.tp_EquipmentSelect_bg.Text = "Equipment Select";
            // 
            // tlp_Equiment_bg
            // 
            this.tlp_Equiment_bg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tlp_Equiment_bg.ColumnCount = 3;
            this.tlp_Equiment_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Equiment_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 900F));
            this.tlp_Equiment_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Equiment_bg.Controls.Add(this.tlp_XfmrEquipSelect, 1, 0);
            this.tlp_Equiment_bg.Controls.Add(this.dgv_EquipDisplay, 1, 1);
            this.tlp_Equiment_bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Equiment_bg.Location = new System.Drawing.Point(0, 0);
            this.tlp_Equiment_bg.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Equiment_bg.Name = "tlp_Equiment_bg";
            this.tlp_Equiment_bg.RowCount = 2;
            this.tlp_Equiment_bg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tlp_Equiment_bg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Equiment_bg.Size = new System.Drawing.Size(1172, 708);
            this.tlp_Equiment_bg.TabIndex = 0;
            // 
            // tlp_XfmrEquipSelect
            // 
            this.tlp_XfmrEquipSelect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlp_XfmrEquipSelect.ColumnCount = 3;
            this.tlp_XfmrEquipSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tlp_XfmrEquipSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.tlp_XfmrEquipSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_XfmrEquipSelect.Controls.Add(this.l_chooseXFMR, 0, 0);
            this.tlp_XfmrEquipSelect.Controls.Add(this.l_chooseXFMREquip, 0, 1);
            this.tlp_XfmrEquipSelect.Controls.Add(this.cb_xfmrSelection, 1, 0);
            this.tlp_XfmrEquipSelect.Controls.Add(this.cb_xfmrEquipSelect, 1, 1);
            this.tlp_XfmrEquipSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_XfmrEquipSelect.Location = new System.Drawing.Point(136, 0);
            this.tlp_XfmrEquipSelect.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_XfmrEquipSelect.Name = "tlp_XfmrEquipSelect";
            this.tlp_XfmrEquipSelect.RowCount = 2;
            this.tlp_XfmrEquipSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.61404F));
            this.tlp_XfmrEquipSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.38596F));
            this.tlp_XfmrEquipSelect.Size = new System.Drawing.Size(900, 57);
            this.tlp_XfmrEquipSelect.TabIndex = 0;
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
            this.cb_xfmrSelection.BackColor = System.Drawing.SystemColors.ScrollBar;
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
            this.dgv_EquipDisplay.BackgroundColor = System.Drawing.SystemColors.ControlLight;
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
            this.dgv_EquipDisplay.Location = new System.Drawing.Point(136, 57);
            this.dgv_EquipDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_EquipDisplay.Name = "dgv_EquipDisplay";
            this.dgv_EquipDisplay.RowHeadersVisible = false;
            this.dgv_EquipDisplay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_EquipDisplay.Size = new System.Drawing.Size(900, 651);
            this.dgv_EquipDisplay.TabIndex = 1;
            // 
            // tp_TOA
            // 
            this.tp_TOA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tp_TOA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tp_TOA.Controls.Add(this.tlp_Data);
            this.tp_TOA.Location = new System.Drawing.Point(4, 22);
            this.tp_TOA.Margin = new System.Windows.Forms.Padding(0);
            this.tp_TOA.Name = "tp_TOA";
            this.tp_TOA.Size = new System.Drawing.Size(1176, 712);
            this.tp_TOA.TabIndex = 3;
            this.tp_TOA.Text = "TOA";
            // 
            // tlp_Data
            // 
            this.tlp_Data.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tlp_Data.ColumnCount = 3;
            this.tlp_Data.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Data.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 900F));
            this.tlp_Data.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Data.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tlp_Data.Controls.Add(this.panel_TOA_center, 1, 1);
            this.tlp_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Data.Location = new System.Drawing.Point(0, 0);
            this.tlp_Data.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Data.Name = "tlp_Data";
            this.tlp_Data.RowCount = 2;
            this.tlp_Data.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlp_Data.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Data.Size = new System.Drawing.Size(1172, 708);
            this.tlp_Data.TabIndex = 0;
            this.tlp_Data.MouseEnter += new System.EventHandler(this.tlp_Data_MouseEnter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.l_SelectedEquipment, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(136, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(900, 31);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // l_SelectedEquipment
            // 
            this.l_SelectedEquipment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.l_SelectedEquipment.AutoSize = true;
            this.l_SelectedEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_SelectedEquipment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.l_SelectedEquipment.Location = new System.Drawing.Point(350, 7);
            this.l_SelectedEquipment.Name = "l_SelectedEquipment";
            this.l_SelectedEquipment.Size = new System.Drawing.Size(199, 24);
            this.l_SelectedEquipment.TabIndex = 1;
            this.l_SelectedEquipment.Text = "Selected Equipment";
            // 
            // panel_TOA_center
            // 
            this.panel_TOA_center.AutoScroll = true;
            this.panel_TOA_center.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_TOA_center.Controls.Add(this.tlp_Data_centerColumn);
            this.panel_TOA_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_TOA_center.Location = new System.Drawing.Point(136, 31);
            this.panel_TOA_center.Margin = new System.Windows.Forms.Padding(0);
            this.panel_TOA_center.Name = "panel_TOA_center";
            this.panel_TOA_center.Size = new System.Drawing.Size(900, 677);
            this.panel_TOA_center.TabIndex = 4;
            // 
            // tlp_Data_centerColumn
            // 
            this.tlp_Data_centerColumn.AutoSize = true;
            this.tlp_Data_centerColumn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_Data_centerColumn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlp_Data_centerColumn.ColumnCount = 3;
            this.tlp_Data_centerColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Data_centerColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
            this.tlp_Data_centerColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Data_centerColumn.Controls.Add(this.tlp_TOA_Moisture, 1, 7);
            this.tlp_Data_centerColumn.Controls.Add(this.tlp_TOA_FluidQuality, 1, 5);
            this.tlp_Data_centerColumn.Controls.Add(this.tlp_TOA_gasAnalysis, 1, 3);
            this.tlp_Data_centerColumn.Controls.Add(this.l_TOA_header, 1, 0);
            this.tlp_Data_centerColumn.Controls.Add(this.l_GasAnalysis, 1, 2);
            this.tlp_Data_centerColumn.Controls.Add(this.l_FluidQuality, 1, 4);
            this.tlp_Data_centerColumn.Controls.Add(this.l_Moisture, 1, 6);
            this.tlp_Data_centerColumn.Controls.Add(this.tlp_TOA_fluidAnalysisReport, 1, 1);
            this.tlp_Data_centerColumn.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_Data_centerColumn.Location = new System.Drawing.Point(0, 0);
            this.tlp_Data_centerColumn.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Data_centerColumn.Name = "tlp_Data_centerColumn";
            this.tlp_Data_centerColumn.RowCount = 9;
            this.tlp_Data_centerColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Data_centerColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_Data_centerColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Data_centerColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.tlp_Data_centerColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Data_centerColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_Data_centerColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Data_centerColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_Data_centerColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Data_centerColumn.Size = new System.Drawing.Size(883, 983);
            this.tlp_Data_centerColumn.TabIndex = 2;
            this.tlp_Data_centerColumn.MouseEnter += new System.EventHandler(this.tlp_Data_MouseEnter);
            // 
            // tlp_TOA_Moisture
            // 
            this.tlp_TOA_Moisture.AutoSize = true;
            this.tlp_TOA_Moisture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_TOA_Moisture.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_TOA_Moisture.ColumnCount = 6;
            this.tlp_TOA_Moisture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_TOA_Moisture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_TOA_Moisture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_TOA_Moisture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_TOA_Moisture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_TOA_Moisture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_TOA_Moisture.Controls.Add(this.l_moist_date, 0, 0);
            this.tlp_TOA_Moisture.Controls.Add(this.l_moist_temp, 0, 1);
            this.tlp_TOA_Moisture.Controls.Add(this.l_moist_moisture, 0, 2);
            this.tlp_TOA_Moisture.Controls.Add(this.l_moist_relSat, 0, 3);
            this.tlp_TOA_Moisture.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlp_TOA_Moisture.Location = new System.Drawing.Point(51, 786);
            this.tlp_TOA_Moisture.Margin = new System.Windows.Forms.Padding(10, 3, 0, 0);
            this.tlp_TOA_Moisture.Name = "tlp_TOA_Moisture";
            this.tlp_TOA_Moisture.RowCount = 4;
            this.tlp_TOA_Moisture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_Moisture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_Moisture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_Moisture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_Moisture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_Moisture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_Moisture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_Moisture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_Moisture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_Moisture.Size = new System.Drawing.Size(207, 85);
            this.tlp_TOA_Moisture.TabIndex = 7;
            // 
            // l_moist_date
            // 
            this.l_moist_date.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_moist_date.AutoSize = true;
            this.l_moist_date.Location = new System.Drawing.Point(4, 4);
            this.l_moist_date.Name = "l_moist_date";
            this.l_moist_date.Size = new System.Drawing.Size(71, 13);
            this.l_moist_date.TabIndex = 0;
            this.l_moist_date.Text = "Sample Date:";
            // 
            // l_moist_temp
            // 
            this.l_moist_temp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_moist_temp.AutoSize = true;
            this.l_moist_temp.Location = new System.Drawing.Point(4, 25);
            this.l_moist_temp.Name = "l_moist_temp";
            this.l_moist_temp.Size = new System.Drawing.Size(95, 13);
            this.l_moist_temp.TabIndex = 1;
            this.l_moist_temp.Text = "Fluid Temperature:";
            this.l_moist_temp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // l_moist_moisture
            // 
            this.l_moist_moisture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_moist_moisture.AutoSize = true;
            this.l_moist_moisture.Location = new System.Drawing.Point(4, 46);
            this.l_moist_moisture.Name = "l_moist_moisture";
            this.l_moist_moisture.Size = new System.Drawing.Size(50, 13);
            this.l_moist_moisture.TabIndex = 2;
            this.l_moist_moisture.Text = "Moisture:";
            // 
            // l_moist_relSat
            // 
            this.l_moist_relSat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_moist_relSat.AutoSize = true;
            this.l_moist_relSat.Location = new System.Drawing.Point(4, 67);
            this.l_moist_relSat.Name = "l_moist_relSat";
            this.l_moist_relSat.Size = new System.Drawing.Size(100, 13);
            this.l_moist_relSat.TabIndex = 3;
            this.l_moist_relSat.Text = "Relative Saturation:";
            // 
            // tlp_TOA_FluidQuality
            // 
            this.tlp_TOA_FluidQuality.AutoSize = true;
            this.tlp_TOA_FluidQuality.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_TOA_FluidQuality.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_TOA_FluidQuality.ColumnCount = 6;
            this.tlp_TOA_FluidQuality.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_TOA_FluidQuality.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_TOA_FluidQuality.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_TOA_FluidQuality.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_TOA_FluidQuality.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_TOA_FluidQuality.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_TOA_FluidQuality.Controls.Add(this.l_fq_date, 0, 0);
            this.tlp_TOA_FluidQuality.Controls.Add(this.l_fq_temp, 0, 1);
            this.tlp_TOA_FluidQuality.Controls.Add(this.l_fq_d1826, 0, 2);
            this.tlp_TOA_FluidQuality.Controls.Add(this.l_fq_acidNum, 0, 3);
            this.tlp_TOA_FluidQuality.Controls.Add(this.l_fq_ift, 0, 4);
            this.tlp_TOA_FluidQuality.Controls.Add(this.l_fq_spGrav, 0, 5);
            this.tlp_TOA_FluidQuality.Controls.Add(this.l_fq_color, 0, 6);
            this.tlp_TOA_FluidQuality.Controls.Add(this.l_fq_visual, 0, 7);
            this.tlp_TOA_FluidQuality.Controls.Add(this.l_fq_moisture, 0, 8);
            this.tlp_TOA_FluidQuality.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlp_TOA_FluidQuality.Location = new System.Drawing.Point(51, 556);
            this.tlp_TOA_FluidQuality.Margin = new System.Windows.Forms.Padding(10, 3, 0, 0);
            this.tlp_TOA_FluidQuality.Name = "tlp_TOA_FluidQuality";
            this.tlp_TOA_FluidQuality.RowCount = 9;
            this.tlp_TOA_FluidQuality.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_FluidQuality.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_FluidQuality.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_FluidQuality.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_FluidQuality.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_FluidQuality.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_FluidQuality.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_FluidQuality.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_FluidQuality.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_FluidQuality.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_FluidQuality.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_FluidQuality.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_FluidQuality.Size = new System.Drawing.Size(207, 190);
            this.tlp_TOA_FluidQuality.TabIndex = 6;
            // 
            // l_fq_date
            // 
            this.l_fq_date.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_fq_date.AutoSize = true;
            this.l_fq_date.Location = new System.Drawing.Point(4, 4);
            this.l_fq_date.Name = "l_fq_date";
            this.l_fq_date.Size = new System.Drawing.Size(71, 13);
            this.l_fq_date.TabIndex = 0;
            this.l_fq_date.Text = "Sample Date:";
            // 
            // l_fq_temp
            // 
            this.l_fq_temp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_fq_temp.AutoSize = true;
            this.l_fq_temp.Location = new System.Drawing.Point(4, 25);
            this.l_fq_temp.Name = "l_fq_temp";
            this.l_fq_temp.Size = new System.Drawing.Size(95, 13);
            this.l_fq_temp.TabIndex = 1;
            this.l_fq_temp.Text = "Fluid Temperature:";
            this.l_fq_temp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // l_fq_d1826
            // 
            this.l_fq_d1826.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_fq_d1826.AutoSize = true;
            this.l_fq_d1826.Location = new System.Drawing.Point(4, 46);
            this.l_fq_d1826.Name = "l_fq_d1826";
            this.l_fq_d1826.Size = new System.Drawing.Size(179, 13);
            this.l_fq_d1826.TabIndex = 2;
            this.l_fq_d1826.Text = "Dielectric breakdown D1816 (2 mm):";
            // 
            // l_fq_acidNum
            // 
            this.l_fq_acidNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_fq_acidNum.AutoSize = true;
            this.l_fq_acidNum.Location = new System.Drawing.Point(4, 67);
            this.l_fq_acidNum.Name = "l_fq_acidNum";
            this.l_fq_acidNum.Size = new System.Drawing.Size(71, 13);
            this.l_fq_acidNum.TabIndex = 3;
            this.l_fq_acidNum.Text = "Acid Number:";
            // 
            // l_fq_ift
            // 
            this.l_fq_ift.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_fq_ift.AutoSize = true;
            this.l_fq_ift.Location = new System.Drawing.Point(4, 88);
            this.l_fq_ift.Name = "l_fq_ift";
            this.l_fq_ift.Size = new System.Drawing.Size(97, 13);
            this.l_fq_ift.TabIndex = 4;
            this.l_fq_ift.Text = "Interfacial Tension:";
            // 
            // l_fq_spGrav
            // 
            this.l_fq_spGrav.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_fq_spGrav.AutoSize = true;
            this.l_fq_spGrav.Location = new System.Drawing.Point(4, 109);
            this.l_fq_spGrav.Name = "l_fq_spGrav";
            this.l_fq_spGrav.Size = new System.Drawing.Size(84, 13);
            this.l_fq_spGrav.TabIndex = 5;
            this.l_fq_spGrav.Text = "Specific Gravity:";
            // 
            // l_fq_color
            // 
            this.l_fq_color.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_fq_color.AutoSize = true;
            this.l_fq_color.Location = new System.Drawing.Point(4, 130);
            this.l_fq_color.Name = "l_fq_color";
            this.l_fq_color.Size = new System.Drawing.Size(34, 13);
            this.l_fq_color.TabIndex = 6;
            this.l_fq_color.Text = "Color:";
            // 
            // l_fq_visual
            // 
            this.l_fq_visual.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_fq_visual.AutoSize = true;
            this.l_fq_visual.Location = new System.Drawing.Point(4, 151);
            this.l_fq_visual.Name = "l_fq_visual";
            this.l_fq_visual.Size = new System.Drawing.Size(38, 13);
            this.l_fq_visual.TabIndex = 7;
            this.l_fq_visual.Text = "Visual:";
            // 
            // l_fq_moisture
            // 
            this.l_fq_moisture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_fq_moisture.AutoSize = true;
            this.l_fq_moisture.Location = new System.Drawing.Point(4, 172);
            this.l_fq_moisture.Name = "l_fq_moisture";
            this.l_fq_moisture.Size = new System.Drawing.Size(67, 13);
            this.l_fq_moisture.TabIndex = 8;
            this.l_fq_moisture.Text = "FQ Moisture:";
            // 
            // tlp_TOA_gasAnalysis
            // 
            this.tlp_TOA_gasAnalysis.AutoSize = true;
            this.tlp_TOA_gasAnalysis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_TOA_gasAnalysis.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_TOA_gasAnalysis.ColumnCount = 6;
            this.tlp_TOA_gasAnalysis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlp_TOA_gasAnalysis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_TOA_gasAnalysis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_TOA_gasAnalysis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_TOA_gasAnalysis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_TOA_gasAnalysis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_TOA_gasAnalysis.Controls.Add(this.l_gas_sampleDate, 0, 0);
            this.tlp_TOA_gasAnalysis.Controls.Add(this.l_gas_fluidTemp, 0, 1);
            this.tlp_TOA_gasAnalysis.Controls.Add(this.l_gas_h2, 0, 2);
            this.tlp_TOA_gasAnalysis.Controls.Add(this.l_gas_ch4, 0, 3);
            this.tlp_TOA_gasAnalysis.Controls.Add(this.l_gas_c2h6, 0, 4);
            this.tlp_TOA_gasAnalysis.Controls.Add(this.l_gas_c2h4, 0, 5);
            this.tlp_TOA_gasAnalysis.Controls.Add(this.l_gas_c2h2, 0, 6);
            this.tlp_TOA_gasAnalysis.Controls.Add(this.l_gas_co, 0, 7);
            this.tlp_TOA_gasAnalysis.Controls.Add(this.l_gas_co2, 0, 8);
            this.tlp_TOA_gasAnalysis.Controls.Add(this.l_gas_o2, 0, 9);
            this.tlp_TOA_gasAnalysis.Controls.Add(this.l_gas_n2, 0, 10);
            this.tlp_TOA_gasAnalysis.Controls.Add(this.l_gas_o2_n2, 0, 11);
            this.tlp_TOA_gasAnalysis.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlp_TOA_gasAnalysis.Location = new System.Drawing.Point(51, 263);
            this.tlp_TOA_gasAnalysis.Margin = new System.Windows.Forms.Padding(10, 3, 0, 0);
            this.tlp_TOA_gasAnalysis.Name = "tlp_TOA_gasAnalysis";
            this.tlp_TOA_gasAnalysis.RowCount = 12;
            this.tlp_TOA_gasAnalysis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_gasAnalysis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_gasAnalysis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_gasAnalysis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_gasAnalysis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_gasAnalysis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_gasAnalysis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_gasAnalysis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_gasAnalysis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_gasAnalysis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_gasAnalysis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_gasAnalysis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_gasAnalysis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_gasAnalysis.Size = new System.Drawing.Size(157, 253);
            this.tlp_TOA_gasAnalysis.TabIndex = 5;
            // 
            // l_gas_sampleDate
            // 
            this.l_gas_sampleDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_gas_sampleDate.AutoSize = true;
            this.l_gas_sampleDate.Location = new System.Drawing.Point(4, 4);
            this.l_gas_sampleDate.Name = "l_gas_sampleDate";
            this.l_gas_sampleDate.Size = new System.Drawing.Size(71, 13);
            this.l_gas_sampleDate.TabIndex = 0;
            this.l_gas_sampleDate.Text = "Sample Date:";
            // 
            // l_gas_fluidTemp
            // 
            this.l_gas_fluidTemp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_gas_fluidTemp.AutoSize = true;
            this.l_gas_fluidTemp.Location = new System.Drawing.Point(4, 25);
            this.l_gas_fluidTemp.Name = "l_gas_fluidTemp";
            this.l_gas_fluidTemp.Size = new System.Drawing.Size(95, 13);
            this.l_gas_fluidTemp.TabIndex = 1;
            this.l_gas_fluidTemp.Text = "Fluid Temperature:";
            // 
            // l_gas_h2
            // 
            this.l_gas_h2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_gas_h2.AutoSize = true;
            this.l_gas_h2.Location = new System.Drawing.Point(4, 46);
            this.l_gas_h2.Name = "l_gas_h2";
            this.l_gas_h2.Size = new System.Drawing.Size(79, 13);
            this.l_gas_h2.TabIndex = 2;
            this.l_gas_h2.Text = "Hydrogen (H2):";
            // 
            // l_gas_ch4
            // 
            this.l_gas_ch4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_gas_ch4.AutoSize = true;
            this.l_gas_ch4.Location = new System.Drawing.Point(4, 67);
            this.l_gas_ch4.Name = "l_gas_ch4";
            this.l_gas_ch4.Size = new System.Drawing.Size(82, 13);
            this.l_gas_ch4.TabIndex = 3;
            this.l_gas_ch4.Text = "Methane (CH4):";
            // 
            // l_gas_c2h6
            // 
            this.l_gas_c2h6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_gas_c2h6.AutoSize = true;
            this.l_gas_c2h6.Location = new System.Drawing.Point(4, 88);
            this.l_gas_c2h6.Name = "l_gas_c2h6";
            this.l_gas_c2h6.Size = new System.Drawing.Size(80, 13);
            this.l_gas_c2h6.TabIndex = 4;
            this.l_gas_c2h6.Text = "Ethane (C2H6):";
            // 
            // l_gas_c2h4
            // 
            this.l_gas_c2h4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_gas_c2h4.AutoSize = true;
            this.l_gas_c2h4.Location = new System.Drawing.Point(4, 109);
            this.l_gas_c2h4.Name = "l_gas_c2h4";
            this.l_gas_c2h4.Size = new System.Drawing.Size(87, 13);
            this.l_gas_c2h4.TabIndex = 5;
            this.l_gas_c2h4.Text = "Ethylene (C2H4):";
            // 
            // l_gas_c2h2
            // 
            this.l_gas_c2h2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_gas_c2h2.AutoSize = true;
            this.l_gas_c2h2.Location = new System.Drawing.Point(4, 130);
            this.l_gas_c2h2.Name = "l_gas_c2h2";
            this.l_gas_c2h2.Size = new System.Drawing.Size(93, 13);
            this.l_gas_c2h2.TabIndex = 6;
            this.l_gas_c2h2.Text = "Acetylene (C2H2):";
            // 
            // l_gas_co
            // 
            this.l_gas_co.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_gas_co.AutoSize = true;
            this.l_gas_co.Location = new System.Drawing.Point(4, 151);
            this.l_gas_co.Name = "l_gas_co";
            this.l_gas_co.Size = new System.Drawing.Size(117, 13);
            this.l_gas_co.TabIndex = 7;
            this.l_gas_co.Text = "Carbon Monoxide (CO):";
            // 
            // l_gas_co2
            // 
            this.l_gas_co2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_gas_co2.AutoSize = true;
            this.l_gas_co2.Location = new System.Drawing.Point(4, 172);
            this.l_gas_co2.Name = "l_gas_co2";
            this.l_gas_co2.Size = new System.Drawing.Size(112, 13);
            this.l_gas_co2.TabIndex = 8;
            this.l_gas_co2.Text = "Carbon Dioxide (CO2):";
            // 
            // l_gas_o2
            // 
            this.l_gas_o2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_gas_o2.AutoSize = true;
            this.l_gas_o2.Location = new System.Drawing.Point(4, 193);
            this.l_gas_o2.Name = "l_gas_o2";
            this.l_gas_o2.Size = new System.Drawing.Size(69, 13);
            this.l_gas_o2.TabIndex = 20;
            this.l_gas_o2.Text = "Oxygen (O2):";
            // 
            // l_gas_n2
            // 
            this.l_gas_n2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_gas_n2.AutoSize = true;
            this.l_gas_n2.Location = new System.Drawing.Point(4, 214);
            this.l_gas_n2.Name = "l_gas_n2";
            this.l_gas_n2.Size = new System.Drawing.Size(73, 13);
            this.l_gas_n2.TabIndex = 19;
            this.l_gas_n2.Text = "Nitrogen (N2):";
            // 
            // l_gas_o2_n2
            // 
            this.l_gas_o2_n2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_gas_o2_n2.AutoSize = true;
            this.l_gas_o2_n2.Location = new System.Drawing.Point(4, 235);
            this.l_gas_o2_n2.Name = "l_gas_o2_n2";
            this.l_gas_o2_n2.Size = new System.Drawing.Size(133, 13);
            this.l_gas_o2_n2.TabIndex = 18;
            this.l_gas_o2_n2.Text = "Oxygen/Nitrogen (O2/N2):";
            // 
            // l_TOA_header
            // 
            this.l_TOA_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_TOA_header.AutoSize = true;
            this.l_TOA_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_TOA_header.ForeColor = System.Drawing.Color.MidnightBlue;
            this.l_TOA_header.Location = new System.Drawing.Point(44, 10);
            this.l_TOA_header.Name = "l_TOA_header";
            this.l_TOA_header.Size = new System.Drawing.Size(179, 20);
            this.l_TOA_header.TabIndex = 0;
            this.l_TOA_header.Text = "Fluid Analysis Report";
            // 
            // l_GasAnalysis
            // 
            this.l_GasAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_GasAnalysis.AutoSize = true;
            this.l_GasAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_GasAnalysis.ForeColor = System.Drawing.Color.MidnightBlue;
            this.l_GasAnalysis.Location = new System.Drawing.Point(44, 242);
            this.l_GasAnalysis.Name = "l_GasAnalysis";
            this.l_GasAnalysis.Size = new System.Drawing.Size(106, 18);
            this.l_GasAnalysis.TabIndex = 1;
            this.l_GasAnalysis.Text = "Gas Analysis";
            // 
            // l_FluidQuality
            // 
            this.l_FluidQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_FluidQuality.AutoSize = true;
            this.l_FluidQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_FluidQuality.ForeColor = System.Drawing.Color.MidnightBlue;
            this.l_FluidQuality.Location = new System.Drawing.Point(44, 535);
            this.l_FluidQuality.Name = "l_FluidQuality";
            this.l_FluidQuality.Size = new System.Drawing.Size(101, 18);
            this.l_FluidQuality.TabIndex = 2;
            this.l_FluidQuality.Text = "Fluid Quality";
            // 
            // l_Moisture
            // 
            this.l_Moisture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_Moisture.AutoSize = true;
            this.l_Moisture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Moisture.ForeColor = System.Drawing.Color.MidnightBlue;
            this.l_Moisture.Location = new System.Drawing.Point(44, 765);
            this.l_Moisture.Name = "l_Moisture";
            this.l_Moisture.Size = new System.Drawing.Size(141, 18);
            this.l_Moisture.TabIndex = 3;
            this.l_Moisture.Text = "Moisture Analysis";
            // 
            // tlp_TOA_fluidAnalysisReport
            // 
            this.tlp_TOA_fluidAnalysisReport.AutoSize = true;
            this.tlp_TOA_fluidAnalysisReport.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_TOA_fluidAnalysisReport.ColumnCount = 2;
            this.tlp_TOA_fluidAnalysisReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlp_TOA_fluidAnalysisReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_TOA_fluidAnalysisReport.Controls.Add(this.l_remarks, 1, 8);
            this.tlp_TOA_fluidAnalysisReport.Controls.Add(this.l_opsCount, 1, 7);
            this.tlp_TOA_fluidAnalysisReport.Controls.Add(this.l_oilPresType, 1, 6);
            this.tlp_TOA_fluidAnalysisReport.Controls.Add(this.l_model, 1, 5);
            this.tlp_TOA_fluidAnalysisReport.Controls.Add(this.l_yearMfg, 1, 4);
            this.tlp_TOA_fluidAnalysisReport.Controls.Add(this.l_mfr, 1, 3);
            this.tlp_TOA_fluidAnalysisReport.Controls.Add(this.l_norm, 1, 2);
            this.tlp_TOA_fluidAnalysisReport.Controls.Add(this.l_serialNum, 1, 1);
            this.tlp_TOA_fluidAnalysisReport.Controls.Add(this.l_equipNum, 1, 0);
            this.tlp_TOA_fluidAnalysisReport.Controls.Add(this.l_FAR_equipmentNum, 0, 0);
            this.tlp_TOA_fluidAnalysisReport.Controls.Add(this.l_FAR_serialNum, 0, 1);
            this.tlp_TOA_fluidAnalysisReport.Controls.Add(this.l_FAR_normUsed, 0, 2);
            this.tlp_TOA_fluidAnalysisReport.Controls.Add(this.l_FAR_manufacturer, 0, 3);
            this.tlp_TOA_fluidAnalysisReport.Controls.Add(this.l_FAR_yrManufactured, 0, 4);
            this.tlp_TOA_fluidAnalysisReport.Controls.Add(this.l_FAR_model, 0, 5);
            this.tlp_TOA_fluidAnalysisReport.Controls.Add(this.l_FAR_oilPresType, 0, 6);
            this.tlp_TOA_fluidAnalysisReport.Controls.Add(this.l_FAR_opsCount, 0, 7);
            this.tlp_TOA_fluidAnalysisReport.Controls.Add(this.l_FAR_equipmentRemarks, 0, 8);
            this.tlp_TOA_fluidAnalysisReport.Location = new System.Drawing.Point(51, 33);
            this.tlp_TOA_fluidAnalysisReport.Margin = new System.Windows.Forms.Padding(10, 3, 0, 0);
            this.tlp_TOA_fluidAnalysisReport.Name = "tlp_TOA_fluidAnalysisReport";
            this.tlp_TOA_fluidAnalysisReport.RowCount = 9;
            this.tlp_TOA_fluidAnalysisReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_fluidAnalysisReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_fluidAnalysisReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_fluidAnalysisReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_fluidAnalysisReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_fluidAnalysisReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_fluidAnalysisReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_fluidAnalysisReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_fluidAnalysisReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TOA_fluidAnalysisReport.Size = new System.Drawing.Size(221, 190);
            this.tlp_TOA_fluidAnalysisReport.TabIndex = 4;
            // 
            // l_remarks
            // 
            this.l_remarks.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_remarks.AutoSize = true;
            this.l_remarks.Location = new System.Drawing.Point(155, 172);
            this.l_remarks.Name = "l_remarks";
            this.l_remarks.Size = new System.Drawing.Size(44, 13);
            this.l_remarks.TabIndex = 17;
            this.l_remarks.Text = "remarks";
            // 
            // l_opsCount
            // 
            this.l_opsCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_opsCount.AutoSize = true;
            this.l_opsCount.Location = new System.Drawing.Point(155, 151);
            this.l_opsCount.Name = "l_opsCount";
            this.l_opsCount.Size = new System.Drawing.Size(52, 13);
            this.l_opsCount.TabIndex = 16;
            this.l_opsCount.Text = "opsCount";
            // 
            // l_oilPresType
            // 
            this.l_oilPresType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_oilPresType.AutoSize = true;
            this.l_oilPresType.Location = new System.Drawing.Point(155, 130);
            this.l_oilPresType.Name = "l_oilPresType";
            this.l_oilPresType.Size = new System.Drawing.Size(62, 13);
            this.l_oilPresType.TabIndex = 15;
            this.l_oilPresType.Text = "oilPresType";
            // 
            // l_model
            // 
            this.l_model.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_model.AutoSize = true;
            this.l_model.Location = new System.Drawing.Point(155, 109);
            this.l_model.Name = "l_model";
            this.l_model.Size = new System.Drawing.Size(35, 13);
            this.l_model.TabIndex = 14;
            this.l_model.Text = "model";
            // 
            // l_yearMfg
            // 
            this.l_yearMfg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_yearMfg.AutoSize = true;
            this.l_yearMfg.Location = new System.Drawing.Point(155, 88);
            this.l_yearMfg.Name = "l_yearMfg";
            this.l_yearMfg.Size = new System.Drawing.Size(45, 13);
            this.l_yearMfg.TabIndex = 13;
            this.l_yearMfg.Text = "yearMfg";
            // 
            // l_mfr
            // 
            this.l_mfr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_mfr.AutoSize = true;
            this.l_mfr.Location = new System.Drawing.Point(155, 67);
            this.l_mfr.Name = "l_mfr";
            this.l_mfr.Size = new System.Drawing.Size(21, 13);
            this.l_mfr.TabIndex = 12;
            this.l_mfr.Text = "mfr";
            // 
            // l_norm
            // 
            this.l_norm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_norm.AutoSize = true;
            this.l_norm.Location = new System.Drawing.Point(155, 46);
            this.l_norm.Name = "l_norm";
            this.l_norm.Size = new System.Drawing.Size(30, 13);
            this.l_norm.TabIndex = 11;
            this.l_norm.Text = "norm";
            // 
            // l_serialNum
            // 
            this.l_serialNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_serialNum.AutoSize = true;
            this.l_serialNum.Location = new System.Drawing.Point(155, 25);
            this.l_serialNum.Name = "l_serialNum";
            this.l_serialNum.Size = new System.Drawing.Size(53, 13);
            this.l_serialNum.TabIndex = 10;
            this.l_serialNum.Text = "serialNum";
            // 
            // l_equipNum
            // 
            this.l_equipNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_equipNum.AutoSize = true;
            this.l_equipNum.Location = new System.Drawing.Point(155, 4);
            this.l_equipNum.Name = "l_equipNum";
            this.l_equipNum.Size = new System.Drawing.Size(55, 13);
            this.l_equipNum.TabIndex = 9;
            this.l_equipNum.Text = "equipNum";
            // 
            // l_FAR_equipmentNum
            // 
            this.l_FAR_equipmentNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_FAR_equipmentNum.AutoSize = true;
            this.l_FAR_equipmentNum.Location = new System.Drawing.Point(4, 4);
            this.l_FAR_equipmentNum.Name = "l_FAR_equipmentNum";
            this.l_FAR_equipmentNum.Size = new System.Drawing.Size(100, 13);
            this.l_FAR_equipmentNum.TabIndex = 0;
            this.l_FAR_equipmentNum.Text = "Equipment Number:";
            // 
            // l_FAR_serialNum
            // 
            this.l_FAR_serialNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_FAR_serialNum.AutoSize = true;
            this.l_FAR_serialNum.Location = new System.Drawing.Point(4, 25);
            this.l_FAR_serialNum.Name = "l_FAR_serialNum";
            this.l_FAR_serialNum.Size = new System.Drawing.Size(76, 13);
            this.l_FAR_serialNum.TabIndex = 1;
            this.l_FAR_serialNum.Text = "Serial Number:";
            // 
            // l_FAR_normUsed
            // 
            this.l_FAR_normUsed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_FAR_normUsed.AutoSize = true;
            this.l_FAR_normUsed.Location = new System.Drawing.Point(4, 46);
            this.l_FAR_normUsed.Name = "l_FAR_normUsed";
            this.l_FAR_normUsed.Size = new System.Drawing.Size(63, 13);
            this.l_FAR_normUsed.TabIndex = 2;
            this.l_FAR_normUsed.Text = "Norm Used:";
            // 
            // l_FAR_manufacturer
            // 
            this.l_FAR_manufacturer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_FAR_manufacturer.AutoSize = true;
            this.l_FAR_manufacturer.Location = new System.Drawing.Point(4, 67);
            this.l_FAR_manufacturer.Name = "l_FAR_manufacturer";
            this.l_FAR_manufacturer.Size = new System.Drawing.Size(73, 13);
            this.l_FAR_manufacturer.TabIndex = 3;
            this.l_FAR_manufacturer.Text = "Manufacturer:";
            // 
            // l_FAR_yrManufactured
            // 
            this.l_FAR_yrManufactured.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_FAR_yrManufactured.AutoSize = true;
            this.l_FAR_yrManufactured.Location = new System.Drawing.Point(4, 88);
            this.l_FAR_yrManufactured.Name = "l_FAR_yrManufactured";
            this.l_FAR_yrManufactured.Size = new System.Drawing.Size(101, 13);
            this.l_FAR_yrManufactured.TabIndex = 4;
            this.l_FAR_yrManufactured.Text = "Year Manufactured:";
            // 
            // l_FAR_model
            // 
            this.l_FAR_model.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_FAR_model.AutoSize = true;
            this.l_FAR_model.Location = new System.Drawing.Point(4, 109);
            this.l_FAR_model.Name = "l_FAR_model";
            this.l_FAR_model.Size = new System.Drawing.Size(39, 13);
            this.l_FAR_model.TabIndex = 5;
            this.l_FAR_model.Text = "Model:";
            // 
            // l_FAR_oilPresType
            // 
            this.l_FAR_oilPresType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_FAR_oilPresType.AutoSize = true;
            this.l_FAR_oilPresType.Location = new System.Drawing.Point(4, 130);
            this.l_FAR_oilPresType.Name = "l_FAR_oilPresType";
            this.l_FAR_oilPresType.Size = new System.Drawing.Size(111, 13);
            this.l_FAR_oilPresType.TabIndex = 6;
            this.l_FAR_oilPresType.Text = "Oil Preservation Type:";
            // 
            // l_FAR_opsCount
            // 
            this.l_FAR_opsCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_FAR_opsCount.AutoSize = true;
            this.l_FAR_opsCount.Location = new System.Drawing.Point(4, 151);
            this.l_FAR_opsCount.Name = "l_FAR_opsCount";
            this.l_FAR_opsCount.Size = new System.Drawing.Size(92, 13);
            this.l_FAR_opsCount.TabIndex = 7;
            this.l_FAR_opsCount.Text = "Operations Count:";
            // 
            // l_FAR_equipmentRemarks
            // 
            this.l_FAR_equipmentRemarks.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_FAR_equipmentRemarks.AutoSize = true;
            this.l_FAR_equipmentRemarks.Location = new System.Drawing.Point(4, 172);
            this.l_FAR_equipmentRemarks.Name = "l_FAR_equipmentRemarks";
            this.l_FAR_equipmentRemarks.Size = new System.Drawing.Size(105, 13);
            this.l_FAR_equipmentRemarks.TabIndex = 8;
            this.l_FAR_equipmentRemarks.Text = "Equipment Remarks:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.InitialDirectory = "Application.StartupPath";
            // 
            // tp_coefficients
            // 
            this.tp_coefficients.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tp_coefficients.Controls.Add(this.tlp_Coeff_bg);
            this.tp_coefficients.Location = new System.Drawing.Point(4, 22);
            this.tp_coefficients.Name = "tp_coefficients";
            this.tp_coefficients.Size = new System.Drawing.Size(1176, 712);
            this.tp_coefficients.TabIndex = 4;
            this.tp_coefficients.Text = "Assessment Coefficients";
            // 
            // tlp_Coeff_bg
            // 
            this.tlp_Coeff_bg.ColumnCount = 3;
            this.tlp_Coeff_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Coeff_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 900F));
            this.tlp_Coeff_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Coeff_bg.Controls.Add(this.tlp_Coeff_center, 1, 0);
            this.tlp_Coeff_bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Coeff_bg.Location = new System.Drawing.Point(0, 0);
            this.tlp_Coeff_bg.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Coeff_bg.Name = "tlp_Coeff_bg";
            this.tlp_Coeff_bg.RowCount = 1;
            this.tlp_Coeff_bg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Coeff_bg.Size = new System.Drawing.Size(1176, 712);
            this.tlp_Coeff_bg.TabIndex = 0;
            // 
            // tlp_Coeff_center
            // 
            this.tlp_Coeff_center.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlp_Coeff_center.ColumnCount = 2;
            this.tlp_Coeff_center.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Coeff_center.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Coeff_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Coeff_center.Location = new System.Drawing.Point(138, 0);
            this.tlp_Coeff_center.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Coeff_center.Name = "tlp_Coeff_center";
            this.tlp_Coeff_center.RowCount = 2;
            this.tlp_Coeff_center.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Coeff_center.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Coeff_center.Size = new System.Drawing.Size(900, 712);
            this.tlp_Coeff_center.TabIndex = 0;
            // 
            // tlp_Analyze_center
            // 
            this.tlp_Analyze_center.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlp_Analyze_center.ColumnCount = 2;
            this.tlp_Analyze_center.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Analyze_center.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Analyze_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Analyze_center.Location = new System.Drawing.Point(136, 0);
            this.tlp_Analyze_center.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Analyze_center.Name = "tlp_Analyze_center";
            this.tlp_Analyze_center.RowCount = 2;
            this.tlp_Analyze_center.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Analyze_center.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Analyze_center.Size = new System.Drawing.Size(900, 708);
            this.tlp_Analyze_center.TabIndex = 0;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.panel_Config);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NES Transformer Assessment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Config.ResumeLayout(false);
            this.panel_Analyze.ResumeLayout(false);
            this.tp_Main.ResumeLayout(false);
            this.tp_Analyze.ResumeLayout(false);
            this.tlp_Analyze_bg.ResumeLayout(false);
            this.tp_Config.ResumeLayout(false);
            this.tlp_Config_bg.ResumeLayout(false);
            this.tlp_Config_folderSelect.ResumeLayout(false);
            this.tlp_Config_folderSelect.PerformLayout();
            this.tlp_Config_normSelect.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_NormDisplay)).EndInit();
            this.tp_EquipmentSelect_bg.ResumeLayout(false);
            this.tlp_Equiment_bg.ResumeLayout(false);
            this.tlp_XfmrEquipSelect.ResumeLayout(false);
            this.tlp_XfmrEquipSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EquipDisplay)).EndInit();
            this.tp_TOA.ResumeLayout(false);
            this.tlp_Data.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel_TOA_center.ResumeLayout(false);
            this.panel_TOA_center.PerformLayout();
            this.tlp_Data_centerColumn.ResumeLayout(false);
            this.tlp_Data_centerColumn.PerformLayout();
            this.tlp_TOA_Moisture.ResumeLayout(false);
            this.tlp_TOA_Moisture.PerformLayout();
            this.tlp_TOA_FluidQuality.ResumeLayout(false);
            this.tlp_TOA_FluidQuality.PerformLayout();
            this.tlp_TOA_gasAnalysis.ResumeLayout(false);
            this.tlp_TOA_gasAnalysis.PerformLayout();
            this.tlp_TOA_fluidAnalysisReport.ResumeLayout(false);
            this.tlp_TOA_fluidAnalysisReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentSource)).EndInit();
            this.tp_coefficients.ResumeLayout(false);
            this.tlp_Coeff_bg.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tp_EquipmentSelect_bg;
        private System.Windows.Forms.TableLayoutPanel tlp_Equiment_bg;
        private System.Windows.Forms.TableLayoutPanel tlp_XfmrEquipSelect;
        private System.Windows.Forms.Label l_chooseXFMR;
        private System.Windows.Forms.Label l_chooseXFMREquip;
        private System.Windows.Forms.ComboBox cb_xfmrSelection;
        private System.Windows.Forms.ComboBox cb_xfmrEquipSelect;
        private System.Windows.Forms.DataGridView dgv_EquipDisplay;
        private System.Windows.Forms.TabPage tp_TOA;
        private System.Windows.Forms.TableLayoutPanel tlp_Data;
        private System.Windows.Forms.Label l_SelectedEquipment;
        private System.Windows.Forms.Button b_RefreshNorms;
        private System.Windows.Forms.Button b_RefreshTestData;
        private System.Windows.Forms.Button b_RefreshEquipment;
        private System.Windows.Forms.TableLayoutPanel tlp_Analyze_bg;
        private System.Windows.Forms.TableLayoutPanel tlp_Data_centerColumn;
        private System.Windows.Forms.Label l_TOA_header;
        private System.Windows.Forms.Label l_GasAnalysis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label l_FluidQuality;
        private System.Windows.Forms.Label l_Moisture;
        private System.Windows.Forms.TableLayoutPanel tlp_TOA_fluidAnalysisReport;
        private System.Windows.Forms.Label l_FAR_equipmentNum;
        private System.Windows.Forms.Label l_FAR_serialNum;
        private System.Windows.Forms.Label l_FAR_normUsed;
        private System.Windows.Forms.Label l_FAR_manufacturer;
        private System.Windows.Forms.Label l_FAR_yrManufactured;
        private System.Windows.Forms.Label l_FAR_model;
        private System.Windows.Forms.Label l_FAR_oilPresType;
        private System.Windows.Forms.Label l_FAR_opsCount;
        private System.Windows.Forms.Label l_FAR_equipmentRemarks;
        private System.Windows.Forms.Label l_remarks;
        private System.Windows.Forms.Label l_opsCount;
        private System.Windows.Forms.Label l_oilPresType;
        private System.Windows.Forms.Label l_model;
        private System.Windows.Forms.Label l_yearMfg;
        private System.Windows.Forms.Label l_mfr;
        private System.Windows.Forms.Label l_norm;
        private System.Windows.Forms.Label l_serialNum;
        private System.Windows.Forms.Label l_equipNum;
        private System.Windows.Forms.TableLayoutPanel tlp_TOA_gasAnalysis;
        private System.Windows.Forms.Label l_gas_sampleDate;
        private System.Windows.Forms.Label l_gas_fluidTemp;
        private System.Windows.Forms.Label l_gas_h2;
        private System.Windows.Forms.Label l_gas_ch4;
        private System.Windows.Forms.Label l_gas_c2h6;
        private System.Windows.Forms.Label l_gas_c2h4;
        private System.Windows.Forms.Label l_gas_c2h2;
        private System.Windows.Forms.Label l_gas_co;
        private System.Windows.Forms.Label l_gas_co2;
        private System.Windows.Forms.Label l_gas_o2_n2;
        private System.Windows.Forms.Label l_gas_o2;
        private System.Windows.Forms.Label l_gas_n2;
        private System.Windows.Forms.Panel panel_TOA_center;
        private System.Windows.Forms.TableLayoutPanel tlp_TOA_FluidQuality;
        private System.Windows.Forms.Label l_fq_date;
        private System.Windows.Forms.Label l_fq_temp;
        private System.Windows.Forms.Label l_fq_d1826;
        private System.Windows.Forms.Label l_fq_acidNum;
        private System.Windows.Forms.Label l_fq_ift;
        private System.Windows.Forms.Label l_fq_spGrav;
        private System.Windows.Forms.Label l_fq_color;
        private System.Windows.Forms.Label l_fq_visual;
        private System.Windows.Forms.Label l_fq_moisture;
        private System.Windows.Forms.TableLayoutPanel tlp_TOA_Moisture;
        private System.Windows.Forms.Label l_moist_date;
        private System.Windows.Forms.Label l_moist_temp;
        private System.Windows.Forms.Label l_moist_moisture;
        private System.Windows.Forms.Label l_moist_relSat;
        private System.Windows.Forms.TabPage tp_coefficients;
        private System.Windows.Forms.TableLayoutPanel tlp_Coeff_bg;
        private System.Windows.Forms.TableLayoutPanel tlp_Coeff_center;
        private System.Windows.Forms.TableLayoutPanel tlp_Analyze_center;
    }
}

