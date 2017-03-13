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
        CSVWriter csvWrite = new CSVWriter();
        List<Country> Buffer = new List<Country>();

        // Constructor
        // Reads the csv file and populates a Tree for the application to use
        // Also sets placeholders for the search and add trade partner textboxes
        // Populates the listview with country names
        public TradingDataForm()
        {
            csvRead.readCsvIn();
            csvRead.FileContent.ForEach(item => CTree.InsertItem(item));
            InitializeComponent();
            SearchTB.Text = "Search countries...";
            AddTradePartnerTB.Text = "Add Trade Partner...";
            populateListView("");
        }

        // creates a listview item fom the country object - Tag is to access the original object
        public static void CreateListViewItem(ListView listView, Country obj)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = obj;
            item.Text = obj.Name;
            listView.Items.Add(item);
        }

        // When the user selects a different item on the list view the relevant country info is displayed
        private void CountryLV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            GetCountryInfo(e.Item.Text);
        }

        // This function populates the listview
        public void populateListView(string name)
        {
            CountryLV.Items.Clear();
            Buffer = new List<Country>();
            CTree.GetNodesLike(name, ref Buffer);
            Buffer.ForEach(item => CreateListViewItem(CountryLV, item));
        }

        // resposible for the partial keyword search
        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            populateListView(SearchTB.Text);
        }

        // Placeholder function - removes placeholder on focus 
        private void SearchTB_Enter(object sender, EventArgs e)
        {
            SearchTB.Text = "";
        }

        // Placeholder function - adds placeholder when not focused
        private void SearchTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTB.Text))
                SearchTB.Text = "Search countries...";
        }

       // Gets individual country info
        private void GetCountryInfo(string name)
        {
            Country country = CTree.GetNodeByName(name);
            if (country != null)
            {
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
        }

        // Removes selected Trade partner
        // If no trade partner selected, removes the top one
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

        // resets any changes on the currently selected company
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

        // Saves the changes made to the current country to the tree
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

        // Function that actually saves the currently displayed information to the country (Node) in the tree
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

        // Removes the selected country from the tree
        private void RmvCountryBtn_Click(object sender, EventArgs e)
        {
            if (CountryNameTB.Text.Length > 0)
            {
                try
                {
                    CTree.RemoveItem(CTree.GetNodeByName(CountryNameTB.Text));
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

        // Resets all the info fields to default
        private void resetCountryInfoFields()
        {
            CountryNameTB.Text = "";
            GDPGrowthUD.Value = 0;
            TradeBalanceUD.Value = 0;
            TradePartnersLB.Items.Clear();
            InflationUD.Value = 0;
            HdiUD.Value = 0;
        }

        // Adds a trade partner to the currently selected country
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

        // Placeholder function - removes placeholder on focus 
        private void AddTradePartnerTB_Enter(object sender, EventArgs e)
        {
            AddTradePartnerTB.Text = "";
        }

        // Placeholder function - adds placeholder back when not focused
        private void AddTradePartnerTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddTradePartnerTB.Text))
                AddTradePartnerTB.Text = "Add Trade Partner...";
        }

        // opens a new form so that the user can add a country
        private void AddCountryBtn_Click(object sender, EventArgs e)
        {
            //Open new form here
            AddCountryForm addCountry = new AddCountryForm(this);
            addCountry.Show();
        }

        // public method so that the add country form can add a country easily
        public void AddCountry(Country C)
        {
            CTree.InsertItem(C);
        }

        // exits the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Returns the height of the tree - public so that it can be accesed by another form
        public int getHeight()
        {
            return CTree.Height();
        }

        // Returns how many nodes are in the tree - public so that it can be accesed by another form
        public int getCount()
        {
            return CTree.Count();
        }

        // opens a new form that displays information about the tree
        private void treeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeInfoForm TreeInfoForm = new TreeInfoForm(this);
            TreeInfoForm.Show();
        }

        // Returns the country with the best in the tree - public so that it can be accesed by another form
        public string GetBestTradePotential()
        {
            string country = "";
            CTree.CalculateBestTradePotential(ref country);
            return country;
        }

        // Writes the tree currently displayed to a csv file
        // can be found at ..\International trading data 14042553\International trading data 14042553\bin\Debug\countriesUpdated.csv
        // Deliberately chosen to create a new file instead of modifying the existing one so as not to interfere with marking
        private void exportTreeToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool success = csvWrite.write(Buffer);

            if (success)
            {
                MessageBox.Show("Data Successfully written to CSV", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Data could not be written to CSV", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
