#pragma once

struct TreeNode;

TreeNode *create(char value);

bool isOperator(char a);

bool isBracketOrSpace(char a);

void scanTree(TreeNode *&tree, char a[], int i);

void calculateNode(TreeNode *&tree);

void calculateTree(TreeNode *&tree);

void printTree(TreeNode *tree);

void printExp(TreeNode *tree);

void deleteTree(TreeNode *root);