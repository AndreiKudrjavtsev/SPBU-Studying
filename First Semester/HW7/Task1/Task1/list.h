#pragma once 
#include <string>

using namespace std;

typedef string ElementType;

struct List;
struct ListElement;

typedef ListElement *Position;

//������� �������� ������
List *create();

//������� ���������� �������� � ������ ������
void insertAsHead(List *list, ElementType nameElement, ElementType numberElement);

//������� ���������� ��-�� � ������ �� �������� �������
void insert(List *list, Position position, ElementType nameElement, ElementType numberElement);

//������� �������� ��������� ��-�� �� ������
void deleteElement(List *list, Position position);

//������� �������� ������ ������
void deleteHead(List *list);

//������� �������� ������
void deleteList(List *list);

//������� ������ ������ �� �����
void printList(List *list);

//�������, ������������ ������ ������
ListElement *head(List*list);

//�������, ������������ ��������� �� �������� ��-� ������
ListElement *next(List *list, ListElement *position);

//�������, ������������ ������� ��-� ������
ListElement *middle(List *list);

//�������, ������������ �������� ��������� ��-�� ������ � ����������� �� ������ (1 - ���,0 - �����)
ElementType returnValue(List *list, ListElement *position, bool choice);

//�������, ������������ ����� ������
int listSize(List *list);