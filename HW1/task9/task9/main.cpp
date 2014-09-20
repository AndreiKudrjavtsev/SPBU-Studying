#include <iostream>

using namespace std;

int main()
{
	int number = 0;
	cout << "Enter the number: " << endl;
	cin >> number; 
	for (int i = 2; i < number + 1; i++)
	{
		int countOfDividers = 0;
		for (int j = 2; j < i; j++)
		{
			if (i % j == 0)
				countOfDividers++;
		}
		if (countOfDividers == 0)
			cout << i << " ";
	}

	return 0;
}