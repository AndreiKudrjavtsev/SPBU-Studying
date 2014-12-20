#pragma once

typedef int ElementType;

struct List;
struct ListElement;

typedef ListElement *Position;

// функция создания списка
List *create();

// возвращает следующий за заданным эл-т
Position next(List *list, Position position);

// возвращает первый эл-т
Position first(List *list);

// возвращает последний 
Position last(List *list);

// функция добавления эл-та в список
void addToList(List *list, ListElement *lastPos, ElementType value);

// функция удаления следующего за заданным эл-та списка
void deleteNext(List *list, Position position);

// возвращает значение заданного эл-та списка
ElementType returnValue(List *list, Position position);

// функция удаления списка
void deleteList(List *list);