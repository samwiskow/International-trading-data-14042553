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
        string buffer = "";

        public TradingDataForm()
        {
            csvRead.readCsvIn();
            csvRead.FileContent.ForEach(item => CTree.InsertItem(item));
            InitializeComponent();
            csvRead.FileContent.ForEach(item => CreateListViewItem(CountryLV, item));
            CTree.InOrder(ref buffer);
        }

        public static void CreateListViewItem(ListView listView, Country obj)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = obj;
            item.Text = obj.Name;

            // Other requirements as needed

            listView.Items.Add(item);
        }

        private void CountryLV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Console.WriteLine(e.Item.Text);
            Country country = (Country)e.Item.Tag;
        }
    }
}
