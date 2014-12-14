#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	string str;
	char tmp = '\0';

	ifstream in("input.txt");
	//считываем с пробелами
	in.unsetf(ios::skipws);
	while (in >> tmp)
		str += tmp;
	in.close();

	cout << "Source string: " << endl << str << endl;
	string sample; 
	cout << endl << "Enter the sample: " << endl;
	getline(cin, sample);
	
	str = sample + '#' + str;
	int *prefix = new int[str.length()];
	prefix[0] = 0;

	cout << "Position of entrie: " << endl;
	for (int k = 0, i = 1; i < str.length(); i++)
	{
		while (k > 0 && str[i] != str[k])
			k = prefix[k - 1];

		if (str[i] == str[k])
			k++;

		prefix[i] = k;

		if (prefix[i] == sample.length())
		{
			cout << i - 2 * sample.length() << endl; 
			break;
		}
	}

	delete[] prefix;
	system("pause");
	return 0;
}