#pragma once 

typedef int ElementType;

struct List;
struct ListElement;

typedef ListElement *Position;

List *create();

void insertAsHead(List *list, ElementType value);

Position next(List *list, Position position);

Position first(List *list);

Position last(List *list);

void print(List *list);

void addElementWithSort(List *list, ElementType value);

void deleteElementWithSort(List *list, ElementType value);

void deleteList(List *list);