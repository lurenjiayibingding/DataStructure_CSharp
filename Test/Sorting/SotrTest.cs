using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _7_Sorting;

namespace Test.Sorting
{
    /// <summary>
    /// SotrTest 的摘要说明
    /// </summary>
    [TestClass]
    public class SotrTest
    {
        [TestMethod]
        public void InsertSortTest()
        {
            int[] input = new int[] { 5, 4, 10, 9, 8, 3, 2, 7, 6, 1 };
            InsertSort insertSort = new InsertSort();
            insertSort.Sort<int>(input);
            for (int i = 0; i < input.Length; i++)
            {
                Assert.IsTrue(input[i] == i + 1);
            }
        }
    }
}
