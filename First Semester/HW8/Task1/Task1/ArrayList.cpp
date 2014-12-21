#include <iostream>
#include "ArrayList.h"

using namespace std;

struct ArrayList
{
	ElementType *array;
	int last;
	int arraySize;
};

ArrayList *create(int choice)
{
	ArrayList *list = new ArrayList;
	list->array = new ElementType[100];
	list->arraySize = 100;
	list->last = -1;
	return list;
}

int head(ArrayList *list)
{
	return 0;
}

int last(ArrayList *list)
{
	return list->last + 1;
}

int next(ArrayList *list, int position)
{
	return position + 1;
}

int middle(ArrayList *list)
{
	return list->last / 2;
}

int listSize(ArrayList *list)
{
	return list->last + 1;
}

ElementType returnValue(ArrayList *list, int position)
{
	return list->array[position];
}

void insert(ArrayList *list, int position, ElementType value)
{
	position += 1;
	if (list->last < list->arraySize - 1)
	{
		for (int tmp = list->last + 1; tmp != position; tmp--)
			list->array[tmp] = list->array[tmp + 1];
		list->array[position] = value;
		list->last++;
	}
	else
	{
		ElementType *newArray = new ElementType[list->arraySize * 2];
		for (int tmp = 0; tmp < last(list); tmp++)
			newArray[tmp] = list->array[tmp];
		ElementType *pointer = list->array;
		list->array = newArray;
		list->arraySize *= 2;
		for (int tmp = last(list); tmp != position; tmp--)
			list->array[tmp] = list->array[tmp + 1];
		list->array[position] = value;
		list->last++;
		delete pointer;
	}
}

void insertAsHead(ArrayList *list, ElementType value)
{
	insert(list, -1, value);
}

void deleteElement(ArrayList *list, int position)
{
	for (int tmp = position; tmp != last(list); tmp++)
		list->array[tmp] = list->array[tmp + 1];
	list->last--;
}

void deleteHead(ArrayList *list)
{
	deleteElement(list, 0);
}

void deleteList(ArrayList *list)
{
	delete list->array;
	delete list;
}

void printList(ArrayList *list)
{
	for (int tmp = 0; tmp < last(list); tmp++)
		cout << list->array[tmp] << " ";
}