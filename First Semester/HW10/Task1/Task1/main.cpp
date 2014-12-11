#include <iostream>
#include <fstream>
#include <algorithm>

using namespace std;

//функция, проверяющая принадлежность города к какому-либо государству
bool cityDoesNotBelongCountry(int *array, int amount)
{
	for (int i = 0; i < amount; ++i)
	{
		if (array[i] == -1)
			return true;
	}
	return false;
}

int main()
{
	ifstream in("input.txt");
	int n = 0;
	in >> n;

	//создаем матрицу смежности, которая будет хранить дороги между городами
	//если дороги не существует вводим -1.
	int **roads = new int *[n];
	for (int i = 0; i < n; ++i)
	{
		roads[i] = new int[n];
		for (int j = 0; j < n; ++j)
			roads[i][j] = -1;
	}

	int m = 0;
	in >> m;

	int a = 0;
	int b = 0;
	int len = 0;
	//заполняем матрицу
	for (int i = 0; i < m; ++i)
	{
		in >> a >> b >> len;
		roads[a][b] = len;
		roads[b][a] = len;
	}

	//массив, который содержит информацию о принадлежности города тому или иному государству 
	//-1 - принадлежность никакому гос-ву
	int *country = new int[n];
	for (int i = 0; i < n; ++i)
		country[i] = -1;

	int k = 0;
	in >> k;
	//создаем массив столиц
	int *capitals = new int[k];
	for (int i = 0; i < k; ++i)
	{
		in >> capitals[i];
		country[capitals[i]] = capitals[i]; //столица изначально принадлежит своему государству
	}
	
	in.close();

	//полагаем все дороги в нашем графе заведомо меньшими 1000
	int minDistance = 1000;
	int closestCityIndex = 0;
	//добавляем незанятые города
	while (cityDoesNotBelongCountry(country, n))
	{
		//бежим по государствам
		for (int i = 0; i < k && cityDoesNotBelongCountry(country, n); i++)
		{
			//ищем города, принадлежащие этому гос-ву
			for (int j = 0; j < n; j++)
			{
				if (country[j] == capitals[i])
				{
					//добавляем ближайшего из соседей
					for (int l = 0; l < n; l++)
					{
						if (roads[j][l] < minDistance && roads[j][l] != -1 && country[l] == -1)
						{
							minDistance = roads[j][l];
							closestCityIndex = l;
						}
					}
				}
			}
			country[closestCityIndex] = capitals[i];
			minDistance = 1000;
		}
	}

	cout << "City belonging to country (cities going one by one): " << endl;
	for (int i = 0; i < n; i++)
		cout << country[i] << " ";
	cout << endl;

	for (int i = 0; i < n; ++i)
		delete[] roads[i];
	delete[] roads;
	

	return 0;
}
// test is in "input.txt" file - working correctly