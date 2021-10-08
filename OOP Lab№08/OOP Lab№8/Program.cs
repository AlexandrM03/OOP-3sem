using System;

namespace OOP_Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyList<string> list = new MyList<string>();
                list.Add("C");
                list.Add("Python");
                list.Add("Kotlin");
                list.Add("Ruby");
                list.Add("C#");
                list.Show();

                Console.WriteLine(list[0]);
                list[0] = "C++";
                list.Show();

                list.Delete("Python");
                list.Show();
                FileStreamer.WriteToFile(list);

                MyList<string> listCopy = new MyList<string>();
                FileStreamer.ReadFromFile(ref listCopy);
                Console.Write("Copy: ");
                listCopy.Show();

                //////////////////////////////////////////////////////
                
                MyList<Pastry> pastry = new MyList<Pastry>();
                pastry.Add(new Cake());
                pastry.Add(new Sweets());
                pastry.Show();
            }
            catch (WrongIndexException ex) { Console.WriteLine(ex); }
            catch (WrongElementException ex) { Console.WriteLine(ex); }
            finally { Console.WriteLine("END"); }
        }
    }
}
