using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class MyList<T>
    {
        T[] arr;
        int size;
        int lastIndex;

        public MyList(int _size = 5)
        {
            lastIndex = -1;
            size = _size;
            arr = new T[size];
        }
        public void print()
        {
            for (int i = 0; i <= lastIndex; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public void Add(T ele)
        {
            if (lastIndex < size - 1)
            {
                lastIndex++;
                arr[lastIndex] = ele;
            }
            else
            {
                Console.WriteLine("Array Is Full");
            }
        }
        public void Clear()
        {
            lastIndex = -1;
        }
        public void Remove(T ele)
        {
            for (int i = 0; i <= lastIndex; i++)
            {
                if (ele.Equals(arr[i]))
                {
                    for (int j = i; j < lastIndex; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    lastIndex--;
                    break;
                }
            }
        }

    }
}
