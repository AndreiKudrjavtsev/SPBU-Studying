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

void scanTree(TreeNode *&tree, char a[], int &i)
{
	if (isBracketOrSpace(a[i]))
	{
		i++;
		scanTree(tree, a, i);
	}

	else if (a[i] != '\n')
	{
		if (isOperator(a[i]))
		{
			tree = create(a[i]);
			i++;
			scanTree(tree->left, a, i);
			scanTree(tree->right, a, i);
		}

		else
		{
			tree = create(a[i]);
			i++;
		}
	}
	else
		return;
}

void calculateNode(TreeNode *&tree)
{
	double res = 0;
	switch (tree->value)
	{
		case '+':
		{
					res = tree->left->currentResult + tree->right->currentResult;
					break;
		}
		case '-':
		{
					res = tree->left->currentResult - tree->right->currentResult;
					break;
		}
		case '*':
		{
					res = tree->left->currentResult * tree->right->currentResult;
					break;
		}
		case '/':
		{
					res = tree->left->currentResult / tree->right->currentResult;
					break;
		}
	}
	delete tree->left;
	delete tree->right;
	tree->left = nullptr;
	tree->right = nullptr;
	tree->value = '0';
	tree->currentResult = res;
}

void calculateTree(TreeNode *&tree)
{
	if (isOperator(tree->value))
	{
		if (!isOperator(tree->right->value) && !isOperator(tree->left->value))
			calculateNode(tree);
		else
		{
			if (isOperator(tree->left->value))
				calculateTree(tree->left);
			if (isOperator(tree->right->value))
				calculateTree(tree->right);
			calculateTree(tree);
		}
	}
}

void printTree(TreeNode *tree)
{
	if (tree == nullptr)
		return;
	cout << tree->value << " ";
	if (tree->left != nullptr)
		cout << "(" << " ";
	printTree(tree->left);
	printTree(tree->right);
	if (tree->left != nullptr)
		cout << ")" << " ";
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

void deleteTree(TreeNode *root)
{
	if (!root)
		return;
	
	if (root->left != nullptr)
		deleteTree(root->left);
	if (root->right != nullptr)
		deleteTree(root->right);
	delete root;
}

double returnResult(TreeNode *&tree)
{
	return tree->currentResult;
}