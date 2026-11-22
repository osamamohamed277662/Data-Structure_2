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

        numbers.Remove(9);
        Console.WriteLine("After Removing 9: " + string.Join(" , ", numbers));

        numbers.RemoveAt(2);
        Console.WriteLine("After Removing index 2 which equal 3 : " + string.Join(" , ", numbers));


        numbers.RemoveAll(n => n % 2 == 0);
        Console.WriteLine("After Removing all even numbers: " + string.Join(" , ", numbers));

        numbers.Clear();
        Console.WriteLine("After clearing the list, count:  " + numbers.Count);




        Console.ReadKey();

    }
}
