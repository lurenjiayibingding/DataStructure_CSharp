using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Tree.Class
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITree<T>
    {
        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        bool Add(T node);
    }
}
