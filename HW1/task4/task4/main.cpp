#include <iostream>

using namespace std;

int main()
{
	int a = 0;
	int b = 0;
	cout << "Enter the values for a and b: " << endl;
	cin >> a >> b;
	int result = 0;
	int aAbs = abs(a);
	int bAbs = abs(b);
	int remainderCheck = 0;
	while (aAbs >= bAbs)
	{
		aAbs = aAbs - bAbs;
		++result;
		if (aAbs == 0)
		{
			remainderCheck = 1;
		}
	}
	if (a > 0 && b > 0)
	{
		cout << "Result: " << result << endl;
	}
	if (a < 0 && b < 0)
	{
		if (remainderCheck = 1)
		{
			cout << "Result: " << result + 1 << endl;
		}
		else
		{
			result = result + 1; 
			cout << "Result: " << result << endl;
		}
	}
	if (a > 0 && b < 0)
	{
		if (remainderCheck = 0)
		{
			result = -result;
			cout << "Result: " << result << endl;
		}
		else
		{
			result = -result;
			cout << "Result: " << result << endl;
		}
	}
	if (a < 0 && b > 0)
	{
		if (remainderCheck = 0)
		{
			cout << "Result: " << -(result + 1) << endl;
		}
		else
		{
			result = -(result + 1);
			cout << "Result: " << result << endl;
		}
				
	}
	
	system("pause");
	return 0;
}

