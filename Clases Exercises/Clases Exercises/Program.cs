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

            var names = new String[3] { "John", "Jack", "Mary" };
            var formattedNames = String.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = @"Hi John
Look into the followins paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
