#pragma once

struct TreeNode;

typedef int ElementType;
typedef TreeNode Tree;

//функция создания дерева
TreeNode *createTree();

//функция создания узла
TreeNode *createNode(ElementType element);

//функция добавления эл-та 
void addElement(TreeNode *&root, ElementType element);

//функция печати в возрастающем порядке
void increasingPrint(TreeNode *root);

//функция печати в убывающем порядке
void decreasingPrint(TreeNode *root);

//функция удаления эл-та
void deleteElement(TreeNode *&root, ElementType value);

//функция удаления дерева
void deleteTree(TreeNode *root);

//функция поиска эл-та в дереве
bool elementSearch(TreeNode *root, ElementType element);