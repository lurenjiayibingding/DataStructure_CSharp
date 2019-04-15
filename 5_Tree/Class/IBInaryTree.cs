using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Tree.Class
{
    /// <summary>
    /// 二叉树的泛型接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBInaryTree<T>
    {
        /// <summary>
        /// 判断是否为空二叉树
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();

        /// <summary>
        /// 获取跟节点
        /// </summary>
        /// <returns></returns>
        T GetRoot();

        /// <summary>
        /// 得到节点的左孩子节点
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        T GetRightChild(T p);

        /// <summary>
        /// 得到节点的右孩子节点
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        T GetRightRight(T p);
    }
}
