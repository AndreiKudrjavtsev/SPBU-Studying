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
	bool remainderCheck = false;
	while (aAbs >= bAbs)
	{
		aAbs = aAbs - bAbs;
		++result;
		if (aAbs == 0)
		{
			remainderCheck = true;
		}
	}
	if (a < 0 && b > 0)
	{
		if (remainderCheck == false)
		{
			result = -(result + 1);
		}
		else
		{
			result = -result;
		}
	}
	else if (a < 0 && b < 0)
	{
		if (remainderCheck == false)
		{
			result++;
		}
	}
	else if (a > 0 && b < 0)
	{
		result = -result;
	}

	cout << "Result: " << result << endl;

	return 0;
}

