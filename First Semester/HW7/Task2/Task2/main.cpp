#include <iostream>
#include "stack.h"

using namespace std;

//функци€, определ€юща€ выполн€емую операцию 
void operation(Stack *stack, int choice)
{
	char firstOperand = top(stack);
	pop(stack);
	char secondOperand = top(stack);
	pop(stack);
	if (choice == 1)
		push(stack, secondOperand + firstOperand);
	if (choice == 2)
		push(stack, secondOperand - firstOperand);
	if (choice == 3)
		push(stack, secondOperand * firstOperand);
	if (choice == 4)
		push(stack, secondOperand / firstOperand);
}

int main()
{
	char expr[500];
	cout << "Enter the expression in postfix form: " << endl;
	cin >> expr;
	Stack *stack = create();
	for (int i = 0; i < strlen(expr); i++)
	{
		if ((expr[i] != '+') && (expr[i] != '-') && (expr[i] != '*') && (expr[i] != '/'))
			push(stack, expr[i] - '0');
		if (expr[i] == '+')
			operation(stack, 1);
		if (expr[i] == '-')
			operation(stack, 2);
		if (expr[i] == '*')
			operation(stack, 3);
		if (expr[i] == '/')
			operation(stack, 4);
	}
	cout << "Your result: " << top(stack) << endl;
	deleteStack(stack);
	system("pause");
	return 0;
}
//тесты: 
// 9 6 - 1 2 + * = 9 - верно
// 0 0 + = 0 - верно 
// 1 2 3 4 + + + = 10 - верно