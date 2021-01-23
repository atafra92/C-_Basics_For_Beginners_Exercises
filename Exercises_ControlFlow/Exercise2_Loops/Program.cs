using System;
using System.Text;

namespace Exercise2_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak 1
            int counter = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"{ counter } numbers in range from 1 to 100 are divisible by 3");


            //Zadatak 2
            int sum = 0;

            do
            {
                Console.Write($"Please enter a number or type 'ok' to exit: ");
                string num = Console.ReadLine();

                if (num.ToLower() == "ok")
                {
                    break;
                }

                sum += int.Parse(num);

            } while (true);

            Console.WriteLine($"Sum of all the numbers is: { sum }");


            //Zadatak 3

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = number; i >= 1; i--)
            {
                factorial *= i;
            }
            Console.WriteLine($"{ number}! = { factorial }");

            
            //Zadatak 4

            Random random = new Random();
            int guesses = 0;
            bool outOfGuesses = false;

            do
            {
                int randomNumber = random.Next(1, 11);

                Console.Write("Guess a number from 1 to 10: ");
                int guessedNumber = int.Parse(Console.ReadLine());
                guesses++;

                if (guessedNumber == randomNumber)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else if (guesses >= 4)
                {
                    outOfGuesses = true;
                    Console.WriteLine("You lost!");
                }

            } while(outOfGuesses == false);

           
            //Zadatak 5

            Console.Write("Enter a series of numbers separated by comma: ");
            string input = Console.ReadLine();

            var numbers = input.Split(",");

            var max = int.Parse(numbers[0]);

            foreach (var n in numbers)
            {
                var strNumber = int.Parse(n);
                if (strNumber > max)
                {
                    max = strNumber;
                }              
            }

            Console.WriteLine($"Max number is { max }");

            Console.ReadLine();
        }
    }
}
