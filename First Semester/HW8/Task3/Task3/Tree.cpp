#include <iostream>
#include "Tree.h"

using namespace std;

struct TreeNode
{
	char value;
	double currentResult;
	TreeNode *left;
	TreeNode *right;
};

TreeNode *create(char value)
{
	TreeNode *root = new TreeNode;
	root->value = value;
	root->currentResult = (value - 48);
	root->left = nullptr;
	root->right = nullptr;
	return root;
}

bool isOperator(char a)
{
	return a == '+' || a == '-' || a == '*' || a == '/';
}

bool isBracketOrSpace(char a)
{
	return a == '(' || a == ')' || a == ' ';
}

void addNode(TreeNode *&tree, char a[], int *&i);

void calculateNode(TreeNode *&tree);

void calculateTree(TreeNode *&tree);

void printTree(TreeNode *tree)
{
	if (tree == nullptr)
		return;
	cout << tree->value << " ";
	if (tree->left != nullptr)
		cout << "(";
	printTree(tree->left);
	printTree(tree->right);
	if (tree->left != nullptr)
		cout << ")";
}

void printExp(TreeNode *tree)
{
	if (tree == nullptr)
		return;
	if (tree->left != nullptr)
		cout << "(";
	printExp(tree->left);
	cout << tree->value;
	printExp(tree->right);
	if (tree->right != nullptr)
		cout << ")";
}

void deleteTree(TreeNode *root);