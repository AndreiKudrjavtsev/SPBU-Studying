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
		cout << "0 - ����� " << endl
			<< "1 - �������� �������� � ������������� ������ " << endl
			<< "2 - ������� �������� �� ������ " << endl
			<< "3 - ����������� ������ " << endl;
		cin >> choice;
		switch (choice)
		{
			case 1:
			{
				cout << "������� ��������: " << endl;
				int tmpValue = 0;
				cin >> tmpValue;
				addElementWithSort(list, tmpValue);
				break;
			}
			case 2:
			{
				cout << "������� ��������: " << endl;
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
// T���: ������� 0, 1, 2, ���������� - ���������. ������ 2, ���������� - ���������.
// ������ 4 - �� ������, �� ���� ���������.
// ������� 1, 2, ���������� - ���������. ������ 1, ���������� - ���������.