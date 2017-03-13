using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AVLTreeStructure;

namespace UnitTesting
{
    [TestFixture]
    public class AVLTreeTests
    {
        private AVLTree<int> testTree = new AVLTree<int>();

        [Test]
        public void TestTreeInsert()
        {
            for(int i = 0; i < 100; i++)
            {
                testTree.InsertItem(i);
            }

            Assert.That(testTree.Count() == 100, "Something went wrong in the insert test");
        }

        [Test]
        public void testTreeRemove()
        {
            for (int i = 0; i < testTree.Count(); i++)
            {
                testTree.InsertItem(i);
            }

            Assert.That(testTree.Count() == 0, "Something went wrong in the remove test");
        }
    }
}
