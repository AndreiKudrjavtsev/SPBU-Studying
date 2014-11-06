#include <iostream>
#include <fstream>
#include "qSort.h"

using namespace std;

int main()
{
	//считываем массив из файла, в файле первый символ - длина массива
	ifstream in("file.txt");

	int length = 0;
	in >> length;
	int *a = new int[length];

	cout << "Your array: " << endl; 
	for (int i = 0; i < length; ++i)
	{
		in >> a[i];
		cout << a[i] << " ";
	}
	cout << endl;
	in.close();

	qSort(a, 0, length - 1);

	//пробегая по отсортированному массиву ищем более 1 подряд идущего элемента
	int maxAmount = 0;
	int maxIndex = 0;
	int count = 0;
	for (int i = 1; i < length; ++i)
	{
		if (a[i - 1] == a[i])
			++count;
		if (count > maxAmount)
		{
			maxAmount = count;
			maxIndex = i;
		}
	}
	if (maxAmount == 0)
		cout << "There is no element, which contains more than 1 time. " << endl;
	else
		cout << "The most frequent element: " << a[maxIndex] << endl;

	delete[] a;
	system("pause");
	return 0;
}
//tests: 
// array: 12 21 4 32 4 64 45 9 7 2 95 23 13 41 4 12 - correct
// array: 0 0 0 0 0 0 0 0 0 - correct
// array: 1 - correct