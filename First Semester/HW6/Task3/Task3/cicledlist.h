#pragma once

typedef int ElementType;

struct List;
struct ListElement;

typedef ListElement *Position;

List *create();

Position next(List *list, Position position);

Position first(List *list);

Position last(List *list);

void addToList(List *list, ListElement *lastPos, ElementType value);

void deleteNext(List *list, Position position);

ElementType defineValue(List *list, Position position);

void deleteList(List *list);