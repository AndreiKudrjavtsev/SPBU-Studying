#pragma once 

using namespace std;

typedef int ElementType;

struct PointerList;
struct ListElement;

// ������� �������� ������ �� ����������
PointerList *create(ListElement *choice);

// ������� ���������� �������� � ������ ������ �� ����������
void insertAsHead(PointerList *list, ElementType element);

// ������� ���������� ��-�� � ������ �� ���������� �� �������� �������
void insert(PointerList *list, ListElement *position, ElementType value);

// ������� �������� ��������� ��-�� �� ������ �� ����������
void deleteElement(PointerList *list, ListElement *position);

// ������� �������� ������ ������ �� ����������
void deleteHead(PointerList *list);

// ������� �������� ������ �� ����������
void deleteList(PointerList *list);

// ������� ������ ������ �� ���������� �� �����
void printList(PointerList *list);

// �������, ������������ ������ ������ �� ����������
ListElement *head(PointerList*list);

// �������, ������������ ��������� �� �������� ��-� ������ �� ����������
ListElement *next(PointerList *list, ListElement *position);

// �������, ������������ ��������� ��-� ������ �� ����������
ListElement *last(PointerList *list);

// �������, ������������ ������� ��-� ������ �� ����������
ListElement *middle(PointerList *list);

// �������, ������������ �������� ��������� ��-�� ������ �� ����������
ElementType returnValue(PointerList *list, ListElement *position);

// �������, ������������ ����� ������ �� ����������
int listSize(PointerList *list);