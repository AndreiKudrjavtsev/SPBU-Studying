using System;
using HW2_List;

namespace HW2_HashTable
{
    class HashTable
    {
        private List<string>[] hashSet;
        private int tableSize;
        
        public HashTable(int tableSize)
        {
            this.tableSize = tableSize;
            hashSet = new List<string>[tableSize];
            for (int i = 0; i < tableSize; ++i)
            {
                hashSet[i] = new List<string>();
            }
        }
        
        /// <summary>
        /// Hash function 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private int HashFunction(string str)
        {
            const int basis = 31;
            int result = str[0];
            int length = str.Length;
            for (int i = 0; i < length - 1; ++i)
            {
                result = (result * basis + str[i]) % tableSize;
            }
            return result; 
        }

        /// <summary>
        /// Function, getting hash of element
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private int GetHash (string element)
        {
            return HashFunction(element);
        }

        /// <summary>
        /// Function, adding element in hashtable 
        /// </summary>
        /// <param name="element"></param>
        public void AddToHashTable(string element)
        {
            if (!IsContains(element))
            {
                int key = GetHash(element);
                hashSet[key].InsertAsHead(element);
            }
        }

        /// <summary>
        /// Function, checking the content of element in hashstable
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool IsContains(string element)
        {
            int key = GetHash(element);
            if (hashSet[key].IsContains(element))
                return true;
            return false;
        }

        /// <summary>
        /// Function, deleting element from hashtable by value 
        /// </summary>
        /// <param name="element"></param>
        public void DeleteFromHashTable(string element)
        {
            int key = GetHash(element);
            if (IsContains(element))
            {
                hashSet[key].DeleteByValue(element);
            }
        }

        /// <summary>
        /// Function, printing hashtable
        /// </summary>
        public void PrintHashTable()
        {
            for (int i = 0; i < tableSize; ++i)
            {
                hashSet[i].PrintList();
            }
        }
    }
}
