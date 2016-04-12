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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_NormsFolder = new System.Windows.Forms.Button();
            this.button_TOAExportsFolder = new System.Windows.Forms.Button();
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
            this.tb_ExportsFolder_BG = new System.Windows.Forms.TextBox();
            this.tb_NormsFolder_BG = new System.Windows.Forms.TextBox();
            this.tlp_Config_normSelect = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_NormSelect = new System.Windows.Forms.ListBox();
            this.lab_Norms = new System.Windows.Forms.Label();
            this.dg_NormDisplay = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tp_Equipment = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.panel_Config.SuspendLayout();
            this.panel_Analyze.SuspendLayout();
            this.tp_Main.SuspendLayout();
            this.tp_Config.SuspendLayout();
            this.tlp_Config_bg.SuspendLayout();
            this.tlp_Config_folderSelect.SuspendLayout();
            this.tlp_Config_normSelect.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_NormDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_NormsFolder
            // 
            this.button_NormsFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_NormsFolder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_NormsFolder.Location = new System.Drawing.Point(3, 3);
            this.button_NormsFolder.Name = "button_NormsFolder";
            this.button_NormsFolder.Size = new System.Drawing.Size(124, 23);
            this.button_NormsFolder.TabIndex = 0;
            this.button_NormsFolder.Text = "Norms Folder";
            this.button_NormsFolder.UseVisualStyleBackColor = true;
            this.button_NormsFolder.Click += new System.EventHandler(this.button_NormsFolder_Click);
            // 
            // button_TOAExportsFolder
            // 
            this.button_TOAExportsFolder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_TOAExportsFolder.Location = new System.Drawing.Point(3, 32);
            this.button_TOAExportsFolder.Name = "button_TOAExportsFolder";
            this.button_TOAExportsFolder.Size = new System.Drawing.Size(124, 23);
            this.button_TOAExportsFolder.TabIndex = 1;
            this.button_TOAExportsFolder.Text = "TOAExports Folder";
            this.button_TOAExportsFolder.UseVisualStyleBackColor = true;
            this.button_TOAExportsFolder.Click += new System.EventHandler(this.button_TOAExportsFolder_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
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
            this.panel_Config.Size = new System.Drawing.Size(884, 538);
            this.panel_Config.TabIndex = 3;
            // 
            // panel_Analyze
            // 
            this.panel_Analyze.Controls.Add(this.tp_Main);
            this.panel_Analyze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Analyze.Location = new System.Drawing.Point(0, 0);
            this.panel_Analyze.Name = "panel_Analyze";
            this.panel_Analyze.Size = new System.Drawing.Size(884, 538);
            this.panel_Analyze.TabIndex = 6;
            // 
            // tp_Main
            // 
            this.tp_Main.Controls.Add(this.tp_Analyze);
            this.tp_Main.Controls.Add(this.tp_Config);
            this.tp_Main.Controls.Add(this.tp_Equipment);
            this.tp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tp_Main.Location = new System.Drawing.Point(0, 0);
            this.tp_Main.Name = "tp_Main";
            this.tp_Main.SelectedIndex = 0;
            this.tp_Main.Size = new System.Drawing.Size(884, 538);
            this.tp_Main.TabIndex = 0;
            // 
            // tp_Analyze
            // 
            this.tp_Analyze.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tp_Analyze.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tp_Analyze.Location = new System.Drawing.Point(4, 22);
            this.tp_Analyze.Name = "tp_Analyze";
            this.tp_Analyze.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Analyze.Size = new System.Drawing.Size(876, 512);
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
            this.tp_Config.Name = "tp_Config";
            this.tp_Config.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Config.Size = new System.Drawing.Size(876, 512);
            this.tp_Config.TabIndex = 1;
            this.tp_Config.Text = "Config";
            this.tp_Config.UseVisualStyleBackColor = true;
            // 
            // tlp_Config_bg
            // 
            this.tlp_Config_bg.ColumnCount = 1;
            this.tlp_Config_bg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlp_Config_bg.Controls.Add(this.tlp_Config_folderSelect, 0, 0);
            this.tlp_Config_bg.Controls.Add(this.tlp_Config_normSelect, 0, 1);
            this.tlp_Config_bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Config_bg.Location = new System.Drawing.Point(3, 3);
            this.tlp_Config_bg.Name = "tlp_Config_bg";
            this.tlp_Config_bg.RowCount = 2;
            this.tlp_Config_bg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlp_Config_bg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Config_bg.Size = new System.Drawing.Size(866, 502);
            this.tlp_Config_bg.TabIndex = 12;
            // 
            // tlp_Config_folderSelect
            // 
            this.tlp_Config_folderSelect.ColumnCount = 2;
            this.tlp_Config_folderSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlp_Config_folderSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Config_folderSelect.Controls.Add(this.button_TOAExportsFolder, 0, 1);
            this.tlp_Config_folderSelect.Controls.Add(this.tb_ExportsFolder_BG, 1, 1);
            this.tlp_Config_folderSelect.Controls.Add(this.button_NormsFolder, 0, 0);
            this.tlp_Config_folderSelect.Controls.Add(this.tb_NormsFolder_BG, 1, 0);
            this.tlp_Config_folderSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Config_folderSelect.Location = new System.Drawing.Point(3, 3);
            this.tlp_Config_folderSelect.Name = "tlp_Config_folderSelect";
            this.tlp_Config_folderSelect.RowCount = 2;
            this.tlp_Config_folderSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlp_Config_folderSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlp_Config_folderSelect.Size = new System.Drawing.Size(860, 58);
            this.tlp_Config_folderSelect.TabIndex = 0;
            // 
            // tb_ExportsFolder_BG
            // 
            this.tb_ExportsFolder_BG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_ExportsFolder_BG.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_ExportsFolder_BG.CausesValidation = false;
            this.tb_ExportsFolder_BG.Enabled = false;
            this.tb_ExportsFolder_BG.Location = new System.Drawing.Point(133, 33);
            this.tb_ExportsFolder_BG.Name = "tb_ExportsFolder_BG";
            this.tb_ExportsFolder_BG.Size = new System.Drawing.Size(704, 20);
            this.tb_ExportsFolder_BG.TabIndex = 5;
            this.tb_ExportsFolder_BG.Text = "TOA Exports Folder";
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
            this.tb_NormsFolder_BG.Size = new System.Drawing.Size(704, 20);
            this.tb_NormsFolder_BG.TabIndex = 4;
            this.tb_NormsFolder_BG.Text = "Norms Folder";
            // 
            // tlp_Config_normSelect
            // 
            this.tlp_Config_normSelect.ColumnCount = 2;
            this.tlp_Config_normSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tlp_Config_normSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Config_normSelect.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlp_Config_normSelect.Controls.Add(this.dg_NormDisplay, 1, 0);
            this.tlp_Config_normSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Config_normSelect.Location = new System.Drawing.Point(3, 67);
            this.tlp_Config_normSelect.Name = "tlp_Config_normSelect";
            this.tlp_Config_normSelect.RowCount = 1;
            this.tlp_Config_normSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Config_normSelect.Size = new System.Drawing.Size(860, 432);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(198, 432);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_NormDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dg_NormDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_NormDisplay.DefaultCellStyle = dataGridViewCellStyle10;
            this.dg_NormDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_NormDisplay.Location = new System.Drawing.Point(201, 0);
            this.dg_NormDisplay.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.dg_NormDisplay.Name = "dg_NormDisplay";
            this.dg_NormDisplay.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_NormDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dg_NormDisplay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_NormDisplay.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dg_NormDisplay.Size = new System.Drawing.Size(656, 429);
            this.dg_NormDisplay.TabIndex = 11;
            // 
            // tp_Equipment
            // 
            this.tp_Equipment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tp_Equipment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tp_Equipment.Location = new System.Drawing.Point(4, 22);
            this.tp_Equipment.Name = "tp_Equipment";
            this.tp_Equipment.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Equipment.Size = new System.Drawing.Size(876, 512);
            this.tp_Equipment.TabIndex = 2;
            this.tp_Equipment.Text = "Equipment";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.panel_Config);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormHome";
            this.ShowIcon = false;
            this.Text = "NES Transformer Assessment";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Config.ResumeLayout(false);
            this.panel_Analyze.ResumeLayout(false);
            this.tp_Main.ResumeLayout(false);
            this.tp_Config.ResumeLayout(false);
            this.tlp_Config_bg.ResumeLayout(false);
            this.tlp_Config_folderSelect.ResumeLayout(false);
            this.tlp_Config_folderSelect.PerformLayout();
            this.tlp_Config_normSelect.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_NormDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_NormsFolder;
        private System.Windows.Forms.Button button_TOAExportsFolder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_File;
        private System.Windows.Forms.ToolStripMenuItem menu_Quit;
        private System.Windows.Forms.Panel panel_Config;
        private System.Windows.Forms.TextBox tb_NormsFolder_BG;
        private System.Windows.Forms.TextBox tb_ExportsFolder_BG;
        public System.Windows.Forms.FolderBrowserDialog openFolderDia;
        private System.Windows.Forms.Panel panel_Analyze;
        private System.Windows.Forms.TabControl tp_Main;
        private System.Windows.Forms.TabPage tp_Analyze;
        private System.Windows.Forms.TabPage tp_Config;
        private System.Windows.Forms.Label lab_Norms;
        private System.Windows.Forms.ListBox lb_NormSelect;
        private System.Windows.Forms.DataGridView dg_NormDisplay;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TableLayoutPanel tlp_Config_bg;
        private System.Windows.Forms.TableLayoutPanel tlp_Config_folderSelect;
        private System.Windows.Forms.TableLayoutPanel tlp_Config_normSelect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tp_Equipment;

    }
}

