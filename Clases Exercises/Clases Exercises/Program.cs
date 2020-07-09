using System;

namespace Clases_Exercises
{   
    public class Person
    {
        public String FirstName;
        public String LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var exequiel = new Person();
            exequiel.FirstName = "Exequiel";
            exequiel.LastName = "Hernando";
            exequiel.Introduce();
        }
    }
}
