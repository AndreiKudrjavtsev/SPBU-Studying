#include <iostream>
#include <fstream>
#include <algorithm>

using namespace std;

//������� ����������� ��� ������� ������ ������������� ������ �� ������� ������
bool roadIsExisting(int *array, int amount)
{
	for (int i = 0; i < amount; ++i)
	{
		if (array[i] != -1)
			return true;
	}
	return false;
}

//���������� ��������� ������ ������ ���������� ���������� ����� ��������� �����
void Floyd(int **matrix, int vertexAmount)
{
	for (int k = 0; k < vertexAmount; ++k)
	{
		for (int i = 0; i < vertexAmount; ++i)
		{
			for (int j = 0; j < vertexAmount; ++j)
			{
				if ((matrix[i][j] == -1) && (matrix[i][k] == -1) && (matrix[k][j] == -1))
					j++;
				else if ((matrix[i][k] == -1) || (matrix[k][j] == -1))
					j++;
				else
					matrix[i][j] = min(matrix[i][j], matrix[i][k] + matrix[k][j]);
			}
		}
	}
}

int main()
{
	ifstream in("input.txt");
	int n = 0;
	in >> n;

	//������� ������� ���������, ������� ����� ������� ������ ����� ��������
	//���� ������ �� ���������� ������ -1 
	int **roads = new int *[n];
	for (int i = 0; i < n; ++i)
	{
		roads[i] = new int[n];
		for (int j = 0; j < n; ++i)
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
	for (int i = 0; i < n; ++i)
	{
		in >> capitals[i];
		country[capitals[i]] = capitals[i]; //������� ���������� ����������� ������ �����������
	}
	
	in.close();

	//Floyd(roads, n);
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
			cout << roads[i][j] << " ";
		cout << endl;
	}

	for (int i = 0; i < n; ++i)
		delete[] roads[i];
	delete[] roads;
	
	return 0;
}