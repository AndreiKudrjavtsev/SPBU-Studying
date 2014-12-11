#include <iostream>
#include <fstream>
#include <algorithm>

using namespace std;

//�������, ����������� �������������� ������ � ������-���� �����������
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

	//������� ������� ���������, ������� ����� ������� ������ ����� ��������
	//���� ������ �� ���������� ������ -1.
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
	//��������� �������
	for (int i = 0; i < m; ++i)
	{
		in >> a >> b >> len;
		roads[a][b] = len;
		roads[b][a] = len;
	}

	//������, ������� �������� ���������� � �������������� ������ ���� ��� ����� ����������� 
	//-1 - �������������� �������� ���-��
	int *country = new int[n];
	for (int i = 0; i < n; ++i)
		country[i] = -1;

	int k = 0;
	in >> k;
	//������� ������ ������
	int *capitals = new int[k];
	for (int i = 0; i < k; ++i)
	{
		in >> capitals[i];
		country[capitals[i]] = capitals[i]; //������� ���������� ����������� ������ �����������
	}
	
	in.close();

	//�������� ��� ������ � ����� ����� �������� �������� 1000
	int minDistance = 1000;
	int closestCityIndex = 0;
	//��������� ��������� ������
	while (cityDoesNotBelongCountry(country, n))
	{
		//����� �� ������������
		for (int i = 0; i < k && cityDoesNotBelongCountry(country, n); i++)
		{
			//���� ������, ������������� ����� ���-��
			for (int j = 0; j < n; j++)
			{
				if (country[j] == capitals[i])
				{
					//��������� ���������� �� �������
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