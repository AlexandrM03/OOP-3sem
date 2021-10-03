using System;

namespace OOP_Lab_8
{
    class Program
    {
        static void Main(string[] args)
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
            list.Delete(2);
            list.Show();
        }
    }
}
