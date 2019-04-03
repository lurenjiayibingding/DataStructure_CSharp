using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Tree.Class
{
    /// <summary>
    /// 通过二叉链表存储二叉树时的节点
    /// </summary>
    public class TwoBranchNode<T>
    {
        /// <summary>
        /// 数据域
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// 左孩子节点引用域
        /// </summary>
        public TwoBranchNode<T> LeftChild { get; set; }

        /// <summary>
        /// 右孩子节点引用域
        /// </summary>
        public TwoBranchNode<T> RightChild { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public TwoBranchNode()
        {

        }
    }
}
