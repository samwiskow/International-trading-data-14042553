using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTreeStructure
{
    public class AVLNode<T> where T : IComparable
    {
        private T data;
        public AVLNode<T> Left, Right;
        private int balanceFactor = 0;

        public AVLNode(T item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        public T Data
        {
            set { data = value; }
            get { return data; }
        }

        public int BalanceFactor
        {
            set { balanceFactor = value; }
            get { return balanceFactor; }
        }
    }
}
