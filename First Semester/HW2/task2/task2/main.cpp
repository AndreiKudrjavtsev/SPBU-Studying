#include <iostream>
using namespace std;

int exponentiation(int base, int power)
{
	int result = 1;
	for (int i = 0; i < power; ++i)
	{
		result *= base; 
	}
	return result;
}

int fastExponentiation(int base, int power)
{
	bool *operation = new bool[power]{0};         //creating array, that checking what operation we should do:
	int k = 0;									  //increase power by one or add one to our value	
	while (power != 1)
	{
		if (power % 2 == 0)
		{
			operation[k] = true;
			power = power / 2;
		}
		else 
		{
			operation[k] = false;
			power = power - 1;
		}
		++k;
	}

	int result = base;
	for (int i = k - 1; i >= 0; --i)
	{
		if (operation[i])
			result *= result;
		else
			result *= base;
	}

	return result;
}

int main()
{
	int base = 0;
	int power = 0;
	cout << "Enter the values of base and power: " << endl;
	cin >> base >> power;
	int res = 0;
	res = exponentiation(base, power);
	cout << "Your result: " << res << endl;
	int res2 = 0;
	res2 = fastExponentiation(base, power);
	cout << "Your result: " << res2 << endl;

	return 0;
}