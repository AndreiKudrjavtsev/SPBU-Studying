#include <iostream>
#include <time.h>

using namespace std;

void bubbleSort(int arr[], int length)
{
	for (int i = 0; i < length - 1; ++i)
	{
		for (int j = 0; j < length - 1; ++j)
		{
			if (arr[j] > arr[j + 1])
			{
				int temp = 0;
				temp = arr[j];
				arr[j] = arr[j + 1];
				arr[j + 1] = temp;
			}
		}
	}
}

void countingSort(int arr[], int length, int rangeOfValues)
{
	int *auxiliaryArr = new int[rangeOfValues];
	for (int i = 0; i < rangeOfValues; ++i)
	{
		auxiliaryArr[i] = 0;
	}

	for (int i = 0; i < length; ++i)
	{
		auxiliaryArr[arr[i]]++;
	}
	int counter = 0;
	for (int i = 0; i < rangeOfValues; ++i)
	{
		for (int j = 0; j < auxiliaryArr[i]; ++j)
		{
			arr[counter] = i;
			++counter;
		}
	}
	delete[] auxiliaryArr;
}

void fillingArray(int a[], int length, int rangeOfValues)
{
	cout << "Your array: " << endl;
	for (int i = 0; i < length; ++i)
	{
		a[i] = rand() % rangeOfValues;
		cout << a[i] << " ";
	}
}

void printingArray(int a[], int length)
{
	for (int i = 0; i < length; ++i)
	{
		cout << a[i] << " ";
	}
}

int main()
{
	srand(time(nullptr));
	
	int rangeOfValues = 0;
	cout << "Enter the range of values: " << endl;
	cin >> rangeOfValues;

	int length = 0;
	cout << "Enter the length of array: " << endl;
	cin >> length; 

	int *bubbleArr = new int[length];
	fillingArray(bubbleArr, length, rangeOfValues);
	bubbleSort(bubbleArr, length);
	cout << endl << "Your bubble-sorted array: " << endl;
	printingArray(bubbleArr, length);
	cout << endl;

	int *countArr = new int[length];
	fillingArray(countArr, length, rangeOfValues);
	countingSort(countArr, length, rangeOfValues);
	cout << endl << "Your counting-sorted array: " << endl;
	printingArray(countArr, length);

	cout << endl;
	system("pause");
	return 0;
}