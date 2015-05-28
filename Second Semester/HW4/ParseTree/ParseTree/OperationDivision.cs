using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTree
{
    class OperationDivision : Operator
    {
        public override int CalculateTree()
        { return left.CalculateTree() / right.CalculateTree(); }

        public override string Print()
        { return "/"; }
    }
}
