using System;

namespace Clases_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var firsName = "Exequiel";
            var lastName = "Hernando";
          
            var fullName = firsName + " " + lastName;
          
            var myFullName = String.Format("My name is {0} {1}", firsName, lastName);
            Console.WriteLine(myFullName);    

        }
    }
}
