#include <iostream>

using namespace std;

int main()
{
	char s[1000];
	char s1[1000];
	cout << "Enter the lines: S and S1 " << endl;
	gets(s);
	gets(s1);
	int amountOfEntries = 0;
	int entryCheck = 0;
	for (int i = 0; i < (strlen(s) - strlen(s1) + 1); i++)
	{
		for (int j = 0; j < strlen(s1); j++)
		{
			{
				if (s[i + j] == s1[j])
				{
					entryCheck++;
					if (entryCheck == strlen(s1))
					{
						amountOfEntries++;
					}
				}
			}
		}
		entryCheck = 0;
	}
	cout << "Amount of entries s1 in s is: " << amountOfEntries << endl;

	return 0;
}