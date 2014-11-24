#pragma once 

using namespace std;

typedef int ElementType;

struct PointerList;
struct ListElement;

typedef ListElement *Position;

//функция создания списка
PointerList *create(ListElement choice);

//функция добавления элемента в голову списка
void insertAsHead(PointerList *list, ElementType element);

//функция добавления эл-та в список на заданную позицию
void insert(PointerList *list, Position position, ElementType element);

//функция удаления заданного эл-та из списка
void deleteElement(PointerList *list, Position position);

//функция удаления головы списка
void deleteHead(PointerList *list);

//функция удаления списка
void deleteList(PointerList *list);

//функция вывода списка на экран
void printList(PointerList *list);

//функция, возвращающая голову списка
ListElement *head(PointerList*list);

//функция, возвращающая следующий за заданным эл-т списка
ListElement *next(PointerList *list, ListElement *position);

//функция, возвращающас последний эл-т списка
ListElement *last(PointerList *list);

//функция, возвращающая опорный эл-т списка
ListElement *middle(PointerList *list);

//функция, возвращающая значение заданного эл-та списка в зависимости от выбора (1 - имя,0 - номер)
ElementType returnValue(PointerList *list, ListElement *position);

//функция, возвращающая длину списка
int listSize(PointerList *list);