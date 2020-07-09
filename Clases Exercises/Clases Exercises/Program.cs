using Clases_Exercises.Math;
using System;

namespace Clases_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var exequiel = new Person();
            exequiel.FirstName = "Exequiel";
            exequiel.LastName = "Hernando";
            exequiel.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
