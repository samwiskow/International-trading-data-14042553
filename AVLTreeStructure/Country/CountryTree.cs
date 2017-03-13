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
        public new void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        private void inOrder(AVLNode<Country> tree, ref string buffer)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.Name.ToString() + ",";
                inOrder(tree.Right, ref buffer);
            }
        }
        public new void PreOrder(ref string buffer)
        {
            preorder(root, ref buffer);
        }

        private void preorder(AVLNode<Country> tree, ref string buffer)
        {
            if (tree != null)
            {
                buffer += tree.Data.Name.ToString() + ",";
                preorder(tree.Left, ref buffer);
                preorder(tree.Right, ref buffer);
            }
        }

        public new void PostOrder(ref string buffer)
        {
            postOrder(root, ref buffer);
        }

        private void postOrder(AVLNode<Country> tree, ref string buffer)
        {
            if (tree != null)
            {
                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                buffer += tree.Data.Name.ToString() + ",";
            }
        }

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

        private void getAllNodes(ref List<Country> NodeList, AVLNode<Country> tree)
        {
            if (tree != null)
            {
                getAllNodes(ref NodeList, tree.Left);
                NodeList.Add(tree.Data);
                getAllNodes(ref NodeList, tree.Right);
            }
        }

        public void CalculateBestTradePotential(ref string bestCountry)
        {
            double tradePotential = 0;
            calculateBestTradePotentail(ref bestCountry, ref tradePotential, root);
        }

        private void calculateBestTradePotentail(ref string bestCountry, ref double tradePotential, AVLNode<Country> tree)
        {
            if (tree != null)
            {
                double tempTradePot = 0;
                calculateBestTradePotentail(ref bestCountry, ref tradePotential, tree.Left);
                foreach(string country in tree.Data.TradePartners)
                {
                    Country temp = GetNodeByName(country);
                    if(country != null)
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
