#pragma once 
#include "ArrayList.h"
#include "PointerList.h"


typedef int Position;
typedef ArrayList List;

/*
typedef ListElement *Position;
typedef PointerList List;
*/

// сортировка слиянием
List *mergeSort(List *list);