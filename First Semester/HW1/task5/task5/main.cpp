#include <iostream>
#include "time.h"

using namespace std;

void reverse(int inArr[], int start, int end)
{
	for (int i = start; i < (end - start) / 2; i++)
	{
		inArr[i] = inArr[i] + inArr[end + start - i - 1];
		inArr[end + start - i - 1] = inArr[i] - inArr[end + start - i - 1];
		inArr[i] = inArr[i] - inArr[end + start - i - 1];
	}
}

int main()
{
	srand(time(NULL));

	int length = 0;
	cout << "Enter length of the array: " << endl;
	cin >> length;
	int *arr = new int[length];
	cout << "Your array :" << endl;
	for (int i = 0; i < length; i++)
	{
		arr[i] = rand() % 9 + 1;
		cout << arr[i] << " ";
	}
	int n = 0;
	int m = 0;
	cout << endl << "Enter the values of m and n: " << endl;
	cin >> m >> n;
	if ((m + n) != length)
	{
		cout << "Incorrect input, try again" << endl;
		system("pause");
		return 0;
	}
	
	reverse(arr, 0, m);							//reversing 1st part of array
	reverse(arr, m + 1, n + m);					//reversing 2nd part of array
	reverse(arr, 0, m + n);						//reversing full array

	cout << "Result: " << endl;
	for (int i = 0; i < length; i++)
	{
		cout << arr[i] << " ";
	}
	cout << endl;

	delete[] arr;
	return 0;
}