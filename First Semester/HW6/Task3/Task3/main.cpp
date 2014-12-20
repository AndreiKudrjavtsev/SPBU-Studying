#include <iostream>
#include "cicledlist.h"

using namespace std;

int main()
{
	int n = 0;
	int m = 0;
	cout << "Enter the amount of warriors: " << endl;
	cin >> n;
	cout << "Enter the killing period: " << endl;
	cin >> m;

	// первое условие - проверка корректности ввода
	// 2 и 3 - очевидные случаи
	if ((n < 1) || (m < 1))
		cout << "You entered incorrect numbers " << endl;
	if (n == 1)
		cout << "Last warrior: " << n << endl;
	if (m == 1)
		cout << "Last warrior: " << n << endl;
	if ((n > 1) && (m > 1))
	{
		List *list = create();
		Position position = first(list);
		for (int i = 1; i <= n; i++)
		{
			addToList(list, position, i);
			position = next(list, position);
		}
		int tmpPeriod = 1;
		Position pos = first(list);
		while (pos != next(list, pos))
		{
			if (tmpPeriod == m)
			{
				deleteNext(list, pos);
				tmpPeriod = 1;
			}
			else
			{
				tmpPeriod++;
				pos = next(list, pos);
			}
		}
		cout << "Last warrior: " << returnValue(list, pos) << endl;
		deleteList(list);
	}

	return 0;
}