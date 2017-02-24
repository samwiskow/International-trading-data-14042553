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

        private void winOrder(AVLNode<Country> tree, ref List<Country> countryNames)
        {
            if(tree != null)
            {
                winOrder(tree.Left, ref countryNames);
                countryNames.Add(tree.Data);
                winOrder(tree.Right, ref countryNames);
            }
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

        public Boolean Contains(string name)
        {
            return contains(name, root);
        }

        private Boolean contains(string name, AVLNode<Country> tree)
        {
            if (tree == null)
            {
                return false;
            }
            else if (name.CompareTo(tree.Data.Name) == 0)
            {
                return true;
            }
            else
            {
                return (contains(name, tree.Left) || contains(name, tree.Right));
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
            if (string.IsNullOrEmpty(name))
            {
                getAllNodes(name, ref NodeList, root);
            }
            else if (name.Length > 0)
            {
                name = name.ToLower();
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

        private void getAllNodes(string name, ref List<Country> NodeList, AVLNode<Country> tree)
        {
            getnodesLike(name, ref NodeList, tree.Left);
            NodeList.Add(tree.Data);
            getnodesLike(name, ref NodeList, tree.Right);
        }
    }
}
