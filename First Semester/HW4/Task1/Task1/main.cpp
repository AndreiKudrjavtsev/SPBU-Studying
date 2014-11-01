#include <iostream>

using namespace std;

void decimalToBinary(bool arr[], int number)
{
	int mask = 1;
	for (int i = sizeof(int)* 8 - 1; i >= 0; i--)
	{
		arr[i] = number & mask;
		mask = mask << 1;
	}
}

int binaryToDecimal(bool arr[])
{
	int temp = 1;
	int res = 0;
	for (int i = sizeof(int)* 8 - 1; i >= 0; --i)
	{
		res += temp * arr[i];
		temp *= 2;
	}
	return res;
}

void binarySum(bool num1[], bool num2[], bool sum[])
{
	bool temp = 0;
	for (int i = sizeof(int)* 8 - 1; i >= 0; --i)
	{
		sum[i] = (num1[i] + num2[i] + temp) % 2;
		temp = (num1[i] + num2[i] + temp) > 1;
	}
}

void binaryOutput(bool a[])
{
	for (int i = 0; i < sizeof(int)* 8; ++i)
		cout << a[i];
	cout << endl;
}

int main()
{
	setlocale(LC_ALL, "Russian");

	int a = 0;
	int b = 0;
	bool *num1 = new bool [sizeof(int)* 8];
	bool *num2 = new bool [sizeof(int)* 8];
	cout << "Введите два десятичных числа: " << endl;
	cin >> a >> b;
	decimalToBinary(num1, a);
	decimalToBinary(num2, b);
	cout << "Их двоичное представление: " << endl;
	binaryOutput(num1);
	binaryOutput(num2);

	bool *sum = new bool[sizeof(int)* 8];
	binarySum(num1, num2, sum);
	cout << "Сумма в двоичном виде: " << endl;
	binaryOutput(sum);
	int res = 0;
	res = binaryToDecimal(sum);
	cout << "Сумма в десятичном виде: " << endl << res << endl;

	delete[] num1;
	delete[] num2;
	delete[] sum;
	return 0;
}