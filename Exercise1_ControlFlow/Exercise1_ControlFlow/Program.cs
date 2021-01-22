using System;

namespace Exercise1_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART 1
            Console.Write("Please enter a number between 1 and 10: ");
            int input = int.Parse(Console.ReadLine());

            if (input > 0 && input < 11)
            {
                Console.WriteLine("This is a valid number");
            }
            else
            {
                Console.WriteLine("This is a invalid number");
            }

            //PART 2
            Console.WriteLine();
            Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());

            var result = (number1 > number2) ? number1 : number2;

            Console.WriteLine($"Max number is { result }");

            //PART 3
            Console.WriteLine();
            Console.Write("Enter the width of a image: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Enter the hight of a image: ");
            int height = int.Parse(Console.ReadLine());

            var orientation = (width < height) ? ImageOrientation.Portrait : ImageOrientation.Landscape;

            Console.WriteLine($"Orientation of a image is { orientation }");

            Console.ReadLine();
        }
    }

    public enum ImageOrientation
    { 
        Portrait,
        Landscape
    }

}
