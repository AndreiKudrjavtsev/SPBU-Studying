using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTree
{
    abstract class Operator : TreeElement
    {
        public TreeElement left { get; set; }
        public TreeElement right { get; set; }

        /// <summary>
        /// returns only operator
        /// </summary>
        /// <returns></returns>
        public abstract string Print();

        /// <summary>
        /// returns expression
        /// </summary>
        /// <returns></returns>
        public override string PrintTree()
        {
            return "( " + Print() + " " + left.PrintTree() + " " + right.PrintTree() + " )";
        }

        public override bool AddElement(TreeElement treeElement)
        {
            if (left == null)
            {
                left = treeElement;
                return true;
            }
            if (left.AddElement(treeElement))
                return true;

            if (right == null)
            {
                right = treeElement;
                return true;
            }
            if (right.AddElement(treeElement))
                return true;

            return false;
        }
    }
}
