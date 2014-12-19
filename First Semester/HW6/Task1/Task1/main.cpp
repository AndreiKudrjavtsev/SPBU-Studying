#include <iostream>
#include <fstream>
#include <locale.h>

using namespace std;

struct PhoneBook
{
	char name[50];
	char number[15];
};

void searchName(PhoneBook book[], int sizeOfBook)
{
	char name[50];
	cout << "¬ведите искомое им€: " << endl;
	cin >> name;
	bool tmp = false;
	for (int i = 0; i < sizeOfBook; ++i)
	{
		if (book[i].name == name)
		{
			cout << book[i].number << endl;
			tmp = true;
		}
	}
	if (!tmp)
		cout << "Ћюдей с таким именем не найдено. " << endl;
}

void searchNumber(PhoneBook book[], int sizeOfBook)
{
	char number[15];
	cout << "¬ведите искомый номер: " << endl;
	cin >> number;
	bool tmp = false;
	for (int i = 0; i < sizeOfBook; ++i)
	{
		if (book[i].number == number)
		{
			cout << book[i].name << endl;
			tmp = true;
		}
	}
	if (!tmp)
		cout << "Ћюдей с таким номером телефона не найдено. " << endl;
}

void addBookInFile(PhoneBook book[], int size, int sizeOfFile)
{
	ofstream file;
	file.open("database.txt", ios::out);
	for (int i = 0; i < size; ++i)
	{
		file << book[i].name << endl;
		file << book[i].number << endl;
	}
	file.close();
}

int main()
{
	setlocale(LC_ALL, "Russian");
	PhoneBook book[50];
	int size = 0;
	ifstream file("database.txt");
	if (file)
	{
		while (!file.eof())
		{
			file >> book[size].name;
			file >> book[size].number;
			++size;
		}
	}
	file.close();
	int sizeOfFile = size;
	int choice = 1;
	while (choice)
	{
		cout << "0 - выйти " << endl
			<< "1 - добавить запись (им€ и телефон) " << endl
			<< "2 - найти телефон по имени " << endl
			<< "3 - найти им€ по телефону " << endl
			<< "4 - сохранить текущие данные в файл " << endl;
		cin >> choice;
		switch (choice)
		{
			case 1:
			{
				cout << "¬ведите им€: " << endl;
				cin >> book[size].name;
				cout << "¬ведите номер: " << endl;
				cin >> book[size].number;
				++size;
				break;
			}
			case 2:
			{
				searchName(book, size);
				break;
			}
			case 3:
			{
				searchNumber(book, size);
				break;
			}
			case 4:
			{
				addBookInFile(book, size, sizeOfFile);
				break;
			}
		}
	}

	return 0;
}