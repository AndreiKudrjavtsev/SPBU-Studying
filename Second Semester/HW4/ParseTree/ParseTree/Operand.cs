using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTree
{
    class Operand : TreeElement
    {
        public int value;

        public Operand(int val)
        {
            value = val;
        }

        public override bool AddElement(TreeElement treeElement)
        {
            return false;
        }

        public override int CalculateTree()
        {
            return value;
        }

        public override string PrintTree()
        {
            return value.ToString();
        }
    }
}
