#include <iostream>
#include <string>
#include <fstream>
#include "list.h"
#include "mergeSort.h"

using namespace std;

int main()
{
	ifstream in("file.txt");

	List *list = create();

	string tmpName;
	string tmpNumber;
	while (!in.eof())
	{
		in >> tmpName;
		in >> tmpNumber;
		insertAsHead(list, tmpName, tmpNumber);
	}
	in.close();

	cout << "Source list: " << endl;
	printList(list);
	cout << endl;

	bool choice = 0;
	cout << "Choose the way you want to sort array: 1 - name, 0 - number " << endl;
	cin >> choice;
	list = mergeSort(list, choice);

	cout << endl << "Sorted list: " << endl;
	printList(list);
	cout << endl;

	deleteList(list);

	return 0;
}