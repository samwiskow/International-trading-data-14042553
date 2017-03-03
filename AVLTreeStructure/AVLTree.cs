using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTreeStructure
{
    public class AVLTree<T> where T : IComparable
    {
        protected AVLNode<T> root;
        public AVLTree()
        {
            root = null;
        }

        public AVLTree(AVLNode<T> node)
        {
            root = node;
        }

        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        private void inOrder(AVLNode<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() + ",";
                inOrder(tree.Right, ref buffer);
            }
        }

        public void PreOrder(ref string buffer)
        {
            preorder(root, ref buffer);
        }

        private void preorder(AVLNode<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                buffer += tree.Data.ToString() + ",";
                preorder(tree.Left, ref buffer);
                preorder(tree.Right, ref buffer);
            }
        }

        public void PostOrder(ref string buffer)
        {
            postOrder(root, ref buffer);
        }

        private void postOrder(AVLNode<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString() + ",";
            }
        }

        public int Count()
        {
            int counter = 0;
            return count(root, ref counter);
        }
        private int count(AVLNode<T> tree, ref int counter)
        {
            if (tree == null)
            {
                return counter += 0;
            }
            else
            {
                return (1 + count(tree.Left, ref counter) + count(tree.Right, ref counter));
            }
        }

        public int Height()
        {
            return height(root);
        }

        protected int height(AVLNode<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }
            else
            {
                return (1 + Math.Max(height(tree.Left), height(tree.Right)));
            }
        }

        public Boolean Contains(T item)
        {
            return contains(item, root);
        }

        private Boolean contains(T item, AVLNode<T> tree)
        {
            if (tree == null)
            {
                return false;
            }
            else if (item.CompareTo(tree.Data) == 0)
            {
                return true;
            }
            else
            {
                return (contains(item, tree.Left) || contains(item, tree.Right));
            }
        }

        public void RemoveItem(T item)
        {
            removeItem(item, ref root);
        }

        private void removeItem(T item, ref AVLNode<T> tree)
        {
            if (tree == null)
            {
                return;
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                removeItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                removeItem(item, ref tree.Right);
            }

            //found item
            else if (tree.Left == null)
            {
                tree = tree.Right;
            }
            else if (tree.Right == null)
            {
                tree = tree.Left;
            }
            else
            {
                T newRoot = leastItem(tree.Right);
                tree.Data = newRoot;
                removeItem(newRoot, ref tree.Right);
            }

            if(tree == null)
            {
                return;
            }

            tree.BalanceFactor = height(tree.Left) - height(tree.Right);
            if (tree.BalanceFactor <= -2)
            {
                rotateLeft(ref tree);
            }
            if (tree.BalanceFactor >= 2)
            {
                rotateRight(ref tree);
            }
        }

        private T leastItem(AVLNode<T> tree)
        {
            if (tree.Left == null)
            {
                return tree.Data;
            }
            else
            {
                return leastItem(tree.Left);
            }
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref AVLNode<T> tree)
        {
            if (tree == null)
            {
                tree = new AVLNode<T>(item);
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
            tree.BalanceFactor = height(tree.Left) - height(tree.Right);
            if (tree.BalanceFactor <= -2)
            {
                rotateLeft(ref tree);
            }
            if (tree.BalanceFactor >= 2)
            {
                rotateRight(ref tree);
            }
        }

        private void rotateLeft(ref AVLNode<T> tree)
        {
            if (tree.Right == null)
            {
                return;
            }
            if (tree.Right.BalanceFactor > 0)
            {
                rotateRight(ref tree.Right);
            }
            AVLNode<T> pivot = tree.Right;
            tree.Right = pivot.Left;
            pivot.Left = tree;
            tree = pivot;
        }

        private void rotateRight(ref AVLNode<T> tree)
        {
            if (tree.Left == null)
            {
                return;
            }
            if (tree.Left.BalanceFactor < 0)
            {
                rotateLeft(ref tree.Left);
            }
            AVLNode<T> pivot = tree.Left;
            tree.Left = pivot.Right;
            pivot.Right = tree;
            tree = pivot;
        }
    }
}
