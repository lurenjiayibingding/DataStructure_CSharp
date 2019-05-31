using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Search
{
    /// <summary>
    /// 顺序查找
    /// </summary>
    public class SequenceSerach
    {
        /// <summary>
        /// 顺序查找
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int[] Search<T>(IList<T> input, T value) where T : IComparable
        {
            List<int> list = new List<int>();
            for (int i = 0; i < input.Count(); i++)
            {
                if (input[i].CompareTo(value) == 0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }
    }
}
