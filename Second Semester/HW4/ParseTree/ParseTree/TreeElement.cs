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
        public abstract bool AdditionIsAvailable();
        public abstract void AddElement();
    }
}
