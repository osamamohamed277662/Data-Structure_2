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
        numbers.Add(11);

        Console.WriteLine("After adding 11: " + string.Join(" , ", numbers));

        numbers.Insert(2, 66);
        Console.WriteLine("After adding 66 at index 2: " + string.Join(" , ", numbers));

        numbers.Insert(0, 300);
        Console.WriteLine("After adding 300 at index 0: " + string.Join(" , ", numbers));

        numbers.Insert(8, 66);
        Console.WriteLine("After adding 66 at index 8: " + string.Join(" , ", numbers));

        numbers.InsertRange(4, new List<int> { 77, 78, 79 });
        Console.WriteLine("After adding  77, 78, 79 at index 4: " + string.Join(" , ", numbers));




        Console.ReadKey();

    }
}
