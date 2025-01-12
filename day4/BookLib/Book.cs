using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4.BookLib
{
    internal class Book(string iSBN, string title, string[] authors, decimal price, DateTime? publishDate)
    {
        public string ISBN { get; set; } = iSBN;
        public string Title { get; set; } = title;
        public string[] Authors { get; set; } = authors;
        public DateTime PublishDate { get; set; } = publishDate ?? DateTime.Now;
        public decimal Price { get; set; } = price;


        public override string ToString()
        {
            return $"{ISBN}: {Title} by [${string.Join(", ", Authors)}] on {PublishDate} for ${Price}";
        }
    }
}
