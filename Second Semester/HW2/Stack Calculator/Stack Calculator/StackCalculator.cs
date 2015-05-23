using System;

namespace StackCalculator
{
    public class StackCalculator
    {
        public int ParseNumber(string expression, ref int position)
        {
            int i = 0;
            char[] number = new char[100];
            while (Char.IsDigit(expression[position]))
            {
                number[i] = expression[position];
                position++;
                i++;
            }
            string resNumber = new string(number);
            return Convert.ToInt32(resNumber);
        }

        bool IsOperator(char expr)
        {
            return expr == '+' || expr == '-' || expr == '*' || expr == '/';
        }

        int CalculateValue(int firstOperand, int secondOperand, char operation)
        {
            switch (operation)
            {
                case '+': return firstOperand + secondOperand;
                case '-': return firstOperand - secondOperand;
                case '*': return firstOperand * secondOperand;
                case '/': return firstOperand / secondOperand;
                default: return -1;
            }
        }

        public int StackCalc(IStack<int> stack, string expression)
        {
            for (int i = 0; i < expression.Length; i++)
            {
                if (Char.IsDigit(expression[i]))
                {
                    stack.Push(ParseNumber(expression, ref i));
                }
                if (IsOperator(expression[i]))
                {
                    int secondOperand = stack.Peek();
                    stack.Pop();
                    int firstOperand = stack.Peek();
                    stack.Pop();
                    stack.Push(CalculateValue(firstOperand, secondOperand, expression[i]));
                }
            }
            return stack.Peek();
        }
    }
}
