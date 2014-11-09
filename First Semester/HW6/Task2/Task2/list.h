#pragma once 

typedef int ElementType;

struct List;
struct ListElement;

typedef ListElement *Position;

//функция создания списка
List *create();

//функция вставки эл-та в начало списка
void insertAsHead(List *list, ElementType value);

//вычисление следующего эл-та
Position next(List *list, Position position);

//вычисление первого эл-та
Position first(List *list);

//вычисление последнего эл-та
Position last(List *list);

//вывод списка на экран
void print(List *list);

//функция добавления эл-та в список с сохранением сортированности 
void addElementWithSort(List *list, ElementType value);

//функция удаления эл-та из списка с сохранением сортированности 
void deleteElementWithSort(List *list, ElementType value);

//функция удаления списка
void deleteList(List *list);