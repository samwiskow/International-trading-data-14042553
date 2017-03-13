using AVLTreeStructure;
using AVLTreeStructure.Country;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderUtility
{
    public class CSVWriter
    {
                
        public bool write(List<Country> countryList)
        {
            try
            {
                // Open file
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("countriesUpdated.csv"))
                {
                    // Write headers
                    file.WriteLine("Country,GDP growth,Inflation,Trade Balance,HDI Ranking,Main Trade Partners");

                    // Write each line in turn
                    foreach (Country country in countryList)
                    {

                        // Create a string to hold the information to write to a line
                        string line = null;
                        string partners = null;
                        string last = null;

                        if (country.TradePartners.Count > 0)
                            last = country.TradePartners.Last();

                        // Add the trade partners to the string in the same format as read in
                        foreach (string partner in country.TradePartners)
                        {
                            partners += partner;
                            if (partner.CompareTo(last) != 0)
                                partners += ";";
                        }

                        // Write the line to the file
                        line = country.Name.ToString() + "," + country.gdpGrowth.ToString() + "," + country.Inflation.ToString() 
                            + "," + country.TradeBalance.ToString() + ","  + country.hdiRanking.ToString() + ",[" + partners + "]";
                        file.WriteLine(line);
                    }
                }
                // success
                return true;

            }
            catch(Exception ex)
            {
                // Failure
                Trace.WriteLine(ex);
                return false;
            }
        }
    }
}
