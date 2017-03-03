namespace International_trading_data_14042553
{
    partial class TreeInfoForm
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
            this.CountLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.TreeCountTB = new System.Windows.Forms.TextBox();
            this.TreeHeightTB = new System.Windows.Forms.TextBox();
            this.TradePotentialLabel = new System.Windows.Forms.Label();
            this.TradePotentialTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(12, 24);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(83, 13);
            this.CountLabel.TabIndex = 0;
            this.CountLabel.Text = "Countries in tree";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(12, 61);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(63, 13);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "Tree Height";
            // 
            // TreeCountTB
            // 
            this.TreeCountTB.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TreeCountTB.ForeColor = System.Drawing.SystemColors.Info;
            this.TreeCountTB.Location = new System.Drawing.Point(137, 21);
            this.TreeCountTB.Name = "TreeCountTB";
            this.TreeCountTB.ReadOnly = true;
            this.TreeCountTB.Size = new System.Drawing.Size(50, 20);
            this.TreeCountTB.TabIndex = 2;
            this.TreeCountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TreeHeightTB
            // 
            this.TreeHeightTB.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TreeHeightTB.ForeColor = System.Drawing.SystemColors.Info;
            this.TreeHeightTB.Location = new System.Drawing.Point(137, 58);
            this.TreeHeightTB.Name = "TreeHeightTB";
            this.TreeHeightTB.ReadOnly = true;
            this.TreeHeightTB.Size = new System.Drawing.Size(50, 20);
            this.TreeHeightTB.TabIndex = 3;
            this.TreeHeightTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TradePotentialLabel
            // 
            this.TradePotentialLabel.AutoSize = true;
            this.TradePotentialLabel.Location = new System.Drawing.Point(12, 99);
            this.TradePotentialLabel.Name = "TradePotentialLabel";
            this.TradePotentialLabel.Size = new System.Drawing.Size(103, 13);
            this.TradePotentialLabel.TabIndex = 4;
            this.TradePotentialLabel.Text = "Best Trade Potential";
            // 
            // TradePotentialTB
            // 
            this.TradePotentialTB.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TradePotentialTB.ForeColor = System.Drawing.SystemColors.Info;
            this.TradePotentialTB.Location = new System.Drawing.Point(137, 96);
            this.TradePotentialTB.Name = "TradePotentialTB";
            this.TradePotentialTB.ReadOnly = true;
            this.TradePotentialTB.Size = new System.Drawing.Size(77, 20);
            this.TradePotentialTB.TabIndex = 5;
            // 
            // TreeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 156);
            this.Controls.Add(this.TradePotentialTB);
            this.Controls.Add(this.TradePotentialLabel);
            this.Controls.Add(this.TreeHeightTB);
            this.Controls.Add(this.TreeCountTB);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.CountLabel);
            this.Name = "TreeInfoForm";
            this.Text = "Tree Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox TreeCountTB;
        private System.Windows.Forms.TextBox TreeHeightTB;
        private System.Windows.Forms.Label TradePotentialLabel;
        private System.Windows.Forms.TextBox TradePotentialTB;
    }
}