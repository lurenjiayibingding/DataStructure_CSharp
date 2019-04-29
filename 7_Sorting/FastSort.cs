using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Sorting
{
    /// <summary>
    /// 快速排序
    /// </summary>
    public class FastSort
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        public void Sort<T>(IList<T> input, int low, int high) where T : IComparable
        {
            int i = low;
            int j = high;
            T tmp = input[low];
            while (low < high)
            {
                while ((low < high) && (input[high].CompareTo(tmp) >= 0))
                {
                    --high;
                }
                input[low] = input[high];
                ++low;
                while ((low < high) && (input[low].CompareTo(tmp) <= 0))
                {
                    ++low;
                }
                input[high] = input[low];
                --high;
            }
            input[low] = tmp;
            if (i < low - 1)
            {
                Sort(input, i, low - 1);
            }
            if (low + 1 < j)
            {
                Sort(input, low + 1, j);
            }
        }
    }
}
