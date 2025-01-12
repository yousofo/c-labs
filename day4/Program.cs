using day4.BookLib;
using day4.Football;
using day4.Students;

namespace day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * form => enter user name and password
             * click save => show {user name and password} in a message box
             * close btn => close the form
             */


            #region Students

            //var dep1 = new Department()
            //{
            //    new(1,"ahmed"),
            //    new(2,"Mohamed"),
            //    new(3,"ali"),
            //    new(4,"omar"),
            //    new(5,"khalid"),
            //    new(6,"yousef"),
            //};

            //dep1[dep1.FindIndex(e => e.Name == "ahmed")].IncreaseAbsence(3);
            //dep1[dep1.FindIndex(e => e.Name == "Mohamed")].IncreaseAbsence(3);

            //dep1.Print();

            #endregion

            #region football

            //var match1 = new Match();

            //match1.players.AddRange([
            //    new(1, "ali"),
            //    new(2, "salah"),
            //    new(3, "ibrahim"),
            //    new(4, "mohamed"),
            //    new(5, "ahmed"),
            //    new(6, "yousef"),
            //    ]);

            //match1.refree = new(1, "mahmoud");

            //match1.ball.Move(1,2);


            #endregion

            #region Books

            List<Book> books = [
                    new("id1","Histroy",["mohamed","ali"],1499,DateTime.Now),
                    new("id2","Math",["mohamed"],1100,DateTime.Now),
                    new("id3","Physics",["ali"],599,DateTime.Now),
                    new("id4","Chemistry",["ibrahim"],850,DateTime.Now),
                ];

            Console.WriteLine(books[0]);

            Console.WriteLine(BookFunctions.GetTitle(books[0]));
            Console.WriteLine(BookFunctions.GetAuthors(books[0]));
            Console.WriteLine(BookFunctions.GetPrice(books[0]));

            LibEngine.ProcessBooks(books, BookFunctions.GetTitle);
            LibEngine.ProcessBooks(books, BookFunctions.GetAuthors);
            LibEngine.ProcessBooks(books, BookFunctions.GetPrice);

            LibEngine.ProcessBooks(books, delegate (Book e) { return e.ISBN; });
            LibEngine.ProcessBooks(books, (e) => e.PublishDate.ToString());

            #endregion

        }
    }
}
