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
        public int Count
        {
            get
            {
                return count;
            }
        }
        private int count;

        
        public int Length
        {
            get
            {
                return length;
            }
        }
        private int length;

        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    return array[i];
                }
            }
            set
            {
                if (i < 0 || i >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    array[i] = value;
                }
            }
        }



        public CustomList()
        {
            length = 1;
            count = 0;
            array = new T[length];
        }

        public void Add(T toAdd)
        {
            if (count >= length - 1)
            {
                increaseList(length);
            }
            array[count] = toAdd;
            count++;
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
    }
}