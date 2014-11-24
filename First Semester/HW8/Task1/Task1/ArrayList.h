#pragma once 

typedef int ElementType;

struct ArrayList;

ArrayList *create(int choice);

int head(ArrayList *list);

int last(ArrayList *list);

int next(ArrayList *list, int position);

int middle(ArrayList *list);

int listSize(ArrayList *list);

ElementType returnValue(ArrayList *list, int position);

void insert(ArrayList *list, ElementType value, int position);

void insertAsHead(ArrayList *list, ElementType value);

void deleteElement(ArrayList *list, int position);

void deleteHead(ArrayList *list);

void deleteList(ArrayList *list);

void printList(ArrayList *list);