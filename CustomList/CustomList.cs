using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> //: IEnumerable<T>
    {
        public T[] array = new T[1];
        private int count;
        private int capacity;
        public T[] newArray;

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
            count++;
            T[] newArray;

            if (count > capacity)
            {
                capacity *= 2;
                newArray = new T[capacity];

                for (int i = 0; i < count - 1; i++)
                {
                    newArray[i] = array[i];
                }

                newArray[count - 1] = toAdd;
                array = newArray;
            }
            else
            {
                array[count - 1] = toAdd;
            }
        }

        // REMOVE
        public void Remove(T toRemove)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(toRemove))
                {
                    count--;
                    for (; i < count; i++)
                    {
                        array[i] = array[i + 1];
                    }
                    array[count] = default(T);
                    break;
                }
            }
        }

        public override string ToString()
        {
            string newString = "";

            newString = array[0].ToString();

            for(int i = 1; i < count; i++)
            {
                newString = newString + " " + array[i].ToString();
            }
            return newString;
        }

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> result;

            result = list1;
            foreach (T item in list2)
            {
                result.Add(item);
            }

            return result;
        }

        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> result = new CustomList<T>();
            if (list1.count > list2.count)
            {
                for (int i = list2.count; i < list1.count; i++)
                {
                    result.Add(list1[i]);
                }
            }
            else if (list2.count > list1.count)
            {
                for (int i = list1.count; i < list2.count; i++)
                {
                    result.Add(list2[i]);
                }
            }
            else
            {
                return result;
            }

            return result;
        }

        public CustomList<T> Zip(CustomList<T> list2)
        {
            CustomList<T> result = new CustomList<T>();
            for (int i = 0; i < count + list2.count; i++)
            {
                if (i < count)
                {
                    result.Add(array[i]);
                }
                if (i < list2.count)
                {
                    result.Add(list2[i]);
                }
            }

            return result;
        }

    }
}