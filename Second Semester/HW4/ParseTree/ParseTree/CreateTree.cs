using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTree
{
    public class CreateTree
    {
        /// <summary>
        /// method that converts expression to list with operands and operators
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static List<object> StringParser(string expression)
        {
            List<object> list = new List<object>();
            string currentNumber = null;

            foreach (char symbol in expression)
            {
                if (char.IsDigit(symbol))
                {
                    currentNumber += symbol;
                }
                else
                {
                    if (IsBracketOrSpace(symbol))
                    {
                        if (currentNumber != null)
                        {
                            list.Add(Convert.ToInt32(currentNumber));
                            currentNumber = null;
                        }
                    }
                    else
                        list.Add(symbol);
                }
            }
            return list;
        }

        /// <summary>
        /// method, that builds tree based on list with operands and operators
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static Tree TreeBuilder(string expression)
        {
            Tree tree = new Tree();
            List<object> list = StringParser(expression);
            foreach (var value in list)
            {
                if (value is int)
                {
                    tree.Add(Convert.ToInt32(value));
                }
                if (value is char)
                {
                    tree.Add(Convert.ToChar(value));
                }
            }
            return tree;
        }

        public static bool IsBracketOrSpace(char symbol)
        {
            return symbol == '(' || symbol == ')' || symbol == ' ';
        }
    }
}
