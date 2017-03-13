using AVLTreeStructure.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTreeStructure.Country
{
    public class CountryTree : AVLTree<Country>
    {
        // Returns an country based on exact match
        public Country GetNodeByName(string name)
        {
            return getNodebyName(name, ref root);
        }
        
        private Country getNodebyName(string name, ref AVLNode<Country> tree)
        {
            if (tree == null)
            {
                return null;
            }
            else if (name.CompareTo(tree.Data.Name) == 0)
            {
                return tree.Data;
            }
            else if (name.CompareTo(tree.Data.Name) > 0)
            {
                return getNodebyName(name, ref tree.Right);
            }
            else
            {
                return getNodebyName(name, ref tree.Left);
            }
        }

        // returns either all countries in the tree or countries that contain letters entered in the search bar
        public void GetNodesLike(string name, ref List<Country> NodeList)
        {
            name = name.ToLower();
            if (name == "" || name == "search countries...")
            {
                getAllNodes(ref NodeList, root);
            }
            else if (name.Length > 0 && !name.Contains("search countries..."))
            {
                getnodesLike(name, ref NodeList, root);
            }
        }

        // Returns a list of countires that contain the specified string
        private void getnodesLike(string name, ref List<Country> NodeList, AVLNode<Country> tree)
        {
            if (tree != null)
            {
                getnodesLike(name, ref NodeList, tree.Left);
                if (tree.Data.Name.ToLower().Contains(name))
                {
                    NodeList.Add(tree.Data);
                }
                getnodesLike(name, ref NodeList, tree.Right);
            }
        }

        // Returns all countries in the tree
        private void getAllNodes(ref List<Country> NodeList, AVLNode<Country> tree)
        {
            if (tree != null)
            {
                getAllNodes(ref NodeList, tree.Left);
                NodeList.Add(tree.Data);
                getAllNodes(ref NodeList, tree.Right);
            }
        }

        // Used to calculate the country with the best trade potential in the tree
        public void CalculateBestTradePotential(ref string bestCountry)
        {
            double tradePotential = 0;
            calculateBestTradePotentail(ref bestCountry, ref tradePotential, root);
        }


        // Here it is assumed that a countries trade potentail is calculated by the sum of the gdpGrowth attribute of all of that 
        // country's trade partners
        private void calculateBestTradePotentail(ref string bestCountry, ref double tradePotential, AVLNode<Country> tree)
        {
            if (tree != null)
            {
                double tempTradePot = 0;
                calculateBestTradePotentail(ref bestCountry, ref tradePotential, tree.Left);
                foreach(string country in tree.Data.TradePartners)
                {
                    Country temp = GetNodeByName(country);
                    if(temp != null)
                    {
                        tempTradePot += temp.gdpGrowth;
                    }
                }
                if(tempTradePot > tradePotential){
                    tradePotential = tempTradePot;
                    bestCountry = tree.Data.Name;
                }
                calculateBestTradePotentail(ref bestCountry, ref tradePotential, tree.Right);
            }
        }
    }//Class
}
