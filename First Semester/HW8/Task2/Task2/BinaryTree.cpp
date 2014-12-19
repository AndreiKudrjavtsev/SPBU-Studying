#include <iostream>
#include "BinaryTree.h"

using namespace std;

struct TreeNode
{
	ElementType value;
	Tree *left;
	Tree *right;
};

TreeNode *createTree()
{
	return nullptr;
}

TreeNode *createNode(ElementType element)
{
	TreeNode *root = new TreeNode;
	root->value = element;
	root->left = nullptr;
	root->right = nullptr;
	return root;
}

void addElement(TreeNode *&root, ElementType element)
{
	if (elementSearch(root, element))
		return;

	if (root == nullptr)
		root = createNode(element);
	else if (root->value > element)
		addElement(root->left, element);
	else if (root->value <= element)
		addElement(root->right, element);
}

void increasingPrint(TreeNode *root)
{
	if (root != nullptr)
	{
		increasingPrint(root->left);
		cout << root->value << " ";
		increasingPrint(root->right);
	}
}
 
void decreasingPrint(TreeNode *root)
{
	if (root != nullptr)
	{
		decreasingPrint(root->right);
		cout << root->value << " ";
		decreasingPrint(root->left);
	}
}
 
void deleteElement(TreeNode *&root, ElementType value)
{
	if (root == nullptr)
		return;

	if (!elementSearch(root, value))
		return;

	if (root->value < value)
		deleteElement(root->right, value);
	else if (root->value > value)
		deleteElement(root->left, value);
	else if (root->left == nullptr && root->right == nullptr)
	{
		delete root;
		root = nullptr;
	}
	else if (root->left == nullptr)
	{
		TreeNode *tmp = root;
		root = root->right;
		delete tmp;
	}
	else if (root->right == nullptr)
	{
		TreeNode *tmp = root;
		root = root->left;
		delete tmp;
	}
	else
	{
		TreeNode *tmp = root->right;
		if (tmp->left == nullptr)
		{
			int element = tmp->value;
			deleteElement(tmp, tmp->value);
			root->value = element;
		}
		else
		{
			while (tmp->left->left != nullptr)
				tmp = tmp->left;
			int element = tmp->left->value;

			deleteElement(tmp, tmp->left->value);
			root->value = element;
		}
	}

}

void deleteTree(TreeNode *root)
{
	if (root == nullptr)
		return;
	if (root->left != nullptr)
		deleteTree(root->left);
	if (root->right != nullptr)
		deleteTree(root->right);
	delete root;
}
 
bool elementSearch(TreeNode *root, ElementType element)
{
	if (root == nullptr)
		return false;

	if (root->value == element)
		return true;
	else if (root->value > element)
		elementSearch(root->left, element);
	else if (root->value < element)
		elementSearch(root->right, element);
	else
		return false;
}