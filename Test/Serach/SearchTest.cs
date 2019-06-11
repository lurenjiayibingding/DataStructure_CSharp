using _8_Search;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Serach
{
    [TestClass]
    public class SearchTest
    {
        [TestMethod]
        public void SequenceSerachTest()
        {
            SequenceSerach search = new SequenceSerach();
            int[] input = new int[] { 1, 1, 3, 8, 2, 3, 4, 0, 9, 10 };
            var result = search.Search(input, 3);
            Assert.IsTrue(result.Length == 2);
            Assert.IsTrue(result[0] == 2);
            Assert.IsTrue(result[1] == 5);
        }

        [TestMethod]
        public void BinarySearchTest()
        {
            BinarySearch search = new BinarySearch();
            int[] input = new int[] { 5, 5, 5, 5, 5, 5 };
            var result = search.Search(input, 0, input.Length - 1, 5);
            Assert.IsTrue(result.Length == 6);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.IsTrue(result[i] == i);
            }
        }

        [TestMethod]
        public void BinarySearchTest2()
        {
            BinarySearch search = new BinarySearch();
            int[] input = new int[] { 1, 2, 3, 5, 5, 6, 7, 8 };
            var result = search.Search(input, 0, input.Length - 1, 5);
            Assert.IsTrue(result.Length == 2);
            Assert.IsTrue(result[0] == 3);
            Assert.IsTrue(result[1] == 4);
        }

        [TestMethod]
        public void BinarySearchTest3()
        {
            BinarySearch search = new BinarySearch();
            int[] input = new int[] { 1, 2, 4, 5, 5, 6, 7, 8 };
            var result = search.Search(input, 0, input.Length - 1, 9);
            Assert.IsTrue(result.Length == 0);
        }
    }
}
