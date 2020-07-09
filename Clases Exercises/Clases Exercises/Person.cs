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
}
