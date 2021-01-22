using System;
using System.Text;

namespace Exercise2_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
            //Display the count on the console.

            int counter = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"{ counter } numbers in range from 1 to 100 are divisible by 3");


            //2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
            //Calculate the sum of all the previously entered numbers and display it on the console.

            int sum = 0;

            do
            {
                Console.Write($"Please enter a number or 'ok' to exit: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "ok")
                {
                    break;
                }

                sum += int.Parse(input);

            } while (true);

            Console.WriteLine($"Sum of all the numbers is: { sum }");


            //3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
            //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = number; i >= 1; i--)
            {
                factorial *= i;
            }
            Console.WriteLine($"{ number}! = { factorial }");

            //4 - Write a program that picks a random number between 1 and 10.
            //Give the user 4 chances to guess the number.If the user guesses the number, display “You won"; otherwise, display “You lost". 
            //(To make sure the program is behaving correctly, you can display the secret number on the console first.)

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

            } while (outOfGuesses == false);

            //5- Write a program and ask the user to enter a series of numbers separated by comma. 
            //Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.Write("Enter a series of numbers separated by comma: ");
            string input = Console.ReadLine();

            var numbers = input.Split(",");

            var max = int.Parse(numbers[0]);

            foreach (var num in numbers)
            {
                var number = int.Parse(num);
                if (number > max)
                {
                    max = number;
                }              
            }

            Console.WriteLine($"Max number is { max }");

            Console.ReadLine();
        }
    }
}
