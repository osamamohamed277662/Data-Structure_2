using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int> { 44, 22, -55, 666, 9, -6, 345, 11, 3, 3 };
        Console.WriteLine("List Of Number : " + string.Join(" , ", numbers));

        Console.WriteLine("List Contains 9 : " + numbers.Contains(9));
        Console.WriteLine("List Contains Negative Number : " + numbers.Exists(n => n < 0));
        Console.WriteLine("First Negative Number : " + numbers.Find(n => n < 0));

        Console.WriteLine("All Negative Number : " + string.Join(" , ", numbers.FindAll(n => n < 0)));
        Console.WriteLine("Number Greater than 100: " + numbers.Any(n => n > 100));



        Console.ReadKey();

    }
}
