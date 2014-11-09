#pragma once 

struct Stack;
struct StackElement;

typedef int ElementType;
typedef StackElement *Position;

//функция создания стэка
Stack *create();

//функция добавления элемента в стэк
void push(Stack *stack, ElementType value);

//функция, удаляющая верхний элемент
void pop(Stack *stack);

//функция, удаляющая верхний элемент и возвращающая его 
ElementType top(Stack *stack);

//функция проверки стэка на наличие элементов
bool stackIsEmpty(Stack *stack);

//функция удаления стэка
void deleteStack(Stack *stack);