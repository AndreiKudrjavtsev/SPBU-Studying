#include <iostream>
#include "stack.h"

using namespace std;

struct StackElement
{
	ElementType value;
	StackElement *next;
};

struct Stack
{
	StackElement *head;
};

Stack *create()
{
	Stack *stack = new Stack;
	stack->head = nullptr;
	return stack;
}

void push(Stack *stack, ElementType value)
{
	StackElement *newElement = new StackElement;
	newElement->value = value;
	newElement->next = stack->head;
	stack->head = newElement;
}

void pop(Stack *stack)
{
	StackElement *tmp = stack->head;
	stack->head = stack->head->next;
	delete tmp;
}

ElementType top(Stack *stack)
{
	return stack->head->value;
}

bool stackIsEmpty(Stack *stack)
{
	if (stack->head == nullptr)
		return true;
	else
		return false;
}

void deleteStack(Stack *stack)
{
	while (stack->head != nullptr)
		pop(stack);
	delete stack;
}