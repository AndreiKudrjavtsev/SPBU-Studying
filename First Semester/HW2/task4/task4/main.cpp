#include <iostream>
#include <time.h>

using namespace std;

int main()
{
	srand(time(nullptr));

	int length = 0;
	int range = 0;
	cout << "Enter length of array and range of values: " << endl;
	cin >> length >> range;
	int *arr = new int[length];
	cout << "Your array :" << endl;
	for (int i = 0; i < length; ++i)
	{
		arr[i] = rand() % range;
		cout << arr[i] << " ";
	}
	cout << endl;
	int pivot = arr[0];
	int i = 0;
	int j = length - 1;
	int temp = 0;

	while (i <= j)
	{
		while (i < length && arr[i] < pivot)
			++i;
		while (j > 0 && arr[j] > pivot)
			--j;
		if (i <= j)
		{
			temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
			++i;
			--j;
		}
	}

	for (i = 0; i < length; i++)
		cout << arr[i] << " ";
	cout << endl;

	delete[] arr;

	system("pause");
	return 0;
}