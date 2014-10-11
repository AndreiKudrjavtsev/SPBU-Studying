#include <iostream>
#include <time.h>
#include <stdlib.h>

using namespace std;

void insertionSort(int arr[], int start, int end)
{
    for (int i = start + 1; i < end; ++i)
    {
        for (int j = i; j > 0 && arr[j - 1] > arr[j]; --j)
            swap(arr[j], arr[j - 1]);
    }
}

void qSort(int arr[], int first, int last)
{
    int pivot = 0;
    int i = first;
    int j = last;
    pivot = arr[(i + j) / 2];
    do
    {
        while (arr[i] < pivot)
            ++i;
        while (arr[j] > pivot)
            --j;
        if (i <= j)
        {
            swap(arr[i], arr[j]);
            ++i;
            --j;
        }
    } while (i < j);
    if (first < j)
        qSort(arr, first, j);
    if (last > i)
        qSort(arr, i, last);
    if ((last - i) <= 10)
        insertionSort(arr, i, last + 1);
    if ((j - first) <= 10)
        insertionSort(arr, first, j + 1);
}

int main()
{
    srand(time(NULL));
    int length = 0;
    cout << "Enter the length of array: " << endl;
    cin >> length;

    int *arr = new int[length];
    cout << "Your array: " << endl;
    for (int i = 0; i < length; ++i)
    {
        arr[i] = rand() % 30;
        cout << arr[i] << " ";
    }
    cout << endl;

    qSort(arr, 0, length - 1);
    cout << "Result: " << endl;
    for (int i = 0; i < length; ++i)
        cout << arr[i] << " ";
    cout << endl;

    delete [] a;
    return 0;
}
