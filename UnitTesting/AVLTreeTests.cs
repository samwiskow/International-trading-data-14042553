using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AVLTreeStructure;
using AVLTreeStructure.Country;

namespace UnitTesting
{
    [TestFixture]
    public class AVLTreeTests
    {
        private AVLTree<int> testTree = new AVLTree<int>();
        private CountryTree CT;

        [SetUp]
        public void init()
        {
            LinkedList<string> partners = null;
            CT = new CountryTree();
            for (int i = 0; i < 15; i++)
            {
                Country country = new Country("demoCountry" + i, 0, 0, 0, 0, partners);
                CT.InsertItem(country);
            }
        }

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

        [Test]
        public void testCount()
        {
            Assert.AreEqual(15, CT.Count());
        }

        [Test]
        public void testCountryName()
        {
            LinkedList<string> partners = null;
            Country country = new Country("TestName", 0, 0, 0, 0, partners);

            Assert.AreSame("TestName", country.Name);
        }
    }
}
