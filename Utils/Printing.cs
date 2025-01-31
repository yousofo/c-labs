using System.Collections;

namespace Utils
{
    public static class Printing
    {
        public static void PrintLine()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void PrintList<T>(IEnumerable<T> collection)
        {
            PrintLine();
            Console.WriteLine(string.Join(", ", collection));
        }
        public static void Print(this object? obj, string message = "")
        {
            PrintLine();
            Console.WriteLine(message + "\n");
            Console.WriteLine(obj);
        }
        public static void Print(this IEnumerable list,string? message ="")
        {
            PrintLine();
            Console.WriteLine(message+"\n");
            foreach (var item in list)
                Console.WriteLine(item);

        }
    }
}
