#pragma once 

#include <string>
#include "List.h"

using namespace std;

int const hashSize = 1000;

struct HashTable
{
	List **hashTable;
};

HashTable *createHash();

void addToHashTable(HashTable *hash, string str);

void printHashTable(HashTable *hash);

void deleteHashTable(HashTable *hash);