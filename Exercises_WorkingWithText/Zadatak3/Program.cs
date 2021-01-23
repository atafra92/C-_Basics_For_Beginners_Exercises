using System;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Please enter a time in 24 hour format (e.g. 19:00): ");
                DateTime time = DateTime.Parse(Console.ReadLine());

                if (time.Hour >= 0 && time.Hour < 24)
                {
                    Console.WriteLine("OK!");
                }
                else
                {
                    Console.WriteLine("Invalid time!");
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"Invalid time, Error: { ex.Message }");
            }
            Console.ReadLine();
            

        }
    }
}
