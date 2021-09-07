using System;

namespace OOP_Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Car[] cars = new Car[5];
                cars[0] = new Car(1317777, "Porche", "911", 2018, "Gold", 180000, "MB2332-6");
                cars[1] = new Car(1317777, "Porche", "911", 2018, "Gold", 180000, "MB2332-6");
                cars[2] = new Car(131344, "Toyota", "820", 2014, "Black", 13000, "MB2FD4-3");
                cars[3] = new Car(1317723, "Mercedes", "AMG", 2018, "Silver", 40000, "MT2343-5");
                cars[4] = new Car(131771, "Reno", "Logan", 2018, "Red", 12000, "MB2FV2-2");

                foreach(Car car in cars)
                {
                    if (car.Brand == "Porche")
                        car.Print();
                }

                if (cars[0].Equals(cars[2]))
                    Console.WriteLine("Эти машины идентичны!\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
