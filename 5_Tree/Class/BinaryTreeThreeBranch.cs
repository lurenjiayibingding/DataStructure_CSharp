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

        private T date;

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
        public T Data { get => date; set => this.date = value; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="value"></param>
        /// <param name="parent"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public ThreeBranchNode(T value, ThreeBranchNode<T> parent, ThreeBranchNode<T> left, ThreeBranchNode<T> right)
        {
            this.date = value;
            this.leftChild = left;
            this.rightChild = right;
            this.parent = parent;
        }
    }

    /// <summary>
    /// 三叉链表存储的二叉树
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryTreeThreeBranch<T>
    {

    }
}
