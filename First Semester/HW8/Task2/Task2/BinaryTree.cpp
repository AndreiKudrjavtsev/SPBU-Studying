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
}