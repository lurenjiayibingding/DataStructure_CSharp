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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        public void Sort(IList<T> input)
        {
            int height = input.Count() - 1;
            CreateHeap(input, (height - 1) / 2, height);
            while (height > 0)
            {
                T tempValue = input[height];
                input[height] = input[0];
                input[0] = tempValue;

                height--;
                CreateHeap(input, (height - 1) / 2, height);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">待整理为堆的数据集合</param>
        /// <param name="currentIndex">当前节点在堆中的位置</param>
        public void CreateHeap(IList<T> input, int currentIndex, int lastIndex)
        {
            for (int i = currentIndex; i >= 0; i--)
            {
                MoveSource(input, i, lastIndex);
            }
        }

        private void MoveSource(IList<T> input, int currentIndex, int lastIndex)
        {
            int leftChildIndex = (currentIndex + 1) * 2 - 1;
            int rightChildIndex = (currentIndex + 1) * 2;

            if (leftChildIndex <= lastIndex)
            {
                int tempIndex = leftChildIndex;
                T tempValue = input[leftChildIndex];

                if (rightChildIndex <= lastIndex)
                {
                    if (input[rightChildIndex].CompareTo(tempValue) > 0)
                    {
                        tempIndex = rightChildIndex;
                        tempValue = input[rightChildIndex];
                    }
                }

                if (tempValue.CompareTo(input[currentIndex]) > 0)
                {
                    input[tempIndex] = input[currentIndex];
                    input[currentIndex] = tempValue;
                    MoveSource(input, tempIndex, lastIndex);
                }
            }
        }
    }
}
