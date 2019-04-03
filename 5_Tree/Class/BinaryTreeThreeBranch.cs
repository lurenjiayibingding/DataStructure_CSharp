using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Tree.Class
{
    /// <summary>
    /// 通过三叉链表存储二叉树时的节点
    /// </summary>
    public class ThreeBranchNode<T>
    {
        private ThreeBranchNode<T> parent;

        private ThreeBranchNode<T> leftChild;

        private ThreeBranchNode<T> rightChild;

        private T value;

        /// <summary>
        /// 节点的双亲节点
        /// </summary>
        public ThreeBranchNode<T> Parent { get => parent; set => parent = value; }

        /// <summary>
        /// 节点的左孩子节点
        /// </summary>
        public ThreeBranchNode<T> LeftChild { get => leftChild; set => leftChild = value; }

        /// <summary>
        /// 节点的右孩子节点
        /// </summary>
        public ThreeBranchNode<T> RightChild { get => rightChild; set => rightChild = value; }

        /// <summary>
        /// 节点的值
        /// </summary>
        public T Value { get => value; set => this.value = value; }

        /// <summary>
        /// 
        /// </summary>
        public ThreeBranchNode()
        {

        }
    }
}
