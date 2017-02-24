using AVLTreeStructure.Country;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderUtility
{
    public class CsvReader
    {
        static string[] headers = new string[6]; //column headers
        const int MAX_LINES_FILE = 50000;
        private string[] AllLines = new string[MAX_LINES_FILE];
        // some sort of array to hold all the csv informaion
        private List<Country> countryList = new List<Country>();

        public CsvReader()
        {
        }

        public string[] Headers
        {
            get { return headers; }
            set { headers = value; }
        }

        public List<Country> FileContent
        {
            get { return this.countryList; }
            set { this.countryList = value; }
        }


        public void readCsvIn()
        {
            AllLines = File.ReadAllLines("countries.csv");

            foreach (string line in AllLines)
            {
                if (line.StartsWith("Country"))
                {
                    headers = line.Split(',');
                }
                else
                {
                    string[] row = line.Split(',');
                    string[] partners = row[5].Split(';', '[', ']');
                    LinkedList<string> tradePartners = new LinkedList<string>();

                    foreach (string traders in partners)
                    {
                        if (traders != "")
                        {
                            //Console.Write(" tradepartner: " + traders);
                            tradePartners.AddLast(traders);
                        }
                    }
                    countryList.Add(new Country(row[0], Convert.ToDouble(row[1]), Convert.ToDouble(row[2]), Convert.ToDouble(row[3]), Convert.ToInt32(row[4]), tradePartners));
                }
            }
        }
    }
}
