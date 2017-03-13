using AVLTreeStructure;
using AVLTreeStructure.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderUtility
{
    public class CSVWriter
    {
                
        public bool write(List<Country> countryList)
        {

            // Try to open the file and write to it
            try
            {

                // Open the file
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("countriesUpdated.csv"))
                {
                    // Write the headers
                    file.WriteLine("Country,GDP growth,Inflation,Trade Balance,HDI Ranking,Main Trade Partners");

                    // Write each line in turn
                    foreach (Country country in countryList)
                    {

                        // Create a string to contain the information
                        string line = null;

                        // Set up the parameters for the trade partners
                        string partners = null;
                        string last = null;

                        if (country.TradePartners.Count > 0)
                            last = country.TradePartners.Last();

                        // Add the trade partners to the string, separated by a semicolon
                        foreach (string partner in country.TradePartners)
                        {
                            partners += partner;
                            if (partner.CompareTo(last) != 0)
                                partners += ";";
                        }

                        // Create the line and write it to the file
                        line = country.Name.ToString() + "," + country.gdpGrowth.ToString() + "," + country.Inflation.ToString() 
                            + "," + country.TradeBalance.ToString() + ","  + country.hdiRanking.ToString() + ",[" + partners + "]";
                        file.WriteLine(line);
                    }
                }
                // Tell the user it was successful
                return true;

            }
            catch
            {

                // Tell the user the operation failed
                return false;

            }

        }
    }
}
