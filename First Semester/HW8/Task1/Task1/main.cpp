#include <iostream>
#include <time.h>
#include "MergeSort.h"

using namespace std;

int main()
{
	srand(time(nullptr));

	int length = 0;
	cout << "Enter the length of list: " << endl;
	cin >> length;
	int range = 0;
	cout << "Enter the range of values: " << endl;
	cin >> range;

	Position choice = NULL;
	List *list = create(choice);

	insertAsHead(list, rand() % range);
	Position tmp = head(list);
	for (int i = 0; i < length; i++)
	{
		insert(list, rand() % range, tmp);
		tmp = next(list, tmp);
	}

	cout << "Source list: " << endl;
	printList(list);
	cout << endl;

	list = mergeSort(list);
	cout << "Sorted list: " << endl;
	printList(list);
	cout << endl;

	deleteList(list);
	return 0;
}