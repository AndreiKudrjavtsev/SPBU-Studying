#include <iostream>
#include <time.h>
using namespace std;

int recFibNums(int fibNumber)
{
	if (fibNumber <= 1)
		return fibNumber;
	else
	{
		return recFibNums(fibNumber - 1) + recFibNums(fibNumber - 2);
	}
}

int iterFibNums(int fibNumber)
{
	int fibNum1 = 0;
	int fibNum2 = 1;
	int newFib = 0;
	if (fibNumber <= 1)
		return fibNumber;
	else
	{
		for (int i = 1; i < fibNumber; ++i)
		{
			newFib = fibNum1 + fibNum2;
			fibNum1 = fibNum2;
			fibNum2 = newFib;
		}
		return newFib;
	}
}

int main()
{
	int res = 0;
	int fibNum = 0;
	cout << "Enter the number of Fibonacci sequence, which you want to calculate: " << endl;
	cin >> fibNum;
	
	clock_t startRec = clock();
	res = recFibNums(fibNum);
	clock_t endRec = clock();
	cout << "Your value: " << res << endl;
	cout << "Time of recursive calculating: " << (double)(endRec - startRec) / (double)CLOCKS_PER_SEC << endl;
	clock_t startIter = clock();
	res = iterFibNums(fibNum);
	clock_t endIter = clock();
	cout << "Time of iterative calculating: " << (double)(endIter - startIter) / (double)CLOCKS_PER_SEC << endl;

	return 0;
}