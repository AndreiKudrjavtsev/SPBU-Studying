using System;

namespace newHash
{
    public class ModifiedHash<T>
    {
        private MyList<T>[] hashSet;
        private int tableSize;
        private Func<T, int> HashFunc;
        
        /// <summary>
        /// table constructor with hash function and table size as params
        /// </summary>
        /// <param name="tableSize"></param>
        /// <param name="HashFunc"></param>
        public ModifiedHash(int tableSize, Func<T, int> HashFunc)
        {
            this.tableSize = tableSize;
            this.HashFunc = HashFunc;
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
            HashFunc = newHashFunc;
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
                    int key = GetHash(tmp.value);
                    newHashSet[key].InsertAsHead(tmp.value);
                    tmp = tmp.next;
                }
            }
            hashSet = newHashSet;
        }

        public int GetHash(T element)
        {
            return HashFunc(element);
        }

        /// <summary>
        /// Function, adding element in hashtable 
        /// </summary>
        /// <param name="element"></param>
        public void AddToHashTable(T element)
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
        public bool IsContains(T element)
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
        public void DeleteFromHashTable(T element)
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
