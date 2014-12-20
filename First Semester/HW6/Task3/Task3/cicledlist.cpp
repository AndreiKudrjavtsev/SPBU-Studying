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
	List *list = new List;
	ListElement *tmp = new ListElement;
	list->guard = tmp;
	tmp->next = nullptr;
	return list;

}

Position next(List *list, Position position)
{
	return position->next;
}

Position first(List *list)
{
	return list->guard;
}

Position last(List *list)
{
	return nullptr;
}

void addToList(List *list, ListElement *lastPos, ElementType value)
{
	ListElement *newElement = new ListElement;
	lastPos->next = newElement;
	newElement->value = value;
	newElement->next = list->guard->next;
}

void deleteNext(List *list, Position position)
{
	Position tmp = position->next;
	position->next = position->next->next;
	delete tmp;
	list->guard->next = position->next;
}

ElementType returnValue(List *list, Position position)
{
	return position->value;
}

void deleteList(List *list)
{
	if (list->guard->next != nullptr)
	{
		Position tmp = list->guard->next;
		while (tmp != tmp->next)
		{
			Position tmp2 = tmp;
			tmp = tmp->next;
			delete tmp2;
		}
	}
	delete list->guard->next;
	delete list->guard;
	delete list;
}