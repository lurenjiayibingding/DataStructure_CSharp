using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Sorting
{
    /// <summary>
    /// 堆排序
    /// </summary>
    public class HeapSort<T> where T : IComparable
    {
        public void Sort(IList<T> input)
        {
            int height = input.Count - 1;
            ConvertToHeap(input, height);
            while (height > 0)
            {
                T max = input[0];
                input[0] = input[height];
                input[height] = max;
                height--;
                ConvertToHeap(input, height);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">待整理为堆的数据集合</param>
        /// <param name="index">集合中第一个非叶子节点的位置</param>
        public void ConvertToHeap(IList<T> input, int index)
        {
            int leftIndex = (index + 1) * 2 - 1;
            T leftValue = input[leftIndex];

            if (leftIndex< input.Count - 1)
            {

            }
        }
    }
}
