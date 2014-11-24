#pragma once 

using namespace std;

typedef int ElementType;

struct PointerList;
struct ListElement;

typedef ListElement *Position;

//������� �������� ������
PointerList *create(ListElement choice);

//������� ���������� �������� � ������ ������
void insertAsHead(PointerList *list, ElementType element);

//������� ���������� ��-�� � ������ �� �������� �������
void insert(PointerList *list, Position position, ElementType element);

//������� �������� ��������� ��-�� �� ������
void deleteElement(PointerList *list, Position position);

//������� �������� ������ ������
void deleteHead(PointerList *list);

//������� �������� ������
void deleteList(PointerList *list);

//������� ������ ������ �� �����
void printList(PointerList *list);

//�������, ������������ ������ ������
ListElement *head(PointerList*list);

//�������, ������������ ��������� �� �������� ��-� ������
ListElement *next(PointerList *list, ListElement *position);

//�������, ������������ ��������� ��-� ������
ListElement *last(PointerList *list);

//�������, ������������ ������� ��-� ������
ListElement *middle(PointerList *list);

//�������, ������������ �������� ��������� ��-�� ������ � ����������� �� ������ (1 - ���,0 - �����)
ElementType returnValue(PointerList *list, ListElement *position);

//�������, ������������ ����� ������
int listSize(PointerList *list);