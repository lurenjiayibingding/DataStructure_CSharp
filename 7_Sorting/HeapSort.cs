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
        /// <param name="input"></param>
        /// <param name="height"></param>
        public void ConvertToHeap(IList<T> input, int height)
        {
            while (height > 0)
            {
                int tempIndex = (height - 1) / 2;
                if (input[tempIndex].CompareTo(input[height]) <= 0)
                {
                    T tempValue = input[tempIndex];
                    input[tempIndex] = input[height];
                    input[height] = tempValue;
                    ConvertToHeap(input, tempIndex);
                }
                height = height - 1;
                ConvertToHeap(input, height);
            }
        }
    }
}
