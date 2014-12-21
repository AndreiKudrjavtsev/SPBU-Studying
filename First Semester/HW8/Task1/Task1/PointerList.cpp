#include <iostream>
#include "PointerList.h"

using namespace std;

typedef int ElementType;
typedef ListElement *Position;

struct ListElement
{
	ElementType value;
	ListElement *next;
};

struct PointerList
{
	ListElement *head;
};

PointerList *create(ListElement *choice)
{
	PointerList *list = new PointerList;
	list->head = nullptr;
	return list;
}

void insertAsHead(PointerList *list, ElementType value)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->next = list->head;
	list->head = newElement;
}

void insert(PointerList *list, Position position, ElementType value)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->next = position->next;
	position->next = newElement;
}

void deleteElement(PointerList *list, Position position)
{
	Position tmp = position->next;
	position->next = position->next->next;
	delete tmp;
}

void deleteHead(PointerList *list)
{
	Position tmp = list->head;
	list->head = list->head->next;
	delete tmp;
}

void deleteList(PointerList *list)
{
	if (!list)
		return;

	ListElement *tmp = head(list);
	while (tmp != nullptr)
	{
		ListElement *nextTmp = tmp;
		tmp = next(list, tmp);
		delete nextTmp;
	}
	delete list;
}

void printList(PointerList *list)
{
	if (!list)
		return;

	Position tmp = list->head;
	while (tmp != nullptr)
	{
		cout << tmp->value << " " << endl;
		tmp = tmp->next;
	}
}

ListElement *head(PointerList *list)
{
	return list->head;
}

ListElement *next(PointerList *list, ListElement *position)
{
	return position->next;
}

ListElement *middle(PointerList *list)
{
	int middle = listSize(list) / 2 - 1;
	ListElement *tmp = list->head;
	while (middle > 0)
	{
		middle--;
		tmp = tmp->next;
	}
	return tmp;
}

ListElement *last(PointerList *list)
{
	return nullptr;
}

ElementType returnValue(PointerList *list, ListElement *position)
{
	return position->value;
}

int listSize(PointerList *list)
{
	Position tmp = list->head;
	int size = 0;
	while (tmp != nullptr)
	{
		size++;
		tmp = tmp->next;
	}
	return size;
}