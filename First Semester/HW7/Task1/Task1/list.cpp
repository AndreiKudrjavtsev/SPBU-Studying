#include <iostream>
#include "list.h"
#include <string>

using namespace std;

typedef string ElementType;
typedef ListElement *Position;

struct ListElement
{
	string name;
	string number; 
	ListElement *next;
};

struct List
{
	ListElement *head;
};

List *create()
{
	List *list = new List;
	list->head = nullptr;
	return list;
}

void insertAsHead(List *list, ElementType nameElement, ElementType numberElement)
{
	ListElement *newElement = new ListElement;
	newElement->name = nameElement;
	newElement->number = numberElement;
	newElement->next = list->head;
	list->head = newElement;
}

void insert(List *list, Position position, ElementType nameElement, ElementType numberElement)
{
	ListElement *newElement = new ListElement;
	newElement->name = nameElement;
	newElement->number = numberElement;
	newElement->next = position->next;
	position->next = newElement;
}

void deleteElement(List *list, Position position)
{
	Position tmp = position->next;
	position->next = position->next->next;
	delete tmp;
}

void deleteHead(List *list)
{
	Position tmp = list->head;
	list->head = list->head->next;
	delete tmp;
}

void deleteList(List *list)
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

void printList(List *list)
{
	if (!list)
		return;

	Position tmp = list->head;
	while (tmp != nullptr)
	{
		cout << tmp->name << " " << tmp->number << endl;
		tmp = tmp->next;
	}
}

ListElement *head(List *list)
{
	return list->head;
}

ListElement *next(List *list, ListElement *position)
{
	return position->next;
}

ListElement *middle(List *list)
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

ElementType returnValue(List *list, ListElement *position, bool choice)
{
	if (choice)
		return position->name;
	else
		return position->number;
}

int listSize(List *list)
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