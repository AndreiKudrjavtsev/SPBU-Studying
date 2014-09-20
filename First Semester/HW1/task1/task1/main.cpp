#include <iostream>

using namespace std;

int main()
{
	int x = 0;
	cout << "Enter the value of x: ";
	cin >> x;
	int sqrOfX = x * x;
	cout << "Result: " << (sqrOfX + x) * (sqrOfX + 1) + 1 << endl;

	system("pause");
	return 0;
}