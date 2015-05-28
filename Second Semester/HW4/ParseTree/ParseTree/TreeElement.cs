using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTree
{
    abstract class TreeElement
    {
        public abstract string PrintTree();
        public abstract int CalculateTree();
        /// <summary>
        /// returns true and adds element, if possible
        /// </summary>
        /// <returns></returns>
        public abstract bool AddElement(TreeElement treeElement);
    }
}
