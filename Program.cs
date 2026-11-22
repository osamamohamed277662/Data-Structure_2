using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        //Boxing
        int num = 10;
        object r = num;

        //UnBoxing

        object j = 44;
        int b;
        b =(int) j;

        //Console.WriteLine(b);

        List<int> Numbers = new List<int>();
        Numbers.Add(1);
        Numbers.Add(2);
        Numbers.Add(3);
        Numbers.Add(4);
        Numbers.Add(5);

        Console.WriteLine("Number of items in the list: " + Numbers.Count);
        Console.WriteLine(Numbers[0]);
        Console.WriteLine(Numbers[1]);
        Console.WriteLine(Numbers[2]);
        Console.WriteLine(Numbers[3]);
        Console.WriteLine(Numbers[4]);

        Console.WriteLine("Changing the value of item 2 of the list to 500:");
        Numbers[1] = 500;
        Console.WriteLine(Numbers[1]);





        Console.ReadKey();

    }
}
