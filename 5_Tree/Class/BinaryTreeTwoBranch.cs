﻿using System;
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
        private T data;
        private TwoBranchNode<T> leftChild;
        private TwoBranchNode<T> rightChild;

        /// <summary>
        /// 节点的数据域
        /// </summary>
        public T Data { get => data; set => data = value; }

        /// <summary>
        /// 节点的左孩子节点
        /// </summary>
        public TwoBranchNode<T> LeftChild { get => leftChild; set => leftChild = value; }

        /// <summary>
        /// 节点的右孩子节点
        /// </summary>
        public TwoBranchNode<T> RightChild { get => rightChild; set => rightChild = value; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="value"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public TwoBranchNode(T value, TwoBranchNode<T> left, TwoBranchNode<T> right)
        {
            Data = value;
            LeftChild = left;
            RightChild = right;
        }

        public TwoBranchNode()
        {
            Data = default(T);
            LeftChild = null;
            RightChild = null;
        }
    }

    /// <summary>
    /// 二叉链表存储的二叉树
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryTreeTwoBranch<T>
    {
        /// <summary>
        /// 
        /// </summary>
        private TwoBranchNode<T> headNode;

        /// <summary>
        /// 
        /// </summary>
        private TwoBranchNode<T> currentNode;

        /// <summary>
        /// 二叉树的第一个节点
        /// </summary>
        public TwoBranchNode<T> HeadNode { get => headNode; set => headNode = value; }

        /// <summary>
        /// 
        /// </summary>
        public TwoBranchNode<T> CurrentNode { get => currentNode; set => currentNode = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        public BinaryTreeTwoBranch(TwoBranchNode<T> first)
        {
            headNode = first;
            currentNode = headNode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        public void AddNode(TwoBranchNode<T> first)
        {

        }
    }
}
