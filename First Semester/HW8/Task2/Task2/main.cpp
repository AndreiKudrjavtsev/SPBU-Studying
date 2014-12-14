#include <iostream>
#include "BinaryTree.h"

using namespace std;

int main()
{
	Tree *tree = createTree();

	cout << "Choose the operation: " << endl;
	int choice = 1;
	while (choice)
	{
		cout << "0 - Exit " << endl
			 << "1 - Add integer in Set " << endl
			 << "2 - Delete value from Set " << endl
			 << "3 - Check if value exists in this Set " << endl
			 << "4 - Print Set in increasing order " << endl
			 << "5 - Print Set in decreasing order " << endl; 
		cin >> choice;
		switch (choice)
		{
		case 1:
		{
				  int value = 0;
				  cin >> value;
				  addElement(tree, value);
				  break;
		}
		case 2:
		{
				  int value = 0; 
				  cin >> value;
				  if (!elementSearch(tree, value))
				  {
					  cout << "There is no " << value << " element in tree! " << endl;
					  break;
				  }
				  else
				  {
					  deleteElement(tree, value);
					  break;
				  }
		}
		case 3:
		{
				  int value = 0;
				  cin >> value;
				  if (!elementSearch(tree, value))
				  {
					  cout << "There is no " << value << " element in tree! " << endl;
					  break;
				  }
				  else
				  {
					  cout << value << " element exists in tree " << endl;
					  break;
				  }
		}
		case 4:
		{
				  increasingPrint(tree);
				  cout << endl;
				  break;
		}
		case 5:
		{
				  decreasingPrint(tree);
				  cout << endl;
				  break;
		}
		}
	}

	deleteTree(tree);
	return 0;
}

// test: added 7, printed, deleted 7, printed, added 5, 7, 9, printed (4), printed (5)
// all correct.