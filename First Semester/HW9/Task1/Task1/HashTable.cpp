#include <iostream>
#include <string>
#include "List.h"
#include "HashTable.h"

using namespace std;

HashTable *createHash()
{
	HashTable *hash = new HashTable;
	hash->hashTable = new List*[hashSize];
	for (int i = 0; i != hashSize; i++)
		hash->hashTable[i] = createList();
	return hash;
}

int hashFunction(string str)
{
	int const base = 31;
	int res = str[0];
	int length = str.length();
	for (int i = 0; i < length - 1; i++)
	{
		res = (res * base + str[i]) % hashSize;
	}
	return res;
}

void addToHashTable(HashTable *hash, string str)
{
	const int k = hashFunction(str);
	if (listSize(hash->hashTable[k]) == 0)
		insertAsHead(hash->hashTable[k], str);
	else
	{
		Position position = head(hash->hashTable[k]);
		while (position != nullptr)
		{
			if (returnString(hash->hashTable[k], position) == str)
			{
				increaseFrequency(hash->hashTable[k], position);
				break;
			}
			position = next(hash->hashTable[k], position);
		}
		if (position == nullptr)
			insertAsHead(hash->hashTable[k], str);
	}
}

void printHashTable(HashTable *hash)
{
	for (int i = 0; i < hashSize; i++)
		printList(hash->hashTable[i]);
}

void deleteHashTable(HashTable *hash)
{
	for (int i = 0; i != hashSize; i++)
		deleteList(hash->hashTable[i]);
	delete[] hash->hashTable;
	delete hash;
}