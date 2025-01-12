using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4.BookLib
{
    internal class BookFunctions
    {
        public static string GetTitle(Book book) => book.Title;

        public static string GetAuthors(Book book) => string.Join(", ", book.Authors);

        public static string GetPrice(Book book) => book.Price.ToString();

    }
}
