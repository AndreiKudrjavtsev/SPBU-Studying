#pragma once 

struct Stack;
struct StackElement;

typedef char ElementType;
typedef StackElement *Position;

//������� �������� �����
Stack *create();

//������� ���������� �������� � ����
void push(Stack *stack, ElementType value);

//�������, ��������� ������� �������
void pop(Stack *stack);

//�������, ��������� ������� ������� � ������������ ��� 
ElementType top(Stack *stack);

//������� �������� ����� �� ������� ���������
bool stackIsEmpty(Stack *stack);

//������� �������� �����
void deleteStack(Stack *stack);