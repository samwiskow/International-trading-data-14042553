using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTreeStructure.Country
{
    public class Country : IComparable
    {
        private string name;
        private double GDPgrowth;
        private double inflation;
        private double tradeBalance;
        private int HDIranking;
        private LinkedList<String> tradePartners;

        public Country(string name, double gdp, double inflation, double balance, int hdi, LinkedList<string> tradePartners)
        {
            this.name = name;
            this.GDPgrowth = gdp;
            this.inflation = inflation;
            this.tradeBalance = balance;
            this.HDIranking = hdi;
            this.tradePartners = tradePartners;

        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double gdpGrowth
        {
            get { return this.GDPgrowth; }
            set { this.GDPgrowth = value; }
        }

        public double Inflation
        {
            get { return this.inflation; }
            set { this.inflation = value; }
        }

        public double TradeBalance
        {
            get { return this.tradeBalance; }
            set { this.tradeBalance = value; }
        }

        public int hdiRanking
        {
            get { return this.HDIranking; }
            set { this.HDIranking = value; }
        }

        public LinkedList<String> TradePartners
        {
            get { return this.tradePartners; }
            set { this.tradePartners = value; }
        }

        public int CompareTo(object obj)
        {
            Country temp = (Country)obj;
            return this.name.CompareTo(temp.name);
        }
    }
}
