namespace International_trading_data_14042553
{
    partial class AddCountryForm
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
            this.CountryNameLabel = new System.Windows.Forms.Label();
            this.GdpGrowthLabel = new System.Windows.Forms.Label();
            this.InflationLabel = new System.Windows.Forms.Label();
            this.TradeBalanceLabel = new System.Windows.Forms.Label();
            this.HdiRankingLabel = new System.Windows.Forms.Label();
            this.TradePartnersLabel = new System.Windows.Forms.Label();
            this.CountryNameTB = new System.Windows.Forms.TextBox();
            this.GdpUD = new System.Windows.Forms.NumericUpDown();
            this.InflationUD = new System.Windows.Forms.NumericUpDown();
            this.TradeBalanceUD = new System.Windows.Forms.NumericUpDown();
            this.HdiUD = new System.Windows.Forms.NumericUpDown();
            this.TradePartnersLB = new System.Windows.Forms.ListBox();
            this.AddTPTB = new System.Windows.Forms.TextBox();
            this.AddTPBtn = new System.Windows.Forms.Button();
            this.RemoveTPBtn = new System.Windows.Forms.Button();
            this.AddCountryBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GdpUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InflationUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeBalanceUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HdiUD)).BeginInit();
            this.SuspendLayout();
            // 
            // CountryNameLabel
            // 
            this.CountryNameLabel.AutoSize = true;
            this.CountryNameLabel.Location = new System.Drawing.Point(12, 18);
            this.CountryNameLabel.Name = "CountryNameLabel";
            this.CountryNameLabel.Size = new System.Drawing.Size(35, 13);
            this.CountryNameLabel.TabIndex = 0;
            this.CountryNameLabel.Text = "Name";
            // 
            // GdpGrowthLabel
            // 
            this.GdpGrowthLabel.AutoSize = true;
            this.GdpGrowthLabel.Location = new System.Drawing.Point(12, 43);
            this.GdpGrowthLabel.Name = "GdpGrowthLabel";
            this.GdpGrowthLabel.Size = new System.Drawing.Size(67, 13);
            this.GdpGrowthLabel.TabIndex = 1;
            this.GdpGrowthLabel.Text = "GDP Growth";
            // 
            // InflationLabel
            // 
            this.InflationLabel.AutoSize = true;
            this.InflationLabel.Location = new System.Drawing.Point(12, 73);
            this.InflationLabel.Name = "InflationLabel";
            this.InflationLabel.Size = new System.Drawing.Size(44, 13);
            this.InflationLabel.TabIndex = 2;
            this.InflationLabel.Text = "Inflation";
            // 
            // TradeBalanceLabel
            // 
            this.TradeBalanceLabel.AutoSize = true;
            this.TradeBalanceLabel.Location = new System.Drawing.Point(12, 99);
            this.TradeBalanceLabel.Name = "TradeBalanceLabel";
            this.TradeBalanceLabel.Size = new System.Drawing.Size(77, 13);
            this.TradeBalanceLabel.TabIndex = 3;
            this.TradeBalanceLabel.Text = "Trade Balance";
            // 
            // HdiRankingLabel
            // 
            this.HdiRankingLabel.AutoSize = true;
            this.HdiRankingLabel.Location = new System.Drawing.Point(12, 127);
            this.HdiRankingLabel.Name = "HdiRankingLabel";
            this.HdiRankingLabel.Size = new System.Drawing.Size(69, 13);
            this.HdiRankingLabel.TabIndex = 4;
            this.HdiRankingLabel.Text = "HDI Ranking";
            // 
            // TradePartnersLabel
            // 
            this.TradePartnersLabel.AutoSize = true;
            this.TradePartnersLabel.Location = new System.Drawing.Point(12, 154);
            this.TradePartnersLabel.Name = "TradePartnersLabel";
            this.TradePartnersLabel.Size = new System.Drawing.Size(77, 13);
            this.TradePartnersLabel.TabIndex = 5;
            this.TradePartnersLabel.Text = "Trade Partners";
            // 
            // CountryNameTB
            // 
            this.CountryNameTB.Location = new System.Drawing.Point(123, 15);
            this.CountryNameTB.Name = "CountryNameTB";
            this.CountryNameTB.Size = new System.Drawing.Size(100, 20);
            this.CountryNameTB.TabIndex = 6;
            // 
            // GdpUD
            // 
            this.GdpUD.DecimalPlaces = 1;
            this.GdpUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.GdpUD.Location = new System.Drawing.Point(123, 41);
            this.GdpUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.GdpUD.Name = "GdpUD";
            this.GdpUD.Size = new System.Drawing.Size(47, 20);
            this.GdpUD.TabIndex = 7;
            // 
            // InflationUD
            // 
            this.InflationUD.DecimalPlaces = 1;
            this.InflationUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.InflationUD.Location = new System.Drawing.Point(123, 71);
            this.InflationUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.InflationUD.Name = "InflationUD";
            this.InflationUD.Size = new System.Drawing.Size(47, 20);
            this.InflationUD.TabIndex = 8;
            // 
            // TradeBalanceUD
            // 
            this.TradeBalanceUD.DecimalPlaces = 1;
            this.TradeBalanceUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TradeBalanceUD.Location = new System.Drawing.Point(123, 97);
            this.TradeBalanceUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.TradeBalanceUD.Name = "TradeBalanceUD";
            this.TradeBalanceUD.Size = new System.Drawing.Size(47, 20);
            this.TradeBalanceUD.TabIndex = 9;
            // 
            // HdiUD
            // 
            this.HdiUD.Location = new System.Drawing.Point(123, 125);
            this.HdiUD.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.HdiUD.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.HdiUD.Name = "HdiUD";
            this.HdiUD.Size = new System.Drawing.Size(47, 20);
            this.HdiUD.TabIndex = 10;
            // 
            // TradePartnersLB
            // 
            this.TradePartnersLB.FormattingEnabled = true;
            this.TradePartnersLB.Location = new System.Drawing.Point(123, 157);
            this.TradePartnersLB.Name = "TradePartnersLB";
            this.TradePartnersLB.Size = new System.Drawing.Size(100, 56);
            this.TradePartnersLB.Sorted = true;
            this.TradePartnersLB.TabIndex = 11;
            // 
            // AddTPTB
            // 
            this.AddTPTB.Location = new System.Drawing.Point(123, 219);
            this.AddTPTB.Name = "AddTPTB";
            this.AddTPTB.Size = new System.Drawing.Size(100, 20);
            this.AddTPTB.TabIndex = 12;
            this.AddTPTB.Enter += new System.EventHandler(this.AddTPTB_Enter);
            this.AddTPTB.Leave += new System.EventHandler(this.AddTPTB_Leave);
            // 
            // AddTPBtn
            // 
            this.AddTPBtn.Location = new System.Drawing.Point(95, 245);
            this.AddTPBtn.Name = "AddTPBtn";
            this.AddTPBtn.Size = new System.Drawing.Size(75, 23);
            this.AddTPBtn.TabIndex = 13;
            this.AddTPBtn.Text = "Add";
            this.AddTPBtn.UseVisualStyleBackColor = true;
            this.AddTPBtn.Click += new System.EventHandler(this.AddTPBtn_Click);
            // 
            // RemoveTPBtn
            // 
            this.RemoveTPBtn.Location = new System.Drawing.Point(176, 245);
            this.RemoveTPBtn.Name = "RemoveTPBtn";
            this.RemoveTPBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveTPBtn.TabIndex = 14;
            this.RemoveTPBtn.Text = "Remove";
            this.RemoveTPBtn.UseVisualStyleBackColor = true;
            this.RemoveTPBtn.Click += new System.EventHandler(this.RemoveTPBtn_Click);
            // 
            // AddCountryBtn
            // 
            this.AddCountryBtn.Location = new System.Drawing.Point(116, 282);
            this.AddCountryBtn.Name = "AddCountryBtn";
            this.AddCountryBtn.Size = new System.Drawing.Size(75, 23);
            this.AddCountryBtn.TabIndex = 15;
            this.AddCountryBtn.Text = "Add Country";
            this.AddCountryBtn.UseVisualStyleBackColor = true;
            this.AddCountryBtn.Click += new System.EventHandler(this.AddCountryBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(197, 282);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 317);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddCountryBtn);
            this.Controls.Add(this.RemoveTPBtn);
            this.Controls.Add(this.AddTPBtn);
            this.Controls.Add(this.AddTPTB);
            this.Controls.Add(this.TradePartnersLB);
            this.Controls.Add(this.HdiUD);
            this.Controls.Add(this.TradeBalanceUD);
            this.Controls.Add(this.InflationUD);
            this.Controls.Add(this.GdpUD);
            this.Controls.Add(this.CountryNameTB);
            this.Controls.Add(this.TradePartnersLabel);
            this.Controls.Add(this.HdiRankingLabel);
            this.Controls.Add(this.TradeBalanceLabel);
            this.Controls.Add(this.InflationLabel);
            this.Controls.Add(this.GdpGrowthLabel);
            this.Controls.Add(this.CountryNameLabel);
            this.Name = "AddCountryForm";
            this.Text = "New Country";
            ((System.ComponentModel.ISupportInitialize)(this.GdpUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InflationUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeBalanceUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HdiUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CountryNameLabel;
        private System.Windows.Forms.Label GdpGrowthLabel;
        private System.Windows.Forms.Label InflationLabel;
        private System.Windows.Forms.Label TradeBalanceLabel;
        private System.Windows.Forms.Label HdiRankingLabel;
        private System.Windows.Forms.Label TradePartnersLabel;
        private System.Windows.Forms.TextBox CountryNameTB;
        private System.Windows.Forms.NumericUpDown GdpUD;
        private System.Windows.Forms.NumericUpDown InflationUD;
        private System.Windows.Forms.NumericUpDown TradeBalanceUD;
        private System.Windows.Forms.NumericUpDown HdiUD;
        private System.Windows.Forms.ListBox TradePartnersLB;
        private System.Windows.Forms.TextBox AddTPTB;
        private System.Windows.Forms.Button AddTPBtn;
        private System.Windows.Forms.Button RemoveTPBtn;
        private System.Windows.Forms.Button AddCountryBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}