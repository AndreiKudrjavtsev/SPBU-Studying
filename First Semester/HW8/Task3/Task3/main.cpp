#include <iostream>
#include <fstream>
#include "Tree.h"

using namespace std;

int main()
{
	ifstream in("input.txt");
	char str[1000];
	in.getline(str, 1000);
	in.close();

	cout << "Source expression: " << endl << str << endl;

	TreeNode *tree;
	int i = 0;

	scanTree(tree, str, i);

	cout << "Converted expression: " << endl;
	printTree(tree);
	cout << endl;

	calculateTree(tree);
	cout << "Result: " << endl << returnResult(tree) << endl;

	deleteTree(tree);

	return 0;
}
//tests: (* (+ 1 1) 2) ==> * ( + ( 1 1 ) 2 ) = 4 - correct
//       * ((/ (+ 0 3) 3) 7 ) ==> * ( / ( + ( 0 3 ) 3 ) 7 ) = 7 - correct