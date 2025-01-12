using System.Collections;
using System.Numerics;
using Utils;

namespace day3
{
    delegate T MyDel<T>(T x, T y);
    internal class Program
    {

        static List<ComplexNumber> FindAll(List<ComplexNumber> list, Predicate<ComplexNumber> MyFunction)
        {
            List<ComplexNumber> result = [];

            foreach (var cm in list)
                if (MyFunction(cm)) result.Add(cm);

            return result;
        }

        static int Add(int x, int y) => x + y;
        static float Add(float x, float y) => x + y;
        static double Sub(double x, double y) => x - y;
        static bool DivisibleBy3(int x) => x % 3 == 0;
        static bool Contains(string x, string y) => x.Contains(y, StringComparison.CurrentCultureIgnoreCase);


        static void Main(string[] args)
        {

            MyDel<int> d1 = Add;
            Console.WriteLine(d1.Invoke(10, 20));


            MyDel<float> d2 = Add;
            Console.WriteLine(d2.Invoke(10.2f, 20.3f));


            MyDel<double> d3 = Sub;
            Console.WriteLine(d3.Invoke(19.2, 10.3));


            List<int> numbers = [1, 2, 3, 4, 10, 12, 13, 14, 15, 12, 20, 25, 26, 27, 28, 29, 30, 31, 32];

            Printing.PrintList(numbers.FindAll(x => x % 2 == 0));
            Console.WriteLine(string.Join(", ", [1, 1, 2, 3]));

            Printing.PrintList(numbers.FindAll(delegate (int x) { return x % 2 == 1; }));

            Printing.PrintList(numbers.FindAll(DivisibleBy3));


            List<string> names = ["Yousef", "Ahmed", "Rana", "Fady", "Marwa", "Amer", "Arwa"];

            Printing.PrintList(names.FindAll((e) => Contains(e, "y")));

            Printing.PrintList(names.FindAll(delegate (string name)
                {
                    return name.StartsWith("a", StringComparison.CurrentCultureIgnoreCase);
                })
            );


            Printing.PrintList(names.FindAll(name => name.Length <= 10 && name.Length >= 2));

            List<ComplexNumber> ComplexNumberList =
            [
                new ComplexNumber(1, 1),
                new ComplexNumber(2, -2),
                new ComplexNumber(3, -2)
            ];

            Printing.PrintList(ComplexNumberList.FindAll((comNum) => comNum.imaginary < 0));

            Printing.PrintList(ComplexNumberList.FindAll((comNum) => comNum.imaginary >= 0));

            Printing.PrintList(FindAll(ComplexNumberList, x => x.real == 1));
        }
    }


}
