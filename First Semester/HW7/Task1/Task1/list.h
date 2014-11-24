#pragma once 
#include <string>

using namespace std;

typedef string ElementType;

struct List;
struct ListElement;

typedef ListElement *Position;

//функция создания списка
List *create();

//функция добавления элемента в голову списка
void insertAsHead(List *list, ElementType nameElement, ElementType numberElement);

//функция добавления эл-та в список на заданную позицию
void insert(List *list, Position position, ElementType nameElement, ElementType numberElement);

//функция удаления заданного эл-та из списка
void deleteElement(List *list, Position position);

//функция удаления головы списка
void deleteHead(List *list);

//функция удаления списка
void deleteList(List *list);

//функция вывода списка на экран
void printList(List *list);

//функция, возвращающая голову списка
ListElement *head(List*list);

//функция, возвращающая следующий за заданным эл-т списка
ListElement *next(List *list, ListElement *position);

//функция, возвращающая опорный эл-т списка
ListElement *middle(List *list);

//функция, возвращающая значение заданного эл-та списка в зависимости от выбора (1 - имя,0 - номер)
ElementType returnValue(List *list, ListElement *position, bool choice);

//функция, возвращающая длину списка
int listSize(List *list);