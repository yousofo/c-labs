// See https://aka.ms/new-console-template for more information
using day1;

//Console.WriteLine("Hello, World!");

//var p1 = new Point3D(1, 2, 3);
//Console.WriteLine(p1.ToString());





ComplexNumber c1 = new(1, 2);
ComplexNumber c2 = new(3, 4);
ComplexNumber c4 = new(1, 2);


Console.WriteLine(c1 + c2); // 4 + 6i

Console.WriteLine(c1 > c2); // False
Console.WriteLine(++c1);// 2 + 2i
Console.WriteLine(--c1);// 1 + 2i

Console.WriteLine(c1 == c4);

int i = (int)c1; // 1
Console.WriteLine(i); // 1


ComplexNumber c3 = (ComplexNumber)1; // 1 + 0i
Console.WriteLine(c3); // 1 + 0i




Console.WriteLine("\n\n\n----------------------------------\n\n");


Duration D1 = new(1, 10, 15);
Console.WriteLine(D1.ToString());
//Output: Hours: 1, Minutes: 10 , Seconds: 15

Duration D2 = new(3600);
Console.WriteLine(D2.ToString());
//Output: Hours: 1, Minutes: 0 , Seconds: 0

Duration D3 = new(7800);
Console.WriteLine(D3.ToString());
//Output: Hours: 2, Minutes: 10 , Seconds: 0



Duration D4 = new(666);
Console.Write("\nD4: ");
Console.WriteLine(D4.ToString());
//Output: Minutes: 11 , Seconds: 6 
Console.Write("D4 +1 minute: ");
Console.WriteLine((++D4).ToString());
Console.Write("D4 -1 minute: ");
Console.WriteLine((--D4).ToString());


Duration D6 = new(666);
Console.Write("\nD6 == D4: ");
Console.WriteLine(D6 == D4);//true

Console.Write("\nD6.Equals(D4): ");
Console.WriteLine(D6.Equals(D4));//true


Duration D5 = new(1, 10, 15);

DateTime dt1 = (DateTime)D5;
Console.Write("\nD5 as DateTime: ");
Console.WriteLine(dt1.ToString());


var D7 = D5 + 3600;
Console.Write("\nD5 + 3600: ");
Console.WriteLine(D7.ToString());

bool b1= D7;
Console.Write("\nD7 as bool: ");
Console.WriteLine(b1);

