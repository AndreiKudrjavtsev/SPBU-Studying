#include <iostream>
#include "stack.h"

using namespace std;

int main()
{
	char expr[500];
	cout << "Enter the expression: " << endl;
	cin >> expr;
	Stack *stack = create();
	bool correctionCheck = false;
	for (int i = 0; i < strlen(expr); i++)
	{
		if (expr[i] == '(')
			push(stack, ')');
		if (expr[i] == '[')
			push(stack, ']');
		if (expr[i] == '{')
			push(stack, '}');
		if ((expr[i] == ')') || (expr[i] == ']') || (expr[i] == '}'))
		{
			if (top(stack) == expr[i])
			{
				correctionCheck = true;
				pop(stack);
			}
		}
	}
	if (correctionCheck)
		cout << "You entered correct expression. " << endl;
	else
		cout << "You entered incorrect expression. " << endl;
	deleteStack(stack);
	system("pause");
	return 0;
}
//tests:
// ((())) - correct
// ((([[[{{{}}}]]]))) - correct
// ([}) - incorrect
// ((( - incorrect