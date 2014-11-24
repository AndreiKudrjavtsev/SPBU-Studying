#include <iostream>
#include "list.h"
#include "mergeSort.h"

using namespace std;

List *mergeSort(List *list, bool choice)
{
	if (listSize(list) == 1)
		return list;
	
	//��������� �������� ������ �� ��� �������� ������ �� �����
	List *left = create();
	insertAsHead(left, returnValue(list, head(list), 1), returnValue(list, head(list), 0));
	List *right = create();
	insertAsHead(right, returnValue(list, next(list, middle(list)), 1), returnValue(list, next(list, middle(list)), 0));

	Position leftPtr = head(left);
	Position rightPtr = head(right);

	//��������� ��� ������� ���������� ��������� 
	Position tmp = next(list, head(list));
	while (tmp != next(list, middle(list)))
	{
		insert(left, leftPtr, returnValue(list, tmp, 1), returnValue(list, tmp, 0));
		leftPtr = next(left, leftPtr);
		tmp = next(list, tmp);
	}
	tmp = next(list, tmp);
	while (tmp != nullptr)
	{
		insert(right, rightPtr, returnValue(list, tmp, 1), returnValue(list, tmp, 0));
		rightPtr = next(right, rightPtr);
		tmp = next(list, tmp);
	}
	
	//����������� �����, ���� �� ������� ����� �������� �� 1 
	left = mergeSort(left, choice);
	right = mergeSort(right, choice);
	
	//������� �������������� ������ 
	List *sortedList = create();
	Position sortingPosition = head(sortedList);
	
	//������� ������� ��-�� � ������ ����������� ��������, ������� ������� ������ ��-� � ������ ���. ������
	if (returnValue(left, head(left), choice) <= returnValue(right, head(right), choice))
	{
		insertAsHead(sortedList, returnValue(left, head(left), 1), returnValue(left, head(left), 0));
		sortingPosition = head(sortedList);
		deleteHead(left);
	}
	else
	{
		insertAsHead(sortedList, returnValue(right, head(right), 1), returnValue(right, head(right), 0));
		sortingPosition = head(sortedList);
		deleteHead(right);
	}
	
	//������ ��������� ��-�� � ���. ������ �� � ������ 
	while (listSize(left) != 0 && listSize(right) != 0)
	{
		if (returnValue(left, head(left), choice) <= returnValue(right, head(right), choice))
		{
			insert(sortedList, sortingPosition, returnValue(left, head(left), 1), returnValue(left, head(left), 0));
			sortingPosition = next(sortedList, sortingPosition);
			deleteHead(left);
		}
		else
		{
			insert(sortedList, sortingPosition, returnValue(right, head(right), 1), returnValue(right, head(right), 0));
			sortingPosition = next(sortedList, sortingPosition);
			deleteHead(right);
		}
	}
	
	//� ������� ����� ��������� �������, �������������� ������ ����� ���� �� ��������� ��� �����
	while (listSize(left) != 0)
	{
		insert(sortedList, sortingPosition, returnValue(left, head(left), 1), returnValue(left, head(left), 0));
		deleteHead(left);
		sortingPosition = next(sortedList, sortingPosition);
	}
	while (listSize(right) != 0)
	{
		insert(sortedList, sortingPosition, returnValue(right, head(right), 1), returnValue(right, head(right), 0));
		deleteHead(right);
		sortingPosition = next(sortedList, sortingPosition);
	}

	deleteList(left);
	deleteList(right);
	deleteList(list);
	
	return sortedList;
}
