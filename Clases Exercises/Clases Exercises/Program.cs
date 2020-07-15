using System;

namespace Clases_Exercises
{
    class Program
    {   public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAinMail = 2,
            Express = 3
        }

        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
        }
    }
}
