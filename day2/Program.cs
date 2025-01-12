using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;
using Utils;

namespace day2
{
    internal class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }


        static void Main(string[] args)
        {
            #region teasks
            //complex: IComparable
            //series
            //swap<>
            //try list
            //mylist
            //queue<>,stack<>
            //sorted set
            //sorted list
            //dictionary
            //hash list
            //
            // create class inherit from List<> to create new implementation of 'Add' Method , when calling this method it call the original 'Add' and then write into 'file'
            // + read method to read from the file and put into the list in memory 
            // + remove from both of the list and file
            #endregion
            
            #region swap

            Printing.PrintLine();

            int swap1 = 1, swap2 = 2;
            Console.WriteLine($"swap1: ${swap1}, swap2: {swap2}");

            Swap(ref swap1, ref swap2);
            Console.WriteLine($"swap1: ${swap1}, swap2: {swap2}");

            #endregion

            #region normal List

            Printing.PrintLine();

            List<int> list = [1, 2, 3, 4, 5];

            list.Add(6);
            list.AddRange([7, 8, 9]);
            list.Insert(0, 0);

            Printing.PrintList(list);

            list.Remove(0);
            list.RemoveAt(0);
            list.RemoveRange(0, 2);

            Printing.PrintList(list);



            list.Sort();
            Printing.PrintList(list);

            list.Reverse();
            Printing.PrintList(list);

            list.Clear();

            #endregion

            #region complex: IComparable

            ComplexNumber c1 = new(1, 2);
            ComplexNumber c2 = new(3, 4);

            var complexList = new List<ComplexNumber>();
            complexList.AddRange([c1,c2]);



            Console.WriteLine(c1.CompareTo(c2));//-1

            #endregion

            #region stored list

            Printing.PrintLine();

            var slist1 = new StoredList();
            slist1.Display();

            slist1.Add(new DataDto { Name = "Ahmed", Age = 20 });
            slist1.Display();

            slist1.Remove(new DataDto { Name = "Ahmed", Age = 20 });
            slist1.Display();

            #endregion

            //hashset Dictionary
            #region trying

            ///hashset

            Printing.PrintLine();

            HashSet<string> hset1 = [];
            hset1.Add("C");
            hset1.Add("C++");
            hset1.Add("C#");
            Console.Write("average: ");
            Console.WriteLine(hset1.Average((e) => e.Length));

            foreach (var ele in hset1)
            {
                Console.WriteLine(ele);
            }

            ///Dictionary

            Dictionary<int, string> dict1 = new(){
                           { 1, "a" },
                           { 2, "b" },
                           { 3, "c" }
                       };

            dict1.Add(4, "d");
            foreach (var ele in dict1)
            {
                Console.WriteLine("{0} and {1}",
                          ele.Key, ele.Value);
            }

            #endregion

            #region custom stack

            Printing.PrintLine();

            CustomStack<int> stack = new(5);

            // Push 
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            //  Display The CustomStack
            stack.Display();

            // Pop 
            stack.Pop();
            stack.Pop();
            stack.Pop();

            // Display The CustomStack 
            stack.Display();

            #endregion

            #region custom queue

            Printing.PrintLine();

            CustomQueue<int> queue = new(5);

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Display();

            queue.Dequeue();
            queue.Dequeue();
            queue.Display();

            queue.Dequeue();
            queue.Display();

            #endregion

        }

    }

}
