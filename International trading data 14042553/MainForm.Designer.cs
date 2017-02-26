namespace International_trading_data_14042553
{
    partial class TradingDataForm
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
            this.CountryTreeViewLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountryInfoLabel = new System.Windows.Forms.Label();
            this.CountryLV = new System.Windows.Forms.ListView();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.RemoveTPBtn = new System.Windows.Forms.Button();
            this.TradePartnersLB = new System.Windows.Forms.ListBox();
            this.TradePartnersLabel = new System.Windows.Forms.Label();
            this.HdiUD = new System.Windows.Forms.NumericUpDown();
            this.HDIRankingLabel = new System.Windows.Forms.Label();
            this.TradeBalanceUD = new System.Windows.Forms.NumericUpDown();
            this.TradeBalanceLabel = new System.Windows.Forms.Label();
            this.InflationUD = new System.Windows.Forms.NumericUpDown();
            this.InflationLabel = new System.Windows.Forms.Label();
            this.GDPGrowthUD = new System.Windows.Forms.NumericUpDown();
            this.GDPGrowthLabel = new System.Windows.Forms.Label();
            this.CountryNameTB = new System.Windows.Forms.TextBox();
            this.CountryNameLabel = new System.Windows.Forms.Label();
            this.CountryInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RmvCountryBtn = new System.Windows.Forms.Button();
            this.AddTradePartnerTB = new System.Windows.Forms.TextBox();
            this.AddTPBtn = new System.Windows.Forms.Button();
            this.AddCountryBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HdiUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeBalanceUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InflationUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GDPGrowthUD)).BeginInit();
            this.CountryInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountryTreeViewLabel
            // 
            this.CountryTreeViewLabel.AutoSize = true;
            this.CountryTreeViewLabel.Location = new System.Drawing.Point(13, 36);
            this.CountryTreeViewLabel.Name = "CountryTreeViewLabel";
            this.CountryTreeViewLabel.Size = new System.Drawing.Size(51, 13);
            this.CountryTreeViewLabel.TabIndex = 1;
            this.CountryTreeViewLabel.Text = "Countries";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "Add Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // CountryInfoLabel
            // 
            this.CountryInfoLabel.AutoSize = true;
            this.CountryInfoLabel.Location = new System.Drawing.Point(151, 36);
            this.CountryInfoLabel.Name = "CountryInfoLabel";
            this.CountryInfoLabel.Size = new System.Drawing.Size(98, 13);
            this.CountryInfoLabel.TabIndex = 5;
            this.CountryInfoLabel.Text = "Country Information";
            // 
            // CountryLV
            // 
            this.CountryLV.FullRowSelect = true;
            this.CountryLV.GridLines = true;
            this.CountryLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.CountryLV.LabelWrap = false;
            this.CountryLV.Location = new System.Drawing.Point(12, 52);
            this.CountryLV.MultiSelect = false;
            this.CountryLV.Name = "CountryLV";
            this.CountryLV.Size = new System.Drawing.Size(115, 209);
            this.CountryLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.CountryLV.TabIndex = 6;
            this.CountryLV.UseCompatibleStateImageBehavior = false;
            this.CountryLV.View = System.Windows.Forms.View.SmallIcon;
            this.CountryLV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.CountryLV_ItemSelectionChanged);
            // 
            // SearchTB
            // 
            this.SearchTB.Location = new System.Drawing.Point(12, 270);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(115, 20);
            this.SearchTB.TabIndex = 7;
            this.SearchTB.TextChanged += new System.EventHandler(this.SearchTB_TextChanged);
            this.SearchTB.Enter += new System.EventHandler(this.SearchTB_Enter);
            this.SearchTB.Leave += new System.EventHandler(this.SearchTB_Leave);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(444, 268);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(116, 23);
            this.SaveBtn.TabIndex = 9;
            this.SaveBtn.Text = "Save Changes";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(363, 268);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 10;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ResetBtn_MouseClick);
            // 
            // RemoveTPBtn
            // 
            this.RemoveTPBtn.Location = new System.Drawing.Point(572, 238);
            this.RemoveTPBtn.Name = "RemoveTPBtn";
            this.RemoveTPBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveTPBtn.TabIndex = 12;
            this.RemoveTPBtn.Text = "Remove";
            this.RemoveTPBtn.UseVisualStyleBackColor = true;
            this.RemoveTPBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RemoveTPBtn_MouseClick);
            // 
            // TradePartnersLB
            // 
            this.TradePartnersLB.FormattingEnabled = true;
            this.TradePartnersLB.Location = new System.Drawing.Point(374, 59);
            this.TradePartnersLB.Name = "TradePartnersLB";
            this.TradePartnersLB.Size = new System.Drawing.Size(116, 95);
            this.TradePartnersLB.Sorted = true;
            this.TradePartnersLB.TabIndex = 11;
            // 
            // TradePartnersLabel
            // 
            this.TradePartnersLabel.AutoSize = true;
            this.TradePartnersLabel.Location = new System.Drawing.Point(318, 56);
            this.TradePartnersLabel.Name = "TradePartnersLabel";
            this.TradePartnersLabel.Size = new System.Drawing.Size(46, 26);
            this.TradePartnersLabel.TabIndex = 10;
            this.TradePartnersLabel.Text = "Trade Partners";
            // 
            // HdiUD
            // 
            this.HdiUD.Location = new System.Drawing.Point(247, 59);
            this.HdiUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HdiUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.HdiUD.Name = "HdiUD";
            this.HdiUD.Size = new System.Drawing.Size(45, 20);
            this.HdiUD.TabIndex = 9;
            // 
            // HDIRankingLabel
            // 
            this.HDIRankingLabel.AutoSize = true;
            this.HDIRankingLabel.Location = new System.Drawing.Point(183, 56);
            this.HDIRankingLabel.Name = "HDIRankingLabel";
            this.HDIRankingLabel.Size = new System.Drawing.Size(47, 26);
            this.HDIRankingLabel.TabIndex = 8;
            this.HDIRankingLabel.Text = "HDI Ranking";
            // 
            // TradeBalanceUD
            // 
            this.TradeBalanceUD.DecimalPlaces = 1;
            this.TradeBalanceUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TradeBalanceUD.Location = new System.Drawing.Point(60, 59);
            this.TradeBalanceUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.TradeBalanceUD.Name = "TradeBalanceUD";
            this.TradeBalanceUD.Size = new System.Drawing.Size(95, 20);
            this.TradeBalanceUD.TabIndex = 7;
            // 
            // TradeBalanceLabel
            // 
            this.TradeBalanceLabel.AutoSize = true;
            this.TradeBalanceLabel.Location = new System.Drawing.Point(3, 56);
            this.TradeBalanceLabel.Name = "TradeBalanceLabel";
            this.TradeBalanceLabel.Size = new System.Drawing.Size(46, 26);
            this.TradeBalanceLabel.TabIndex = 6;
            this.TradeBalanceLabel.Text = "Trade Balance";
            // 
            // InflationUD
            // 
            this.InflationUD.DecimalPlaces = 2;
            this.InflationUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.InflationUD.Location = new System.Drawing.Point(374, 13);
            this.InflationUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.InflationUD.Name = "InflationUD";
            this.InflationUD.Size = new System.Drawing.Size(91, 20);
            this.InflationUD.TabIndex = 5;
            // 
            // InflationLabel
            // 
            this.InflationLabel.AutoSize = true;
            this.InflationLabel.Location = new System.Drawing.Point(318, 10);
            this.InflationLabel.Name = "InflationLabel";
            this.InflationLabel.Size = new System.Drawing.Size(44, 13);
            this.InflationLabel.TabIndex = 4;
            this.InflationLabel.Text = "Inflation";
            // 
            // GDPGrowthUD
            // 
            this.GDPGrowthUD.DecimalPlaces = 1;
            this.GDPGrowthUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.GDPGrowthUD.Location = new System.Drawing.Point(247, 13);
            this.GDPGrowthUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.GDPGrowthUD.Name = "GDPGrowthUD";
            this.GDPGrowthUD.Size = new System.Drawing.Size(45, 20);
            this.GDPGrowthUD.TabIndex = 3;
            // 
            // GDPGrowthLabel
            // 
            this.GDPGrowthLabel.AutoSize = true;
            this.GDPGrowthLabel.Location = new System.Drawing.Point(183, 10);
            this.GDPGrowthLabel.Name = "GDPGrowthLabel";
            this.GDPGrowthLabel.Size = new System.Drawing.Size(41, 26);
            this.GDPGrowthLabel.TabIndex = 2;
            this.GDPGrowthLabel.Text = "GDP Growth";
            // 
            // CountryNameTB
            // 
            this.CountryNameTB.Location = new System.Drawing.Point(60, 13);
            this.CountryNameTB.Name = "CountryNameTB";
            this.CountryNameTB.ReadOnly = true;
            this.CountryNameTB.Size = new System.Drawing.Size(95, 20);
            this.CountryNameTB.TabIndex = 1;
            // 
            // CountryNameLabel
            // 
            this.CountryNameLabel.AutoSize = true;
            this.CountryNameLabel.Location = new System.Drawing.Point(3, 10);
            this.CountryNameLabel.Name = "CountryNameLabel";
            this.CountryNameLabel.Size = new System.Drawing.Size(35, 13);
            this.CountryNameLabel.TabIndex = 0;
            this.CountryNameLabel.Text = "Name";
            this.CountryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CountryInfoPanel
            // 
            this.CountryInfoPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CountryInfoPanel.ColumnCount = 6;
            this.CountryInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.CountryInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.15213F));
            this.CountryInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.18458F));
            this.CountryInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.60446F));
            this.CountryInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.56187F));
            this.CountryInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.54361F));
            this.CountryInfoPanel.Controls.Add(this.CountryNameLabel, 0, 0);
            this.CountryInfoPanel.Controls.Add(this.CountryNameTB, 1, 0);
            this.CountryInfoPanel.Controls.Add(this.GDPGrowthLabel, 2, 0);
            this.CountryInfoPanel.Controls.Add(this.GDPGrowthUD, 3, 0);
            this.CountryInfoPanel.Controls.Add(this.InflationLabel, 4, 0);
            this.CountryInfoPanel.Controls.Add(this.InflationUD, 5, 0);
            this.CountryInfoPanel.Controls.Add(this.TradeBalanceLabel, 0, 1);
            this.CountryInfoPanel.Controls.Add(this.TradeBalanceUD, 1, 1);
            this.CountryInfoPanel.Controls.Add(this.HDIRankingLabel, 2, 1);
            this.CountryInfoPanel.Controls.Add(this.HdiUD, 3, 1);
            this.CountryInfoPanel.Controls.Add(this.TradePartnersLabel, 4, 1);
            this.CountryInfoPanel.Controls.Add(this.TradePartnersLB, 5, 1);
            this.CountryInfoPanel.Location = new System.Drawing.Point(154, 52);
            this.CountryInfoPanel.Name = "CountryInfoPanel";
            this.CountryInfoPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.CountryInfoPanel.RowCount = 2;
            this.CountryInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.26316F));
            this.CountryInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.73684F));
            this.CountryInfoPanel.Size = new System.Drawing.Size(493, 162);
            this.CountryInfoPanel.TabIndex = 8;
            // 
            // RmvCountryBtn
            // 
            this.RmvCountryBtn.Location = new System.Drawing.Point(235, 268);
            this.RmvCountryBtn.Name = "RmvCountryBtn";
            this.RmvCountryBtn.Size = new System.Drawing.Size(122, 23);
            this.RmvCountryBtn.TabIndex = 13;
            this.RmvCountryBtn.Text = "Remove Country";
            this.RmvCountryBtn.UseVisualStyleBackColor = true;
            this.RmvCountryBtn.Click += new System.EventHandler(this.RmvCountryBtn_Click);
            // 
            // AddTradePartnerTB
            // 
            this.AddTradePartnerTB.Location = new System.Drawing.Point(528, 212);
            this.AddTradePartnerTB.Name = "AddTradePartnerTB";
            this.AddTradePartnerTB.Size = new System.Drawing.Size(116, 20);
            this.AddTradePartnerTB.TabIndex = 14;
            this.AddTradePartnerTB.Enter += new System.EventHandler(this.AddTradePartnerTB_Enter);
            this.AddTradePartnerTB.Leave += new System.EventHandler(this.AddTradePartnerTB_Leave);
            // 
            // AddTPBtn
            // 
            this.AddTPBtn.Location = new System.Drawing.Point(491, 238);
            this.AddTPBtn.Name = "AddTPBtn";
            this.AddTPBtn.Size = new System.Drawing.Size(75, 23);
            this.AddTPBtn.TabIndex = 15;
            this.AddTPBtn.Text = "Add";
            this.AddTPBtn.UseVisualStyleBackColor = true;
            this.AddTPBtn.Click += new System.EventHandler(this.AddTPBtn_Click);
            // 
            // AddCountryBtn
            // 
            this.AddCountryBtn.Location = new System.Drawing.Point(154, 268);
            this.AddCountryBtn.Name = "AddCountryBtn";
            this.AddCountryBtn.Size = new System.Drawing.Size(75, 23);
            this.AddCountryBtn.TabIndex = 16;
            this.AddCountryBtn.Text = "Add Country";
            this.AddCountryBtn.UseVisualStyleBackColor = true;
            this.AddCountryBtn.Click += new System.EventHandler(this.AddCountryBtn_Click);
            // 
            // TradingDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 303);
            this.Controls.Add(this.AddCountryBtn);
            this.Controls.Add(this.AddTPBtn);
            this.Controls.Add(this.AddTradePartnerTB);
            this.Controls.Add(this.RmvCountryBtn);
            this.Controls.Add(this.RemoveTPBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CountryInfoPanel);
            this.Controls.Add(this.SearchTB);
            this.Controls.Add(this.CountryLV);
            this.Controls.Add(this.CountryInfoLabel);
            this.Controls.Add(this.CountryTreeViewLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TradingDataForm";
            this.Text = "International Trading Data";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HdiUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeBalanceUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InflationUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GDPGrowthUD)).EndInit();
            this.CountryInfoPanel.ResumeLayout(false);
            this.CountryInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CountryTreeViewLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label CountryInfoLabel;
        private System.Windows.Forms.ListView CountryLV;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button RemoveTPBtn;
        private System.Windows.Forms.ListBox TradePartnersLB;
        private System.Windows.Forms.Label TradePartnersLabel;
        private System.Windows.Forms.NumericUpDown HdiUD;
        private System.Windows.Forms.Label HDIRankingLabel;
        private System.Windows.Forms.NumericUpDown TradeBalanceUD;
        private System.Windows.Forms.Label TradeBalanceLabel;
        private System.Windows.Forms.NumericUpDown InflationUD;
        private System.Windows.Forms.Label InflationLabel;
        private System.Windows.Forms.NumericUpDown GDPGrowthUD;
        private System.Windows.Forms.Label GDPGrowthLabel;
        private System.Windows.Forms.TextBox CountryNameTB;
        private System.Windows.Forms.Label CountryNameLabel;
        private System.Windows.Forms.TableLayoutPanel CountryInfoPanel;
        private System.Windows.Forms.Button RmvCountryBtn;
        private System.Windows.Forms.TextBox AddTradePartnerTB;
        private System.Windows.Forms.Button AddTPBtn;
        private System.Windows.Forms.Button AddCountryBtn;
    }
}

