#include <iostream>
#include "cicledlist.h"

using namespace std;

struct ListElement
{
	ElementType value;
	ListElement *next;
};

struct List
{
	ListElement *guard;
};

List *create()
{

}

Position next(List *list, Position position);

Position first(List *list);

Position last(List *list);

void addToList(List *list, ListElement *lastPos, ElementType value);

void deleteNext(List *list, Position position);

ElementType defineValue(List *list, Position position);

void deleteList(List *list);