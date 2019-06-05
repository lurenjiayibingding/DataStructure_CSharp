using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Search
{
    /// <summary>
    /// 二分查找
    /// </summary>
    public class BinarySearch
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int[] Search<T>(IList<T> input, int left, int right, T value) where T : IComparable
        {
            if (left == right)
            {
                if (input[left].CompareTo(value) == 0)
                {
                    return new int[] { left };
                }
                return new int[0];
            }

            int middleIndex = (right + left) / 2;
            if (input[middleIndex].CompareTo(value) == 0)
            {
                return GetBorder(input, middleIndex, value);
            }
            if (input[middleIndex].CompareTo(value) > 0)
            {
                return Search(input, left, middleIndex - 1, value);
            }
            if (input[middleIndex].CompareTo(value) < 0)
            {
                return Search(input, middleIndex + 1, right, value);
            }

            return new int[0];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <param name="index"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private int[] GetBorder<T>(IList<T> input, int index, T value) where T : IComparable
        {
            List<int> list = new List<int>();
            list.Add(index);

            int leftIndex = index - 1;
            int rightIndex = index + 1;
            while (leftIndex >= 0 && input[leftIndex].CompareTo(value) == 0)
            {
                list.Add(leftIndex);
                leftIndex--;
            }
            while (rightIndex < input.Count && input[rightIndex].CompareTo(value) == 0)
            {
                list.Add(rightIndex);
                rightIndex++;
            }

            return list.OrderBy(n => n).ToArray();
        }
    }
}
