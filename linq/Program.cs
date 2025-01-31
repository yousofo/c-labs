using static linq.ListGenerators;
using System;
using System.Linq;
using System.Collections.Generic;
using Utils;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //where

            ProductList.Where(e => e.UnitsInStock == 0).Print("Out of Stoke");

            ProductList.Where(e => e.UnitsInStock > 0 && e.UnitPrice > 3).Print("in stock and cost more than 3.00 per unit");

            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            Arr.Where((e, i) => e.Length < i).Print("name is shorter than their value");


            //first last ,firstorefault,take,skip

            ProductList.First(e => e.UnitsInStock == 0).Print("first Product out of Stock");

            ProductList.FirstOrDefault(e => e.UnitPrice > 1000).Print("first product whose Price > 1000, unless there is no match, in which case null is returned.");

            int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            Arr2.Where(e => e > 5).Order().Skip(1).Take(1).Print("second number greater than 5");


            //Set Operators 

            ProductList.Select(e => e.Category).Distinct().Print("unique Category names from Product List");

            ProductList.Select(e => e.ProductName[0]).Union(CustomerList.Select(e => e.CompanyName[0]).Distinct()).Distinct().Order().Print("unique first letter from both product and customer names. ");

            ProductList.Select(e => e.ProductName[0]).Intersect(CustomerList.Select(e => e.CompanyName[0]).Distinct()).Distinct().Order().Print("common first letter from both product and customer names. ");

            ProductList.Select(e => e.ProductName[0]).Except(CustomerList.Select(e => e.CompanyName[0]).Distinct()).Distinct().Order().Print("first letters of product names that are not also first letters of customer names. ");

            ProductList.Select(e => e.ProductName[^3..]).Union(CustomerList.Select(e => e.CompanyName[^3..])).Order().Print("last Three Characters in each names of all customers and products, including any duplicates");

            //Aggregate Operators

            int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            Arr3.Count(e => e % 2 == 1).Print("get the number of odd numbers in the array");

            CustomerList.Select(e => new { e.CustomerID, e.Orders.Length }).Print("list of customers and how many orders each has");

            ProductList.GroupBy(e => e.Category).Select((e) => new { e.Key, e.ToList().Count }).Print();

            int[] Arr4 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            Arr4.Sum().Print("total of the numbers in an array.");

            File.ReadAllText("dictionary_english.txt").Length.Print("total number of characters of all words in dictionary_english.txt");

            ProductList.GroupBy(e => e.Category).Select((e) => new { e.Key, available = e.Sum(e => e.UnitsInStock) }).Print("total units in stock for each product category.");

            File.ReadAllLines("dictionary_english.txt").ToList().MinBy(e => e.Length).Print("shortest word in dictionary_english.txt");

            ProductList.GroupBy(e => e.Category).Select(e => new { e.Key, cheapest = e.Min(e => e.UnitPrice) }).Print("cheapest price among each category's products ");

            var query = from p in ProductList
                        group p by p.Category into g
                        let minPrice = g.Min(p => p.UnitPrice)
                        from product in g
                        where product.UnitPrice == minPrice
                        select new { g.Key, product.UnitPrice };

            query.Print("Products with the cheapest price in each category");


            File.ReadAllLines("dictionary_english.txt").ToList().Max(e => e.Length).Print("longest word length in dictionary_english.txt");

            ProductList.GroupBy(e => e.Category).Select(e => new { e.Key, MostExpensive = e.MaxBy(e => e.UnitPrice) }).Print("MostExpensive price among each category's products ");

            File.ReadAllLines("dictionary_english.txt").ToList().Average(e => e.Length).Print("average length of the words");

            ProductList.GroupBy(e => e.Category).Select(e => new { e.Key, Average = e.Average(e => e.UnitPrice) }).Print("Average price among each category's products ");


            //Ordering Operators 

            ProductList.OrderBy(e => e.ProductName).Print("Sort a list of products by name");

            string[] Arr5 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            Arr5.OrderBy(word => word, StringComparer.OrdinalIgnoreCase).Print("custom comparer to do a case-insensitive sort of the words in an array");

            ProductList.OrderByDescending(e => e.UnitsInStock).Print("Sort a list of products by units in stock from highest to lowest. ");

            string[] Arr6 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            Arr6.OrderBy(e => e.Length).ThenBy(e => e).Print("Sort a list of digits, first by length of their name, and then alphabetically by the name itself.");

            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            words.OrderBy(e => e.Length).ThenBy(e => e, StringComparer.OrdinalIgnoreCase).Print("Sort first by word length and then by a case-insensitive sort of the words in an array. ");

            ProductList.OrderBy(e => e.Category).ThenByDescending(e => e.UnitPrice).Print(" Sort a list of products, first by category, and then by unit price, from highest to lowest.");

            string[] Arr7 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            Arr7.OrderBy(e => e.Length).ThenByDescending(e => e, StringComparer.OrdinalIgnoreCase).Print("Sort first by word length and then by a case-insensitive descending sort of the words in an array.");

            string[] Arr8 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            Arr8.Where(e => e.Length > 1 && e[1] == 'i').Reverse().Print("Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.");


            //Partitioning Operators 

            CustomerList.Where(e => e.Country.ToLower() == "usa").Take(3).Print(" first 3 orders from customers in Washington");

            CustomerList.Where(e => e.Country.ToLower() == "usa").Skip(2).Print("all but the first 2 orders from customers in Washington. ");

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            numbers.TakeWhile((e, i) => e > i).Print("Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.");

            numbers.SkipWhile((e, i) => e % 3 != 0).Print("Get the elements of the array starting from the first element divisible by 3.");

            numbers.SkipWhile((e, i) => e > i).Print("Get the elements of the array starting from the first element less than its position.");


            //Projection Operators 

            ProductList.Select(e => e.ProductName).Print("Return a sequence of just the names of a list of products. ");

            string[] words2 = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            words2.Select(e => new{ upper= e.ToUpper(),lower=e.ToLower() }).Print("Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).");

            ProductList.Select(e => new { e.ProductID, Price = e.UnitPrice }).Print("Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type. ");

            int[] Arr9 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            Arr9.Select((e, i) => new { e, InPlace = e == i }).Print("Determine if the value of ints in an array match their position in the array. ");

            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            (from a in numbersA
             from b in numbersB
             where a < b
             select $"{a} is less than {b}").Print();


            //CustomerList
            //    .SelectMany(e => e.Orders.Where(o => o.Total < 500)) 
            //    .Print("All orders where the order total is less than 500.00.");

            (from customer in CustomerList
            from order in customer.Orders
            where order.Total < 500
            select order).Print("All orders where the order total is less than 500.00.");


            (from customer in CustomerList
             from order in customer.Orders
             where order.OrderDate.Year > 1988
             select order).Print("Select all orders where the order was made in 1998 or later.");


            //Quantifiers

            File.ReadAllLines("dictionary_english.txt").Any(word => word.Contains("ei")).Print("Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'");

            var g1 = ProductList.GroupBy(e => e.Category).Where(e => e.Any(e => e.UnitsInStock == 0));
            //.Print("Return a grouped a list of products only for categories that have at least one product that is out of stock. ")

            Printing.PrintLine();

            Console.WriteLine("Return a grouped a list of products only for categories that have at least one product that is out of stock. ");
            foreach (var item in g1)
            {
                Console.WriteLine(item.Key);
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
            }

            var g2 = ProductList.GroupBy(e => e.Category).Where(e => e.All(e => e.UnitsInStock >= 0));
            //.Print("Return a grouped a list of products only for categories that have all of their products in stock. ");
            Printing.PrintLine();
            Console.WriteLine("Return a grouped a list of products only for categories that have all of their products in stock. ");
            foreach (var item in g2)
            {
                Console.WriteLine(item.Key);
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
            }
            //
            Printing.PrintLine();
            Console.WriteLine("Use group by to partition a list of numbers by their remainder when divided by 5");
            int[] numbers5 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            foreach (var e in numbers.GroupBy(n => n % 5))
            {
                Console.WriteLine(e.Key);
                foreach (var x in e)
                {
                    Console.WriteLine("num: "+x);
                }
            }





            string[] Arr10 = { "from", "salt", "earn", "last", "near", "form" };

            var groupedWords = Arr10.GroupBy(word => new string(word.OrderBy(c => c).ToArray())).ToList();

            foreach (var group in groupedWords)
            {

                Console.WriteLine("-----"+group.Key +"-----");
                foreach (var word in group)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}







