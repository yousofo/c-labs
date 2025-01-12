using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class CustomStack<T>
    {
        T[] elements;
        int top;
        int maxSize;

        // Constructor
        public CustomStack(int size)
        {
            maxSize = size;
            elements = new T[size];
            top = -1;
        }

        // Push 
        public void Push(T item)
        {
            if (top == maxSize - 1)
            {
                Console.WriteLine("Stack Is Full");
                return;
            }
            elements[++top] = item;
        }

        // Pop 
        public T Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Is Empty");
            }
            return elements[top--];
        }

        // Display
        public void Display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Console.WriteLine("Stack Elements :-");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}
