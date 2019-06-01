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
    }
}
