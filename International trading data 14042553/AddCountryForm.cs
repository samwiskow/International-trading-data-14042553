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
        // pass in an instance of the main form to access all required methods

        public AddCountryForm(TradingDataForm form)
        {
            InitializeComponent();
            AddTPTB.Text = "Add Trade Partner...";
            this.MainForm = form;
        }

        // Adds a trade partner to the country
        private void AddTPBtn_Click(object sender, EventArgs e)
        {
            if (AddTPTB.Text.Length > 0)
            {
                if (AddTPTB.Text != "Add Trade Partner...")
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
                else
                {
                    MessageBox.Show("Please enter a valid trade partner", "Warning", MessageBoxButtons.OK);
                }
            }
        }

        // Removes either top trade partner in the list or selected trade partner
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

        // placeholder text
        private void AddTPTB_Enter(object sender, EventArgs e)
        {
            AddTPTB.Text = "";
        }
        // Placeholder text
        private void AddTPTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddTPTB.Text))
                AddTPTB.Text = "Add Trade Partner...";
        }

        //Closes the form
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Adds the Country to the tree
        private void AddCountryBtn_Click(object sender, EventArgs e)
        {
            bool errors = CountryNameTB.Text.Length == 0;
            Trace.WriteLine(errors);
            if (!errors){
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
            else
            {
                MessageBox.Show("Please enter a valid country name!", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
