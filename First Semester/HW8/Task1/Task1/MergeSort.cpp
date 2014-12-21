#include <iostream>
#include "MergeSort.h"

using namespace std;

List *mergeSort(List *list)
{
	if (listSize(list) == 1)
		return list;

	Position choice = NULL;

	//разбиваем исходный массив на два примерно равных по длине
	List *left = create(choice);
	insertAsHead(left, returnValue(list, head(list)));
	List *right = create(choice);
	insertAsHead(right, returnValue(list, next(list, middle(list))));

	Position leftPtr = head(left);
	Position rightPtr = head(right);

	//заполняем эти массивы значениями исходного 
	Position tmp = next(list, head(list));
	while (tmp != next(list, middle(list)))
	{
		insert(left, leftPtr, returnValue(list, tmp));
		leftPtr = next(left, leftPtr);
		tmp = next(list, tmp);
	}
	tmp = next(list, tmp);
	while (tmp != last(list))
	{
		insert(right, rightPtr, returnValue(list, tmp));
		rightPtr = next(right, rightPtr);
		tmp = next(list, tmp);
	}

	//рекурсивный вызов, пока не доведем длины массивов до 1 
	left = mergeSort(left);
	right = mergeSort(right);

	//создаем результирующий список 
	List *sortedList = create(choice);
	Position sortingPosition = head(sortedList);

	//функция вставки эл-та в голову реализована отдельно, поэтому сначала ставим эл-т в голову рез. списка
	if (returnValue(left, head(left)) <= returnValue(right, head(right)))
	{
		insertAsHead(sortedList, returnValue(left, head(left)));
		sortingPosition = head(sortedList);
		deleteHead(left);
	}
	else
	{
		insertAsHead(sortedList, returnValue(right, head(right)));
		sortingPosition = head(sortedList);
		deleteHead(right);
	}

	//теперь вставляем эл-ты в рез. список не в голову 
	while (listSize(left) != 0 && listSize(right) != 0)
	{
		if (returnValue(left, head(left)) <= returnValue(right, head(right)))
		{
			insert(sortedList, sortingPosition, returnValue(left, head(left)));
			sortingPosition = next(sortedList, sortingPosition);
			deleteHead(left);
		}
		else
		{
			insert(sortedList, sortingPosition, returnValue(right, head(right)));
			sortingPosition = next(sortedList, sortingPosition);
			deleteHead(right);
		}
	}

	//и наконец пишем отдельные условия, обрабатывающие случаи когда одна из половинок уже пуста
	while (listSize(left) != 0)
	{
		insert(sortedList, sortingPosition, returnValue(left, head(left)));
		deleteHead(left);
		sortingPosition = next(sortedList, sortingPosition);
	}
	while (listSize(right) != 0)
	{
		insert(sortedList, sortingPosition, returnValue(right, head(right)));
		deleteHead(right);
		sortingPosition = next(sortedList, sortingPosition);
	}

	deleteList(left);
	deleteList(right);
	deleteList(list);

	return sortedList;
}