using System;

namespace OOP_Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Car car = new Car("Porsche", "911");
            Console.WriteLine(++i + ". " + Reflector.GetAssemblyVesion());

            Console.WriteLine(++i + ". " + (Reflector.IncludeConstructor(car) ? "Car include public constructor" :
                "Car doesn't include public constructor"));

            Console.Write(++i + ". ");
            foreach (var method in Reflector.GetPublicMethods(car))
            {
                Console.Write(method.Name + "   ");
            }
            Console.WriteLine();
        }
    }
}
