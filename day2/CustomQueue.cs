using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{

    internal class CustomQueue<T>
    {
        T[] elements;
        int front;
        int rear;
        int size;


        public CustomQueue(int capacity)
        {
            elements = new T[capacity];
            front = 0;
            rear = -1;
            size = 0;
        }

        public void Enqueue(T item)
        {
            if (size == elements.Length)
            {
                Console.WriteLine("Queue Is Full");
            }
            rear = rear + 1;
            elements[rear] = item;
            size++;
        }

        public T Dequeue()
        {
            if (size == 0)
            {
                Console.WriteLine("Queue Is Empty");
            }
            T item = elements[front];
            front = front + 1;
            size--;
            return item;
        }

        public void Display()
        {
            if (size == 0)
            {
                Console.WriteLine("Queue Is Empty.");
                return;
            }
            Console.WriteLine("Queue Elements:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(elements[front + i]);
            }
        }
    }
}
