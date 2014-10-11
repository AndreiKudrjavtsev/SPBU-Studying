#include <iostream>
#include <time.h>

using namespace std;

void bubbleSort(int arr[], int length)
{
	for (int i = 0; i < length - 1; ++i)
	{
		for (int j = 0; j < length - 1 - i; ++j)
		{
			if (arr[j] > arr[j + 1])
				swap(arr[j], arr[j + 1]); 
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

int * arrayCopy(int a[], int length)
{
	int *b = new int[length];
	for (int i = 0; i < length; ++i)
	{
		b[i] = a[i];
	}
	return b;
}

void fillArray(int a[], int length, int rangeOfValues)
{
	for (int i = 0; i < length; ++i)
	{
		a[i] = rand() % rangeOfValues;
	}
}

void printArray(int a[], int length)
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
	cout << "enter the range of values (from 0 to your value): " << endl;
	cin >> rangeOfValues;

	int length = 0;
	cout << "Enter the length of array: " << endl;
	cin >> length; 

	int *arr = new int[length];
	fillArray(arr, length, rangeOfValues);
	int *arr2 = arrayCopy(arr, length);
	cout << "Your array: " << endl;
	printArray(arr, length);
	bubbleSort(arr, length); 
	cout << endl << "Your bubble-sorted array: " << endl;
	printArray(arr, length);
	cout << endl;
	countingSort(arr2, length, rangeOfValues); 
	cout << endl << "Your counting-sorted array: " << endl;
	printArray(arr2, length);

	cout << endl;
	delete[] arr;
	delete[] arr2; 
	system("pause");
	return 0;
}