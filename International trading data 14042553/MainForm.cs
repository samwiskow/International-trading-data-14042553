using AVLTreeStructure.Country;
using FileReaderUtility;
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
    public partial class TradingDataForm : Form
    {
        CountryTree CTree = new CountryTree();
        CsvReader csvRead = new CsvReader();
        List<Country> Buffer = new List<Country>();

        public TradingDataForm()
        {
            csvRead.readCsvIn();
            csvRead.FileContent.ForEach(item => CTree.InsertItem(item));
            InitializeComponent();
            SearchTB.Text = "Search countries...";
            AddTradePartnerTB.Text = "Add Trade Partner...";
            populateListView("");
        }

        public static void CreateListViewItem(ListView listView, Country obj)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = obj;
            item.Text = obj.Name;
            listView.Items.Add(item);
        }

        private void CountryLV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            GetCountryInfo(e.Item.Text);
        }

        public void populateListView(string name)
        {
            CountryLV.Items.Clear();
            Buffer = new List<Country>();
            CTree.GetNodesLike(name, ref Buffer);
            Buffer.ForEach(item => CreateListViewItem(CountryLV, item));
        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            populateListView(SearchTB.Text);
        }

        private void SearchTB_Enter(object sender, EventArgs e)
        {
            SearchTB.Text = "";
        }

        private void SearchTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTB.Text))
                SearchTB.Text = "Search countries...";
        }

        private void GetCountryInfo(string name)
        {
            Country country = CTree.GetNodeByName(name);
            CountryNameTB.Text = country.Name;
            GDPGrowthUD.Value = (decimal)country.gdpGrowth;
            InflationUD.Value = (decimal)country.Inflation;
            TradeBalanceUD.Value = (decimal)country.TradeBalance;
            HdiUD.Value = (decimal)country.hdiRanking;
            TradePartnersLB.Items.Clear();
            foreach (string partner in country.TradePartners)
            {
                TradePartnersLB.Items.Add(partner);
            }
        }

        private void RemoveTPBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (TradePartnersLB.SelectedIndex >= 0)
            {
                TradePartnersLB.Items.RemoveAt(TradePartnersLB.SelectedIndex);
            }
            else if (TradePartnersLB.SelectedIndex == -1 && TradePartnersLB.Items.Count != 0)
            {
                    TradePartnersLB.Items.RemoveAt(0);
            }
            else if (TradePartnersLB.Items.Count == 0)
            {
                MessageBox.Show("No partners to remove", "Error", MessageBoxButtons.OK);
            }
        }

        private void ResetBtn_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                GetCountryInfo(CountryNameTB.Text);
            }
            catch(Exception ex)
            {
                Trace.WriteLine("Country not found: " + ex);
                if(CountryNameTB.Text == "")
                {
                    MessageBox.Show("Please select a country first", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Country does not exist", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SetCountryInfo(CountryNameTB.Text);
                MessageBox.Show("Country details saved successfully!", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
                MessageBox.Show("Could not save country details", "Error", MessageBoxButtons.OK);
            }
        }

        private void SetCountryInfo(string name)
        {
            Country country = CTree.GetNodeByName(name);
            country.Name = CountryNameTB.Text;
            country.gdpGrowth = (double)GDPGrowthUD.Value;
            country.Inflation = (double)InflationUD.Value;
            country.TradeBalance = (double)TradeBalanceUD.Value;
            country.hdiRanking = (int)HdiUD.Value;
            country.TradePartners.Clear();
                
            foreach (string partner in TradePartnersLB.Items)
            {
                country.TradePartners.AddLast(partner);
            }
        }

        private void RmvCountryBtn_Click(object sender, EventArgs e)
        {
            if (CountryNameTB.Text.Length > 0)
            {
                try
                {
                    CTree.RemoveItem(CountryNameTB.Text);
                    populateListView("");
                    if (CountryLV.Items.Count > 0)
                    {
                        GetCountryInfo(CountryLV.Items[0].Text);
                    }
                    else
                    {
                        resetCountryInfoFields();
                    }
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex);
                    MessageBox.Show("Could not remove selected country", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please select a country first", "Error", MessageBoxButtons.OK);
            }
        }

        private void resetCountryInfoFields()
        {
            CountryNameTB.Text = "";
            GDPGrowthUD.Value = 0;
            TradeBalanceUD.Value = 0;
            TradePartnersLB.Items.Clear();
            InflationUD.Value = 0;
            HdiUD.Value = 0;
        }

        private void AddTPBtn_Click(object sender, EventArgs e)
        {
            if (CountryNameTB.Text.Length > 0)
            {
                if (AddTradePartnerTB.Text != "Add Trade Partner...")
                {
                    if (AddTradePartnerTB.Text.Length > 0)
                    {
                        try
                        {
                            TradePartnersLB.Items.Add(AddTradePartnerTB.Text);
                            AddTradePartnerTB.Text = "";
                        }
                        catch (Exception ex)
                        {
                            Trace.WriteLine(ex);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid trade partner", "Warning", MessageBoxButtons.OK);
                }
                
            }
            else
            {
                MessageBox.Show("Please select a country first!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void AddTradePartnerTB_Enter(object sender, EventArgs e)
        {
            AddTradePartnerTB.Text = "";
        }

        private void AddTradePartnerTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddTradePartnerTB.Text))
                AddTradePartnerTB.Text = "Add Trade Partner...";
        }

        private void AddCountryBtn_Click(object sender, EventArgs e)
        {
            //Open new form here
            AddCountryForm addCountry = new AddCountryForm(this);
            addCountry.Show();
        }

        public void AddCountry(Country C)
        {
            CTree.InsertItem(C);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int getHeight()
        {
            return CTree.Height();
        }

        public int getCount()
        {
            return CTree.Count();
        }

        private void treeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeInfoForm TreeInfoForm = new TreeInfoForm(this);
            TreeInfoForm.Show();
        }
    }
}
