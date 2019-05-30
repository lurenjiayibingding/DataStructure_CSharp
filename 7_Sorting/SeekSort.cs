using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Sorting
{
    /// <summary>
    /// 查找排序
    /// </summary>
    public class SeekSort
    {
        /// <summary>
        /// 稳定查找排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        public void SortStable<T>(IList<T> input) where T : IComparable
        {
            int maxFlag = 0;
            T max = input[maxFlag];
            for (int i = 0; i < input.Count - 1; i++)
            {
                int j = 0;
                for (; j < input.Count - 1 - i; j++)
                {
                    if (max.CompareTo(input[j]) < 0)
                    {
                        max = input[j];
                        maxFlag = j;
                    }
                }
                input[maxFlag] = input[j];
                input[j] = max;

                maxFlag = 0;
                max = input[maxFlag];
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        public void SortStable2<T>(IList<T> input) where T : IComparable
        {
            for (int i = 0; i < input.Count - 1; i++)
            {
                int tIndex = i;
                for (int j = i + 1; j < input.Count; j++)
                {
                    if (input[tIndex].CompareTo(input[j]) > 0)
                    {
                        tIndex = j;
                    }
                }

                T tValue = input[i];
                input[i] = input[tIndex];
                input[tIndex] = tValue;
            }
        }

        /// <summary>
        /// 不稳定的查找排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        public void SortUnstable<T>(IList<T> input) where T : IComparable
        {
            for (int i = 0; i < input.Count - 1; i++)
            {
                int maxFlag = 0;
                T max = input[0];
                int j = 0;
                for (; j < input.Count - 1 - i; j++)
                {
                    if (max.CompareTo(input[j]) <= 0)
                    {
                        max = input[j];
                        maxFlag = j;
                    }
                }
                input[maxFlag] = input[j];
                input[j] = max;
            }
        }
    }
}
