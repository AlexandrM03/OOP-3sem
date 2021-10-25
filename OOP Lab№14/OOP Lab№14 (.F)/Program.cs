using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace OOP_Lab_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Porsche", "911", 15);
            Car car2 = new Car("Lamborghini", "urus", 30);
            Car car3 = new Car("BMW", "i8", 7);
            Car car4 = new Car("Mercedes", "AMG", 20);

            CustomSerializer.Serialize("binCar.bin", car1);
            CustomSerializer.Serialize("binCar.soap", car2);
            CustomSerializer.Serialize("binCar.xml", car3);
            CustomSerializer.Serialize("binCar.json", car4);

            CustomSerializer.Deserialize("binCar.bin");
            CustomSerializer.Deserialize("binCar.soap");
            CustomSerializer.Deserialize("binCar.xml");
            CustomSerializer.Deserialize("binCar.json");

            Console.WriteLine();
            List<Car> list = new List<Car>() { car1, car2, car3, car4 };
            using (FileStream fs = new FileStream("List.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Car>));
                xs.Serialize(fs, list);
                fs.Close();
                using (FileStream fsd = new FileStream("List.xml", FileMode.Open))
                {
                    List<Car> cars = (List<Car>)xs.Deserialize(fsd);
                    cars.ForEach(x => Console.WriteLine($"Deserialized car: {x.Brand} {x.Model}"));
                }
            }

            Console.WriteLine();
            Regex regex = new Regex(@"<Brand>(?<B>\w+)</Brand><Model>(?<M>\w+)</Model>");

            XmlDocument document = new XmlDocument();
            document.Load("List.xml");
            XmlElement xmlRoot = document.DocumentElement;
            XmlNode lamborghini = xmlRoot.SelectSingleNode("descendant::Car[Model='urus']");
            Console.WriteLine($"{regex.Match(lamborghini.OuterXml).Groups["B"].Value} {regex.Match(lamborghini.OuterXml).Groups["M"].Value}");

            Console.WriteLine();
            XmlNodeList allCars = xmlRoot.SelectNodes("*");
            foreach (XmlNode i in allCars)
            {
                Console.WriteLine($"{regex.Match(i.OuterXml).Groups["B"].Value} {regex.Match(i.OuterXml).Groups["M"].Value}");
            }

            Console.WriteLine();
            XDocument students = new XDocument();
            XElement root = new XElement("Students");
            XElement student = new XElement("student");
            XAttribute name = new XAttribute("name", "Alexander");
            XAttribute surname = new XAttribute("surname", "Mozolevskiy");
            student.Add(name, surname);
            root.Add(student);
            name = new XAttribute("name", "Artyom");
            surname = new XAttribute("surname", "Thinkevich");
            student = new XElement("student");
            student.Add(name, surname);
            root.Add(student);
            students.Add(root);
            students.Save("Students.xml");

            var allStudents = root.Elements("student");
            foreach (var i in allStudents)
            {
                if (i.Attribute("name").Value == "Artyom")
                    Console.WriteLine(i.Attribute("surname").Value);
            }
        }
    }
}
