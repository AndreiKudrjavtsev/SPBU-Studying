#include <iostream>
#include <string>
#include "List.h"

using namespace std;

typedef string ElementType;
typedef ListElement *Position;

struct List
{
	ListElement *head;
};

struct ListElement
{
	string str;
	int frequency;
	ListElement *next;
};

List *createList()
{
	List *list = new List;
	list->head = nullptr;
	return list;
}

ListElement *head(List *list)
{
	return list->head;
}

ListElement *next(List *list, ListElement *position)
{
	return position->next;
}

ElementType returnString(List *list, ListElement *position)
{
	return position->str;
}

void increaseFrequency(List *list, ListElement *position)
{
	position->frequency++;
}

void insert(List *list, Position position, ElementType element)
{
	ListElement *newElement = new ListElement;
	newElement->str = element;
	newElement->frequency = 1;
	newElement->next = position->next;
	position->next = newElement;
}

void insertAsHead(List *list, ElementType element)
{
	ListElement *newElement = new ListElement;
	newElement->str = element;
	newElement->frequency = 1;
	newElement->next = list->head;
	list->head = newElement;
}

void deleteElement(List *list, Position position, ElementType element)
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
	if (list->head == nullptr)
		return;

	ListElement *tmp = list->head;
	while (tmp != nullptr)
	{
		ListElement *temp = tmp;
		tmp = tmp->next;
		delete temp;
	}
	delete list;
}

void printList(List *list)
{
	Position tmp = list->head;
	while (tmp != nullptr)
	{
		cout << tmp->str << " " << tmp->frequency << endl;
		tmp = tmp->next;
	}
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