using AVLTreeStructure.Country;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace International_trading_data_14042553
{
    public partial class AddCountryForm : Form
    {
        TradingDataForm MainForm;
        public AddCountryForm(TradingDataForm form)
        {
            InitializeComponent();
            AddTPTB.Text = "Add Trade Partner...";
            this.MainForm = form;
        }

        private void AddTPBtn_Click(object sender, EventArgs e)
        {
            if (AddTPTB.Text.Length > 0)
            {
                try
                {
                    TradePartnersLB.Items.Add(AddTPTB.Text);
                    AddTPTB.Text = "";
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex);
                }
            }
        }

        private void RemoveTPBtn_Click(object sender, EventArgs e)
        {
            if(TradePartnersLB.Items.Count > 0)
            {
                if(TradePartnersLB.SelectedIndex > 0)
                {
                    TradePartnersLB.Items.RemoveAt(TradePartnersLB.SelectedIndex);
                }
                else
                {
                    TradePartnersLB.Items.RemoveAt(0);
                }
            }
            else
            {
                MessageBox.Show("No Trade Partners to remove!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void AddTPTB_Enter(object sender, EventArgs e)
        {
            AddTPTB.Text = "";
        }

        private void AddTPTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddTPTB.Text))
                AddTPTB.Text = "Add Trade Partner...";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCountryBtn_Click(object sender, EventArgs e)
        {
            // Create country object and add it to the tree
            // TODO: valdation of this
            LinkedList<string> TP = new LinkedList<string>();
            foreach (string partner in TradePartnersLB.Items)
            {
                TP.AddLast(partner);
            }
            Country country = new Country(CountryNameTB.Text, (double)GdpUD.Value, (double)InflationUD.Value, (double)TradeBalanceUD.Value, (int)HdiUD.Value, TP);
            MainForm.AddCountry(country);
            MainForm.populateListView("");
            this.Close();
        }
    }
}
