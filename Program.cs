using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Even Number "+ string.Join(" , ", numbers.Where(n => n % 2 == 0)));
        Console.WriteLine("Odd Number "+ string.Join(" @ ", numbers.Where(n => n % 2 != 0)));
        var NumGreaterThan5 = numbers.Where(n => n > 5);
        Console.WriteLine("Number Graeter Than Five "+string.Join(" * ",NumGreaterThan5));
        var everySecondNumber = numbers.Where((n, index) => index % 2 == 1);
        Console.WriteLine("Every Second Number: " + string.Join(" # ", NumGreaterThan5));

        Console.WriteLine("Numbers between 3 & 8: " + string.Join(" $ ", numbers.Where(n => n > 3 && n < 8)));



        Console.ReadKey();

    }
}
