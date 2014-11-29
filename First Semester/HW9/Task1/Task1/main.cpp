#include <iostream>
#include <fstream>
#include <string>
#include "HashTable.h"

using namespace std;

int main()
{
	HashTable *hashTable = createHash();

	ifstream in("input.txt");
	string str;
	while (!in.eof())
	{
		in >> str;
		addToHashTable(hashTable, str);
	}
	printHashTable(hashTable);
	deleteHashTable(hashTable);

	return 0;
}