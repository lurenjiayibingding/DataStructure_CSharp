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

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <param name="low"></param>
        /// <param name="height"></param>
        public void Sort2<T>(IList<T> input, int low, int height) where T : IComparable
        {
            if (low == height)
                return;
            if (height - low == 1)
            {
                if (input[low].CompareTo(input[height]) >= 0)
                {
                    Exchange(input, low, height);
                }
                return;
            }

            int i = low;
            int j = height;
            T median = input[low];

            while (i < j)
            {
                while (i < j && input[j].CompareTo(median) > 0)
                {
                    j--;
                }
                while (i < j && input[i].CompareTo(median) <= 0)
                {
                    i++;
                }

                if (i < j)
                {
                    Exchange(input, i, j);
                    i++;
                    j--;
                }
                else if (i == j)
                {
                    if (input[i].CompareTo(median) <= 0)
                    {
                        T temp = input[low];
                        input[low] = input[i];
                        input[i] = temp;
                    }
                    else
                    {
                        T temp = input[low];
                        input[low] = input[i - 1];
                        input[i - 1] = temp;
                        j = i;
                        i = i - 1;
                    }
                    break;
                }
            }
            Sort2(input, low, i - 1);
            Sort2(input, j + 1, height);
        }

        /// <summary>
        /// 交换两个元素的位置
        /// </summary>
        /// <param name="input"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        private void Exchange<T>(IList<T> input, int i, int j)
        {
            T temp = input[i];
            input[i] = input[j];
            input[j] = temp;
        }
    }
}
