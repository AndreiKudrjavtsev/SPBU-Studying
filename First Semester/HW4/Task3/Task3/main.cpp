#include <iostream>
#include <fstream>
#include <string>
#include <vector>

using namespace std;

int main()
{
	ifstream file("../file.txt", ios::in);
	if (!file.is_open())
	{
		cout << "File not found!" << endl;
		return 1;
	}

	vector<string> data;

	while (!file.eof()) {
		string buffer;
		file >> buffer;
		data.push_back(buffer);
	}

	file.close();

	int amountOfStrings = 0;

	for (string const &line : data)
	{
		cout << line << endl;
		for (int i = 0; line[i] != '\0'; ++i)
		{
			if (line[i] != ' ' && line[i] != '\t')
			{
				++amountOfStrings;
				break;
			}
		}
	}

	cout << "Result: " << amountOfStrings << endl;

	return 0;

}