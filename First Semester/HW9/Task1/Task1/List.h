#pragma once 
#include <string>

using namespace std;

struct List;
struct ListElement;

typedef string ElementType;
typedef ListElement *Position;
typedef List *Hash;

List *createList();

ListElement *head(List *list);

ListElement *next(List *list, ListElement *position);

ElementType returnString(List *list, ListElement *position);

void increaseFrequency(List *list, ListElement *position);

void insert(List *list, Position position, ElementType element);

void insertAsHead(List *list, ElementType element);

void deleteElement(List *list, ElementType element);

void deleteHead(List *list);

void deleteList(List *list);

void printList(List *list);

int listSize(List *list);
