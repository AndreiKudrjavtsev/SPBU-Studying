#include <iostream>
#include "PointerList.h"

using namespace std;

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

void insert(PointerList *list, ListElement *position, ElementType value)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->next = position->next;
	position->next = newElement;
}

void deleteElement(PointerList *list, ListElement *position)
{
	ListElement *tmp = position->next;
	position->next = position->next->next;
	delete tmp;
}

void deleteHead(PointerList *list)
{
	ListElement *tmp = list->head;
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

	ListElement *tmp = list->head;
	while (tmp != nullptr)
	{
		cout << tmp->value << " ";
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
	ListElement *tmp = list->head;
	int size = 0;
	while (tmp != nullptr)
	{
		size++;
		tmp = tmp->next;
	}
	return size;
}