#pragma once 

typedef int ElementType;

struct ArrayList;

// функция создания списка на массивах
ArrayList *create(int choice);

// возвращает голову
int head(ArrayList *list);

// возвращает последний эл-т
int last(ArrayList *list);

// возвращает следующий за заданным эл-т 
int next(ArrayList *list, int position);

// возвращает центральный, или "опорный" эл-т 
int middle(ArrayList *list);

// возвращает длину списка
int listSize(ArrayList *list);

// возвращает значение заданного эл-та
ElementType returnValue(ArrayList *list, int position);

// функция добавления эл-та в список
void insert(ArrayList *list, ElementType value, int position);

// функция добавления эл-та в голову списка
void insertAsHead(ArrayList *list, ElementType value);

// функция удаления заданного эл-та из списка
void deleteElement(ArrayList *list, int position);

// функция удаления головы списка 
void deleteHead(ArrayList *list);

// функция удаления списка
void deleteList(ArrayList *list);

// функция вывода списка на экран
void printList(ArrayList *list);