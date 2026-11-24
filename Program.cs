using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {

        List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry", "fig", "grape", "honeydew" };

        Console.WriteLine("List Contain 'apple': " + words.Contains("apple"));
        Console.WriteLine("List contains a word of length 5: " + words.Exists(word => word.Length > 5));
        Console.WriteLine("First word longer than 5 characters: " + words.Find(word => word.Length > 5));
        Console.WriteLine("Words longer than 5 characters: " + string.Join(" , ", words.FindAll(word => word.Length > 5)));
        Console.WriteLine("Any words starting with 'a': " + words.Any(word => word.StartsWith("a")));



        Console.ReadKey();

    }
}
