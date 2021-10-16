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

            Console.Write($"{++i}. ");
            Reflector.GetPublicMethods(car);
            Console.WriteLine();

            Console.Write($"{++i}. ");
            Reflector.GetPropetry(car);
            Reflector.GetFields(car);
            Console.WriteLine();

            Console.Write($"{++i}. ");
            Reflector.GetInterfaces(car);
            Console.WriteLine();

            Console.Write($"{++i}. ");
            Reflector.GetMethodsByParam(car, "Int32 i");
            Console.WriteLine();

            Console.Write($"{++i}. ");
            Reflector.InvokeFromFile();

            object ob = Reflector.Create("Toyota", "Camry");
            Console.Write($"{++i}. {(ob as Car).Brand} {(ob as Car).Model}");
        }
    }
}
