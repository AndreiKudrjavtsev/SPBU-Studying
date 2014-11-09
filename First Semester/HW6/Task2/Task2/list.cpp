#include <iostream>
#include "list.h"

using namespace std;

struct ListElement
{
	ElementType value;
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

void insertAsHead(List *list, ElementType value)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->next = list->head;
	list->head = newElement;
}

Position next(List *list, Position position)
{
	return position->next;
}

Position first(List *list)
{
	return list->head;
}

Position last(List *list)
{
	return nullptr;
}

void print(List *list)
{
	Position tmpPos = first(list);
	while (tmpPos != nullptr)
	{
		cout << tmpPos->value << " ";
		tmpPos = tmpPos->next;
	}
}

void addElementWithSort(List *list, ElementType value)
{
	if ((list->head == nullptr) || (list->head != nullptr && value <= list->head->value))
		insertAsHead(list, value);
	else
	{
		for (Position pos = first(list); pos != last(list); pos = next(list, pos))
		{
			if (pos->next == nullptr)
			{
				Position tmpPos = new ListElement;
				tmpPos->value = value;
				tmpPos->next = nullptr;
				pos->next = tmpPos;
				break;
			}
			else if (value <= pos->next->value)
			{
				Position tmpPos = new ListElement;
				tmpPos->value = value;
				tmpPos->next = pos->next;
				pos->next = tmpPos;
				break;
			}
		}
	}
}

void deleteElementWithSort(List *list, ElementType value)
{
	Position element = list->head;
	bool correctionCheck = false;
	while (element->next != nullptr)
	{
		if (element->next->value == value)
		{
			correctionCheck = true;
			Position tmp = element->next;
			element->next = element->next->next;
			delete tmp;
		}
		element = element->next;
	}
	if (!correctionCheck)
		cout << "Ёлемент не найден" << endl;
}

void deleteList(List *list)
{
	ListElement *tmp = list->head;
	while (tmp != nullptr)
	{
		ListElement *tmp2 = tmp;
		tmp = tmp->next;
		delete tmp2;
	}
	delete list;
}