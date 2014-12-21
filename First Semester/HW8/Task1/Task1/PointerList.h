#pragma once 

using namespace std;

typedef int ElementType;

struct PointerList;
struct ListElement;

// функция создания списка на указателях
PointerList *create(ListElement *choice);

// функция добавления элемента в голову списка на указателях
void insertAsHead(PointerList *list, ElementType element);

// функция добавления эл-та в список на указателях на заданную позицию
void insert(PointerList *list, ListElement *position, ElementType value);

// функция удаления заданного эл-та из списка на указателях
void deleteElement(PointerList *list, ListElement *position);

// функция удаления головы списка на указателях
void deleteHead(PointerList *list);

// функция удаления списка на указателях
void deleteList(PointerList *list);

// функция вывода списка на указателях на экран
void printList(PointerList *list);

// функция, возвращающая голову списка на указателях
ListElement *head(PointerList*list);

// функция, возвращающая следующий за заданным эл-т списка на указателях
ListElement *next(PointerList *list, ListElement *position);

// функция, возвращающас последний эл-т списка на указателях
ListElement *last(PointerList *list);

// функция, возвращающая опорный эл-т списка на указателях
ListElement *middle(PointerList *list);

// функция, возвращающая значение заданного эл-та списка на указателях
ElementType returnValue(PointerList *list, ListElement *position);

// функция, возвращающая длину списка на указателях
int listSize(PointerList *list);