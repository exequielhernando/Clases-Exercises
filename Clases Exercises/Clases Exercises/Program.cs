using System;
using System.Runtime.InteropServices;

namespace Clases_Exercises
{
    class Program
    {
        /*
         * Note: for all these exercises, ignore input validation unless otherwise directed. Assume the user enters a value in the format that the program expects. For example, if the program expects the user to enter a number, don't worry about validating if the input is a number or not. When testing your program, simply enter a number.
       */
        /*
         * 1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
         */
        public void exercise1()
        { var count = 0;
            for (var i = 0; i > 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(@"There are {0} numbers divisible by 3 between 1 and 100.", count);
        }
        /*2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
         */
        public static void exercise2()
        {
            var total = 0;
            while (true)
            {
                Console.WriteLine("Write a number o the word 'ok' for exit");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                {
                    break;
                }
                total += Convert.ToInt32(input);
            }
            Console.WriteLine("total sum of all numbers is: " + total);

        }
        /*
         * 3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        */
        public static void exercise3()
        {
            var factorial = 1;
            Console.WriteLine("Write a number and cumpute his factorial:");
            var number = Convert.ToInt32(Console.ReadLine());
            for (var i = number; i > 1; i--)
            {
                factorial *= i;
            }
            Console.WriteLine("{0}! = {1}", number, factorial);

        }
        /*4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
         */
        public static void exercise4()
        {
            var count = 0;
            const int maxChances = 4;
            while (count < maxChances)
            {
                Console.WriteLine("Choose a number between 1 to 10 and play the game: ");
                var number = Convert.ToInt32(Console.ReadLine());
                var random = new Random();
                var randomNumber = random.Next(1, 10);
                if (number == randomNumber)
                {
                    Console.WriteLine("The random number is: {0}", randomNumber);
                    Console.WriteLine("You Won!!!");

                }
                else
                {
                    Console.WriteLine("The random number is: {0}", randomNumber);
                    Console.WriteLine("You Lose :(");
                }
                count++;
            }
        }
        /*
         * 5- Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
         */
        public static void exercise5()
        {
            Console.WriteLine("Write numbers separated by comma and find the maximum:");
            var input = Console.ReadLine();
            var numbers = input.Split(',');

            var maxNumber = Convert.ToInt32(numbers[0]);
            for(var i = 0; i < numbers.Length; i++) {
                if (maxNumber < Convert.ToInt32(numbers[i]))
                {
                    maxNumber = Convert.ToInt32(numbers[i]);
                }
            }
            Console.WriteLine("The maximum numbers is: {0}", maxNumber);
        }
        static void Main(string[] args)
        {
            exercise5();
        }
}
}
