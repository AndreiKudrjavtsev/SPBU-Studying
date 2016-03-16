using System;
using System.Collections;
using System.Collections.Generic;

namespace BST
{
    public class BinarySearchTree<T> : IEnumerable<T> where T : IComparable
    {
        private class TreeNode
        {
            public TreeNode(T value)
            {
                this.Value = value;
            }

            public T Value { get; set; }
            public TreeNode LeftChild { get; set; }
            public TreeNode RightChild { get; set; }
        }

        private TreeNode root;


        /// <summary>
        /// Method for insertion element in tree  
        /// </summary>
        /// <param name="value"> value of element </param>
        public void Insert(T value)
        {
            if (this.IsFound(value))
                throw new InsertExistingElementException();
            else if (this.root == null)
                root = new TreeNode(value);
            else
                Insert(value, this.root);
        }
        private void Insert(T value, TreeNode root)
        {
            if (root.Value.CompareTo(value) > 0)
            {
                if (root.LeftChild == null)
                {
                    var newNode = new TreeNode(value);
                    root.LeftChild = newNode;
                }
                else
                    Insert(value, root.LeftChild);
            }
            else
            {
                if (root.RightChild == null)
                {
                    var newNode = new TreeNode(value);
                    root.RightChild = newNode;
                }
                else
                    Insert(value, root.RightChild);
            }
        }

        /// <summary>
        /// Method, that checks existance of element in tree 
        /// </summary>
        /// <param name="value"> value of element </param>
        /// <returns></returns>
        public bool IsFound(T value)
        {
            if (root == null)
                return false;
            else
                return IsFound(value, root);
        }
        private bool IsFound(T value, TreeNode root)
        {
            if (root.Value.CompareTo(value) == 0)
                return true;
            else if (root.Value.CompareTo(value) > 0)
            {
                if (root.LeftChild == null)
                    return false;
                else
                    return IsFound(value, root.LeftChild);
            }
            else
            {
                if (root.RightChild == null)
                    return false;
                else
                    return IsFound(value, root.RightChild);
            }
        }

        /// <summary>
        /// Method, that checks if tree is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return root == null;
        }

        /// <summary>
        /// Method, deleting element from tree 
        /// </summary>
        /// <param name="value"> value of element </param>
        public void Delete(T value)
        {
            root = Delete(value, root);
        }
        private TreeNode Delete(T value, TreeNode root)
        {
            if (root == null)
                return null;
            if (value.CompareTo(root.Value) < 0)
                root.LeftChild = Delete(value, root.LeftChild);
            else if (value.CompareTo(root.Value) > 0)
                root.RightChild = Delete(value, root.RightChild);
            else
            {
                if (root.LeftChild == null && root.RightChild == null)
                    return null;
                else if ((root.LeftChild != null && root.RightChild == null) || (root.LeftChild == null && root.RightChild != null))
                    return (root.LeftChild != null) ? root.LeftChild : root.RightChild;
                else
                {
                    if (root.RightChild.LeftChild == null)
                    {
                        TreeNode tmp = root.LeftChild;
                        root = root.RightChild;
                        root.LeftChild = tmp;
                        return root;
                    }
                    else
                    {
                        TreeNode tmp = root.LeftChild;
                        root = root.RightChild;
                        TreeNode tmp2 = root;
                        while (tmp2.LeftChild.LeftChild != null)
                        {
                            tmp2 = tmp2.LeftChild;
                        }
                        tmp2.LeftChild.LeftChild = tmp;
                        return root;
                    }
                }
            }
            return root;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            return new BSTIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Tree enumerator
        /// </summary>
        private class BSTIterator : IEnumerator<T>
        {
            private TreeNode currentElement;
            private BinarySearchTree<T> tree;
            private Stack<TreeNode> stack;

            public BSTIterator(BinarySearchTree<T> tree)
            {
                this.tree = tree;
                stack = new Stack<TreeNode>();
                stack.Push(tree.root);
            }

            public T Current
            {
                get { return currentElement.Value; }
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public void Dispose()
            { }

            public bool MoveNext()
            {
                if (stack.Count == 0)
                    return false;
                else
                {
                    currentElement = stack.Pop();
                    if (currentElement.LeftChild != null)
                        stack.Push(currentElement.LeftChild);
                    if (currentElement.RightChild != null)
                        stack.Push(currentElement.RightChild);
                    return true;
                }
            }

            public void Reset()
            {
                stack.Clear();
                stack.Push(tree.root);
            }
        }
    }
}
