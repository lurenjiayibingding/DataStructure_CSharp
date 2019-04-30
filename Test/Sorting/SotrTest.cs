using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _7_Sorting;
using System.Diagnostics;

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

        [TestMethod]
        public void BubbleSortStableTest()
        {
            int[] input = new int[] { 5, 4, 10, 9, 8, 3, 2, 7, 6, 1 };
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.SortStable<int>(input);
            for (int i = 0; i < input.Length; i++)
            {
                Assert.IsTrue(input[i] == i + 1);
            }
        }

        [TestMethod]
        public void BubbleSortUnstableTest()
        {
            CompareObj[] input = new CompareObj[]
            {
                new CompareObj("1-1", 1),
                new CompareObj("3-1", 3),
                new CompareObj("8-1", 8),
                new CompareObj("9-1", 9),
                new CompareObj("7-1", 7),
                new CompareObj("6-1", 6),
                new CompareObj("2-1", 2),
                new CompareObj("7-2", 7),
                new CompareObj("3-2", 3),
                new CompareObj("4-1", 4),
                new CompareObj("1-2", 1),
            };
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.SortUnstable<CompareObj>(input);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                stringBuilder.Append(input[i].ToString() + Environment.NewLine);
            }

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void FastSortTest()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            FastSort fastSort = new FastSort();
            fastSort.Sort<int>(input, 0, input.Length - 1);
            for (int i = 0; i < input.Length; i++)
            {
                Assert.IsTrue(input[i] == i + 1);
            }
        }

        [TestMethod]
        public void SeekStableSortTest()
        {
            int[] input = new int[] { 5, 4, 10, 9, 8, 3, 2, 7, 6, 1 };
            SeekSort seekSort = new SeekSort();
            seekSort.SortStable<int>(input);
            for (int i = 0; i < input.Length; i++)
            {
                Assert.IsTrue(input[i] == i + 1);
            }
        }

        [TestMethod]
        public void SeekUnstableSortTest()
        {
            CompareObj[] input = new CompareObj[]
            {
                new CompareObj("1-1", 1),
                new CompareObj("3-1", 3),
                new CompareObj("8-1", 8),
                new CompareObj("9-1", 9),
                new CompareObj("7-1", 7),
                new CompareObj("6-1", 6),
                new CompareObj("2-1", 2),
                new CompareObj("7-2", 7),
                new CompareObj("3-2", 3),
                new CompareObj("4-1", 4),
                new CompareObj("1-2", 1),
            };
            SeekSort seekSort = new SeekSort();
            seekSort.SortUnstable(input);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                stringBuilder.Append(input[i].ToString() + Environment.NewLine);
            }

            Assert.IsTrue(true);
        }
    }

    class CompareObj : IComparable
    {
        private int objvalue;
        private string flag;

        public int Objvalue { get => objvalue; set => objvalue = value; }
        public string Flag { get => flag; set => flag = value; }

        public CompareObj(string flag, int objvalue)
        {
            this.flag = flag;
            this.objvalue = objvalue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        int IComparable.CompareTo(Object obj)
        {
            var temp = obj as CompareObj;
            if (temp == null)
            {
                throw new Exception();
            }
            return this.Objvalue - temp.Objvalue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"flag:{flag},objvalue:{objvalue}";
        }
    }
}
