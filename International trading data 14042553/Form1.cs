using AVLTreeStructure.Country;
using FileReaderUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        string SearchUsing = "";

        public TradingDataForm()
        {
            csvRead.readCsvIn();
            csvRead.FileContent.ForEach(item => CTree.InsertItem(item));
            InitializeComponent();
            populateListView(SearchUsing);
            //csvRead.FileContent.ForEach(item => CreateListViewItem(CountryLV, item));
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
            Console.WriteLine(e.Item.Text);
            Country country = (Country)e.Item.Tag;
        }

        private void populateListView(string name)
        {
            //write some stuff here that goes through the tree and checks
            CountryLV.Items.Clear();
            Buffer = new List<Country>();
            CTree.GetNodesLike(name, ref Buffer);
            Buffer.ForEach(item => CreateListViewItem(CountryLV, item));
        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            populateListView(SearchTB.Text.ToLower());
        }
    }
}
