#include <iostream> 
#include <time.h>

using namespace std;

int main()
{
	srand(time(nullptr));

	int length = 0;
	int range = 0;
	cout << "Enter the length of the array: " << endl;
	cin >> length;
	cout << "Enter the range of randomed values of array (from 0 to your number): " << endl;
	cin >> range;

	int *arr = new int[length];
	int amountOfNulls = 0; 
	cout << "Your array: " << endl;
	for (int i = 0; i < length; i++)
	{
		arr[i] = rand() % range;
		cout << arr[i] << " ";
		if (arr[i] == 0)
			amountOfNulls++;
	}
	cout << endl << "Amount of nulls in this array is: " << amountOfNulls << endl;

	delete[] arr;
	return 0;
}