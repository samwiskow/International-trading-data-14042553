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
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountryInfoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CountryInfoLabel = new System.Windows.Forms.Label();
            this.CountryLV = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
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
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.countryToolStripMenuItem.Text = "Country";
            // 
            // CountryInfoPanel
            // 
            this.CountryInfoPanel.Location = new System.Drawing.Point(331, 52);
            this.CountryInfoPanel.Name = "CountryInfoPanel";
            this.CountryInfoPanel.Size = new System.Drawing.Size(615, 302);
            this.CountryInfoPanel.TabIndex = 4;
            // 
            // CountryInfoLabel
            // 
            this.CountryInfoLabel.AutoSize = true;
            this.CountryInfoLabel.Location = new System.Drawing.Point(328, 36);
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
            this.CountryLV.Size = new System.Drawing.Size(115, 302);
            this.CountryLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.CountryLV.TabIndex = 6;
            this.CountryLV.UseCompatibleStateImageBehavior = false;
            this.CountryLV.View = System.Windows.Forms.View.SmallIcon;
            this.CountryLV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.CountryLV_ItemSelectionChanged);
            // 
            // TradingDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 633);
            this.Controls.Add(this.CountryLV);
            this.Controls.Add(this.CountryInfoLabel);
            this.Controls.Add(this.CountryInfoPanel);
            this.Controls.Add(this.CountryTreeViewLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TradingDataForm";
            this.Text = "International Trading Data";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CountryTreeViewLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel CountryInfoPanel;
        private System.Windows.Forms.Label CountryInfoLabel;
        private System.Windows.Forms.ListView CountryLV;
    }
}

