#include <iostream>

using namespace std;

int main()
{
	int *arrOfSums = new int[28];
	int amountOfTickets = 0;
	for (int i = 0; i < 28; i++)
	{
		arrOfSums[i] = 0;
	}
	for (int i = 0; i < 10; i++)
	{
		for (int j = 0; j < 10; j++)
		{
			for (int k = 0; k < 10; k++)
			{
				arrOfSums[i + j + k]++;
			}
		}
	}
	for (int i = 0; i < 28; i++)
	{
		amountOfTickets = amountOfTickets + arrOfSums[i] * arrOfSums[i];
	}
	cout << "Amount of lucky tickets: " << amountOfTickets << endl;

	delete[] arrOfSums;
	return 0;
}