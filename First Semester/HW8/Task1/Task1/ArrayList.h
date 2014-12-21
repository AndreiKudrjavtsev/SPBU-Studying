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

// возвращает длину списка на массивах
int listSize(ArrayList *list);

// возвращает значение заданного эл-та
ElementType returnValue(ArrayList *list, int position);

// функция добавления эл-та в список на массивах
void insert(ArrayList *list, int position, ElementType value);

// функция добавления эл-та в голову списка на массивах
void insertAsHead(ArrayList *list, ElementType value);

// функция удаления заданного эл-та из списка на массивах
void deleteElement(ArrayList *list, int position);

// функция удаления головы списка  на массивах
void deleteHead(ArrayList *list);

// функция удаления списка на массивах
void deleteList(ArrayList *list);

// функция вывода списка на массивах на экран
void printList(ArrayList *list);