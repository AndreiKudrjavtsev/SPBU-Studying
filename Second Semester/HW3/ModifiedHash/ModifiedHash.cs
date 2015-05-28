using System;

namespace NewHash
{
    public class ModifiedHash<T>
    {
        private MyList<T>[] hashSet;
        private int tableSize;
        private Func<T, int> hashFunc;
        
        /// <summary>
        /// table constructor with hash function and table size as params
        /// </summary>
        /// <param name="tableSize"></param>
        /// <param name="hashFunc"></param>
        public ModifiedHash(int tableSize, Func<T, int> hashFunc)
        {
            this.tableSize = tableSize;
            this.hashFunc = hashFunc;
            hashSet = new MyList<T>[tableSize];
            for (int i = 0; i < tableSize; ++i)
            {
                hashSet[i] = new MyList<T>();
            }
        }

        /// <summary>
        /// method, changing hash function in table
        /// </summary>
        /// <param name="newHashFunc"></param>
        public void ChangeHashFunc(Func<T, int> newHashFunc)
        {
            hashFunc = newHashFunc;
            MyList<T>[] newHashSet = new MyList<T>[tableSize];
            for (int i = 0; i < tableSize; i++)
            {
                newHashSet[i] = new MyList<T>();
            }
            for (int i = 0; i < tableSize; i++)
            {
                var tmp = hashSet[i].head;
                while (tmp != null)
                {
                    int key = hashFunc(tmp.value);
                    newHashSet[key].InsertAsHead(tmp.value);
                    tmp = tmp.next;
                }
            }
            hashSet = newHashSet;
        }

        /// <summary>
        /// Function, adding element in hashtable 
        /// </summary>
        /// <param name="element"></param>
        public void AddToHashTable(T element)
        {
            if (!IsContains(element))
            {
                int key = hashFunc(element);
                hashSet[key].InsertAsHead(element);
            }
        }

        /// <summary>
        /// Function, checking the content of element in hashstable
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool IsContains(T element)
        {
            int key = hashFunc(element);
            return hashSet[key].IsContains(element);
        }

        /// <summary>
        /// Function, deleting element from hashtable by value 
        /// </summary>
        /// <param name="element"></param>
        public void DeleteFromHashTable(T element)
        {
            int key = hashFunc(element);
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
