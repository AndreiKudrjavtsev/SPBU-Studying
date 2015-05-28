using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTree
{
    public class Tree
    {
        private TreeElement root;

        public void Add(int value)
        {
            if (root == null)
            { 
                root = new Operand(value);
            }
            else
            {
                root.AddElement(new Operand(value));
            }
        }

        public void Add(char operation)
        {
            if (root == null)
            {
                root = newOperation(operation);
            }
            else
            {
                root.AddElement(newOperation(operation));
            }
        }

        public int CalculateTree()
        {
            return root.CalculateTree();
        }

        public string PrintTree()
        {
            return root.PrintTree();
        }

        private TreeElement newOperation(char operation)
        {
            switch (operation)
            {
                case '+':
                    return new OperationAddition();
                case '-':
                    return new OperationSubtraction();
                case '*':
                    return new OperationMultiplication();
                case '/':
                    return new OperationDivision();
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
