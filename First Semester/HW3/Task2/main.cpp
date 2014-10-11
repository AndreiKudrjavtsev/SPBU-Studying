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

bool elementSearch (int a[], int start, int end, int k)
{
    if (k == start || k == end)
        return true;
    while (start != end)
    {
        if (k > a[(start + end) / 2])
        {
            start = (start + end) / 2 + 1;
            elementSearch(a, start, end, k);
        }
        if (k < a[(start + end) / 2])
        {
            end = (start + end) / 2;
            elementSearch(a, start, end, k);
        }
        if (k == a[(start + end) / 2])
            return true;
    }
    return false;
}

int main()
{
    int n = 0;
    cout << "Enter the length of array: " << endl;
    cin >> n;
    int k = 0;
    cout << "Enter the amount of numbers: " << endl;
    cin >> k;

    int *a = new int[n];
    cout << "Your array: " << endl;
    for (int i = 0; i < n; ++i)
    {
        a[i] = rand() % 100;
        cout << a[i] << " ";
    }
    cout << endl;

    qSort(a, 0, n - 1);

    for (int i = 0; i < k; ++i)
    {
        int t = rand() % 100;
        if (elementSearch(a, 0, n, t))
            cout << "There is a " << t <<" value in this array. " << endl;
        else
            cout << "There is not any " << t <<" value in this array. " << endl;
    }

    delete []a;
    return 0;
}

