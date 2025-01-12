using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4.BookLib
{
    internal class LibEngine
    {
        public delegate string BookHandler(Book book);
        public static void ProcessBooks(List<Book> books, BookHandler fun)
        {
            foreach (var b in books)
            {
                Console.WriteLine(fun(b));
            }
        }
    }
}
