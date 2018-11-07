using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        T[] array = new T[1];
        private int count;
        private int length;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Length
        {
            get
            {
                return length;
            }
        }

        public T this[int i]
        {
            get
            {
                return array[i];
            }
            set
            {
                array[i] = value;
            }
        }

        public CustomList()
        {
            length = 1;
            count = 0;
            array = new T[length];
        }

        public int increaseList(int length)
        {
            length = count + 1;
            T[] newArray = new T[length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
            return length;
        }

        public void Add(T v)
        {
            if (count >= length - 1)
            {
                increaseList(length);
            }
            array[count] = v;
            count++;
        }

        public bool Remove(T v)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(v))
                {
                    array[i] = array[i + 1];
                    i++;
                }
            }
            count--;
            length--;
            return true;
        }

    }
}