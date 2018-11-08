using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        public T[] array = new T[1];
        private int count;
        private int capacity;

        // COUNT
        public int Count
        {
            get { return count; }
        }

        // CAPACITY
        public int Capacity
        {
            get { return capacity; }
        }

        // INDEXER
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

        public CustomList()
        {
            capacity = 4;
            array = new T[capacity];
            count = 0;
        }

        // ADD
        public void Add(T toAdd)
        {
            if (count >= capacity - 1)
            {
                increaseList(capacity);
            }
            array[count] = toAdd;
            count++;
        }

        public int increaseList(int capacity)
        {
            capacity = count + 1;
            T[] newArray = new T[capacity];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
            return capacity;
        }

        // REMOVE
        public bool Remove(T toRemove)
        {
            bool removeCheck = false;

            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(toRemove))
                {
                    array[i] = array[i + 1];
                    i++;
                    for (int j = i; j < count; j++)
                    {
                        array[j] = array[j + 1];
                        removeCheck = true;
                        count--;
                    }
                }
                else
                {
                }
            }
            return removeCheck;
        }
    }
}