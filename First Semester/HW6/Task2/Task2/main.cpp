#include <iostream>
#include <locale.h>
#include "list.h"

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");
	int choice = 1;
	List *list = create();
	while (choice)
	{
		cout << "0 - выйти " << endl
			<< "1 - добавить значение в сортированный список " << endl
			<< "2 - удалить значение из списка " << endl
			<< "3 - распечатать список " << endl;
		cin >> choice;
		switch (choice)
		{
			case 1:
			{
				cout << "Введите значение: " << endl;
				int tmpValue = 0;
				cin >> tmpValue;
				addElementWithSort(list, tmpValue);
				break;
			}
			case 2:
			{
				cout << "Введите значение: " << endl;
				int tmpValue = 0;
				cin >> tmpValue;
				deleteElement(list, tmpValue);
				break;
			}
			case 3:
			{
				print(list);
				cout << endl;
				break;
			}
		}

	}
	deleteList(list);
	return 0;
}
// Tест: добавил 0, 1, 2, распечатал - корректно. Удалил 2, распечатал - корректно.
// Удалил 4 - не найден, то есть корректно.
// Добавил 1, 2, распечатал - корректно. Удалил 1, распечатал - корректно.