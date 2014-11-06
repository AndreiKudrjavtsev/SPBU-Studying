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
    srand(time(nullptr));

    int length = 0;
    cout << "Enter the length of array: " << endl;
    cin >> length;
    int rangeOfValues = 0;
    cout << "Enter the range of values for this array: " << endl;
    cin >> rangeOfValues;
    int *arr = new int[length];
    cout << "Your array: " << endl;
    for (int i = 0; i < length; ++i)
    {
        arr[i] = rand() % rangeOfValues;
        cout << arr[i] << " ";
    }
    cout << endl;

    qSort(arr, 0, length - 1);

    int maxAmount = 0;
    int maxIndex = 0;
    int count = 0;
    for (int i = 1; i < length; ++i)
    {
        if (arr[i - 1] == arr[i])
           ++count;
        if (count > maxAmount)
        {
            maxAmount = count;
            maxIndex = i;
        }
    }
    if (maxAmount == 0)
        cout << "There is no element, which contains more than 1 time. " << endl;
    else
        cout << "The most frequent element: " << arr[maxIndex] << endl;

    delete[] arr;
    return 0;
}

