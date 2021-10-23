using System;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;

namespace OOP_Lab_14
{
    static class CustomSerializer
    {
        public static void Serialize(string file, Car car)
        {
            string format = file.Split('.').Last();
            switch (format)
            {
                case "bin":
                    BinaryFormatter bf = new BinaryFormatter();
                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        bf.Serialize(fs, car);
                    }
                    break;

                case "soap":
                    SoapFormatter sf = new SoapFormatter();
                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        sf.Serialize(fs, car);
                    }
                    break;

                case "xml":
                    XmlSerializer xs = new XmlSerializer(typeof(Car));
                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        xs.Serialize(fs, car);
                    }
                    break;

                case "json":
                    DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Car));
                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        js.WriteObject(fs, car);
                    }
                    break;
            }
        }

        public static void Deserialize(string file)
        {
            string format = file.Split('.').Last();
            switch (format)
            {
                case "bin":
                    BinaryFormatter bf = new BinaryFormatter();
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        Car car = (Car)bf.Deserialize(fs);
                        Console.WriteLine($"Deserialized car: {car.Brand} {car.Model}");
                    }
                    break;

                case "soap":
                    SoapFormatter sf = new SoapFormatter();
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        Car car = (Car)sf.Deserialize(fs);
                        Console.WriteLine($"Deserialized car: {car.Brand} {car.Model}");
                    }
                    break;

                case "xml":
                    XmlSerializer xs = new XmlSerializer(typeof(Car));
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        Car car = (Car)xs.Deserialize(fs);
                        Console.WriteLine($"Deserialized car: {car.Brand} {car.Model}");
                    }
                    break;

                case "json":
                    DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Car));
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        Car car = (Car)js.ReadObject(fs);
                        Console.WriteLine($"Deserialized car: {car.Brand} {car.Model}");
                    }
                    break;
            }
        }
    }
}
