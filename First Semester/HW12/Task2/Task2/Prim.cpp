#include <iostream>
#include <fstream>
#include <algorithm>

using namespace std;

int const inf = 1000;

int main()
{
	cout << "Minimal spanning tree: " << endl;

	ifstream in("input.txt");
	int n = 0; 
	in >> n;
	int **matrix = new int*[n];
	bool *verticeIsAdded = new bool[n];
	int *minDist = new int[n];
	int *addedEdges = new int[n];

	for (int i = 0; i < n; i++)
	{
		verticeIsAdded[i] = false;
		matrix[i] = new int[n];
	}
	for (int i = 0; i < n; i++)
	for (int j = 0; j < n; j++)
		in >> matrix[i][j];
	in.close();

	//если пути между вершинами нет, обозначем его как inf
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			if (matrix[i][j] == 0)
				matrix[i][j] = inf;
		}
	}
	
	//в маcсиве минимальных расстояний от вершины до остова изначально задаем все эл-ты как inf
	for (int i = 0; i < n; i++)
		minDist[i] = inf;

	//массив добавленных ребер изначально будет выглядеть след образом addedEdges[i] = x
	//где i - вершина начала ребра, х - вершина конца ребра
	//изначально инизиализируем все значения массива -1
	for (int i = 0; i < n; i++)
		addedEdges[i] = -1;

	//добавляем первую вершину в остов
	verticeIsAdded[0] = true;

	//пересчитываем минимальные расстояния
	for (int i = 0; i < n; i++) {
		minDist[i] = min(minDist[i], matrix[0][i]);
		if (matrix[0][i] != inf)
			addedEdges[i] = 0;
	}

	for (int i = 0; i < n - 1; i++)
	{
		int v = -1;
		for (int j = 0; j < n; j++)
		{
			if (!verticeIsAdded[j] && (v == -1 || minDist[j] < minDist[v]))
				v = j;
		}
		if (minDist[v] == inf)
		{
			cout << "Incorrect input!" << endl;
			return 0;
		}

		verticeIsAdded[v] = true;
		if (addedEdges[v] != -1)
			cout << addedEdges[v] << " " << v << endl;

		for (int k = 0; k < n; k++)
		{
			if (matrix[v][k] < minDist[k])
			{
				minDist[k] = matrix[v][k];
				addedEdges[k] = v;
			}
		}
	}

	cout << endl;
	system("pause");
	return 0;
}
//ответ выводится на консоль в виде перечисления ребер оставного дерева