using System;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Please enter a name: ");
            string name = Console.ReadLine();

            var nameArray = name.ToCharArray();

            Array.Reverse(nameArray);

            string reversedName = new string(nameArray);

            Console.WriteLine($"Reversed name is { reversedName }");

            Console.ReadLine();
        }
    }
}
