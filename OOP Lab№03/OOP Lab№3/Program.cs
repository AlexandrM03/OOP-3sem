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
                cars[2] = new Car(131344, "Toyota", "820", 2010, "Black", 13000, "MB2FD4-3");
                cars[3] = new Car(1317723, "Mercedes", "AMG", 2016, "Silver", 40000, "MT2343-5");
                cars[4] = new Car(131771, "Reno", "Logan", 1998, "Red", 12000, "MB2FV2-2");

                foreach(Car car in cars)
                {
                    if (car.Brand == "Porche")
                        car.Print();
                }
                
                if (cars[0].Equals(cars[1]))
                    Console.WriteLine("Эти машины идентичны!\n");

                Console.Write("Введите количество лет эксплуатации: ");
                int year = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\tСписок машин:");
                foreach (var car in cars)
                {
                    if (2021 - car.Year <= year)
                    {
                        car.Print();
                    }
                }

                Console.WriteLine("---------------------Цена---------------------");
                Car renoLogan = cars[4];
                int price = renoLogan.Price;
                renoLogan.Print();
                Console.WriteLine("Повышаем цену на 23%...");
                renoLogan.IncreasePrice(ref price, 23);
                renoLogan.Price = price;
                renoLogan.Print();
                Console.WriteLine("Теперь уменьшаем на 10%...");
                renoLogan.DecresePrice(ref price);
                renoLogan.Price = price;
                renoLogan.Print();
                Console.WriteLine("Меняем модель машины...");
                string model;
                renoLogan.ChangeModel(out model, "Espace");
                renoLogan.Model = model;
                renoLogan.Print();

                renoLogan.ShowCount();

                var user = new { Name = "Александр", Surname = "Мозолевский" };
                Console.WriteLine("Анонимный тип-----\n" +
                    $"Имя: {user.Name}\n" +
                    $"Фамилия: {user.Surname}\n");

                Console.WriteLine("Пример ошибки.");
                Car errorCar = new Car();
                errorCar.Id = 10000000;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
