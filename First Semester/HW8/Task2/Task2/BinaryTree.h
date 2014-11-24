#pragma once

struct TreeNode;

typedef int ElementType;
typedef TreeNode Tree;

//
TreeNode *createTree();

//
TreeNode *createNode(ElementType element);

//
void addElement(TreeNode *&root, ElementType element);

//
void increasingPrint(TreeNode *root);

// 
void decreasingPrint(TreeNode *root);

// 
void deleteElement(TreeNode *&root, ElementType value);

//
void deleteTree(TreeNode *root);

// 
bool elementSearch(TreeNode *root, ElementType element);