#include <iostream>
#include <fstream>

using namespace std;

int main()
{
	ifstream file("file.txt");
	char str[1000];
	
	int amountOfStrings = 0;
	while (!file.eof())
	{
		file.getline(str, 100);
		cout << str << endl;
		for (int i = 0; str[i] != '\0'; i++)
		{
			if (str[i] != ' ' && str[i] != '\t')
			{
				amountOfStrings++;
				break;
			}
		}
	}
	cout << "Result: " << amountOfStrings << endl;
	file.close();
	return 0;
}