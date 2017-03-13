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
    public partial class TreeInfoForm : Form
    {
        public TreeInfoForm(TradingDataForm form)
        {
            InitializeComponent();
            TreeCountTB.Text = form.getCount().ToString();
            TreeHeightTB.Text = form.getHeight().ToString();
            TradePotentialTB.Text = form.GetBestTradePotential();
        }
    }
}
