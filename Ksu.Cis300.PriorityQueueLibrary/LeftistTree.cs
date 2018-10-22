/* BinaryTreeNode.cs
 * Author: Rod Howell
 * Modified by : Ahmed Alnassar
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KansasStateUniversity.TreeViewer2;

namespace Ksu.Cis300.PriorityQueueLibrary
{
    /// <summary>
    /// An immutable generic binary tree node that can draw itself.
    /// </summary>
    /// <typeparam name="T">The type of the elements stored in the tree.</typeparam>
    public partial class LeftistTree<T> : ITree
    {
        /// <summary>
        /// Gets the data stored in this node.
        /// </summary>
        public T Data { get; }

        /// <summary>
        /// private int field to store the null path length
        /// </summary>
        private int _nullPath;
        /// <summary>
        /// returns 0 if the given tree is null, or the value stored in its _nullPathLength field otherwise.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static int NullPathLength(LeftistTree<T> t)
        {
            if(t == null)
            {
                return 0;
            }
            else
            {
                return t._nullPath;
            }
        }

        /// <summary>
        /// Gets this node's left child.
        /// </summary>
        public LeftistTree<T> LeftChild { get; }

        /// <summary>
        /// Gets this node's right child.
        /// </summary>
        public LeftistTree<T> RightChild { get; }

        public object Root => throw new NotImplementedException();

        public ITree[] Children => throw new NotImplementedException();

        public bool IsEmpty => throw new NotImplementedException();

        /// <summary>
        /// Constructs a LeftistTree with the given data, left child, and right child.
        /// </summary>
        /// <param name="data">The data stored in the node.</param>
        /// <param name="left">The left child.</param>
        /// <param name="right">The right child.</param>
        public LeftistTree(T data, LeftistTree<T> left, LeftistTree<T> right)
        {
            Data = data;
            if (NullPathLength(left) < NullPathLength(right))
            {
                RightChild = left;
                LeftChild = right;
            }
            else
            {
                LeftChild = left;
                RightChild = right;
            }

            _nullPath = 1 + NullPathLength(RightChild);
            
        }
    }
}
