﻿/*Exercises
    Note: for all these exercises, ignore input validation unless otherwise directed.Assume the user enters a value in the format that the program expects. For example, if the program expects the user to enter a number, don't worry about validating if the input is a number or not. When testing your program, simply enter a number.*/

/*  1- Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a   valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in            applications where values entered into input boxes need to be validated.)
 */
using System;
using System.Numerics;

namespace Clases_Exercises
{
    class Program
    {   
        public void Exercise1()
        {
            Console.Write("Write a number between 1 to 10:");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if(number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid number");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
        /*
         * 2- Write a program which takes two numbers from the console and displays the maximum of the two.
         */
        public void Exercise2()
        {
            Console.Write("Write a number 1:");
            var input1 = Console.ReadLine();
            var number1 = Convert.ToInt32(input1);
            Console.Write("Write a number 2:");
            var input2 = Console.ReadLine();
            var number2 = Convert.ToInt32(input2);
            if(number1 > number2)
            {
                Console.Write(@"Number 1 {a} is the maximum",input1);
            }else if (number1 < number2)
            {
                Console.Write(@"Number 2 {a} is the maximum", input2);

            }
            else
            {
                Console.Write("both numbers are equals");
            }
        }
        /*
         * 3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
         */
        public void Exercise3()
        {
            Console.WriteLine("Write the width of the image");
            var width = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Write the height of the image");
            var height = Convert.ToInt32((Console.ReadLine()));
            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine(@"The image oritentation is: {a}", orientation);
        }
        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }
        /*
         * 4- Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.
         */
        public void Exercise4()
        {
            Console.WriteLine("Write the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write the speed limit of the car: ");
            var carSpeedLimit = Convert.ToInt32(Console.ReadLine());
            if(carSpeedLimit < speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                const int limitDemeritPoint = 12;
                const int speedPoint = 5;
                var demeritPoint = ((carSpeedLimit - speedLimit) / speedPoint);
                if(demeritPoint > limitDemeritPoint)
                {
                    Console.WriteLine("Demerit Point : " + demeritPoint);
                    Console.WriteLine("Your license Suspended ");
                }
                else
                {
                    Console.WriteLine("Demerit Point : " + demeritPoint);

                }
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
