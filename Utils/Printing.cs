using System.Collections;

namespace Utils
{
    public static class Printing
    {
        public static void PrintLine()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void PrintList<T>(IEnumerable<T> collection)
        {
            PrintLine();
            Console.WriteLine(string.Join(", ", collection));

        }
    }
}
