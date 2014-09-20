#include <iostream>

using namespace std;

int main()
{
	char str[1000];
	int correctionCheck = 0;
	gets(str);
	for (int i = 0; i < strlen(str); i++)
	{
		if (str[i] == '(')
			correctionCheck++;
		else if (str[i] == ')')
			correctionCheck--;

		if (correctionCheck < 0)
		{
			cout << "Error! Too many closing brackets! " << endl;
			return 0;
		}
	}
	if (correctionCheck == 0)
		cout << "You entered correct line! " << endl;
	else
		cout << "Error! Bracket balance isn't correct! " << endl;

	return 0;
}