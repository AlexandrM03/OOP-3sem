using System;
using System.Collections.Generic;

namespace OOP_Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer.Language Language;
            Programmer programmer = new Programmer();
            List<string> LP = new List<string> { "Ruby", "C#", "Kotlin", "Pascal", "Python", "GoLang", "VisualBasic", "Dart", "JS", "Java" };

            Console.Write("List: ");
            foreach (string item in LP)
            {
                Console.Write(item + "   ");
            }
            Console.WriteLine();

            programmer.Delete += list =>
            {
                Console.Write("Edited: ");
                foreach (string item in LP)
                {
                    Console.Write(item + "   ");
                }
                Console.WriteLine();
            };

            programmer.Shuffle += list =>
            {
                Console.Write("Edited: ");
                foreach (string item in LP)
                {
                    Console.Write(item + "   ");
                }
                Console.WriteLine();
            };

            Language = programmer.Remove;
            Language += programmer.Mutate;
            Language += programmer.Mutate;
            Language += programmer.Mutate;

            Language(LP);

            Func<string, string> A;
            string str = "abc   ,. de f,,,, GH";
            Console.WriteLine($"\n\n\nString: {str}");
            A = StringEditor.RemovePunctuation;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            A = StringEditor.AddSymbol;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            A = StringEditor.ToUpper;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            A = StringEditor.ToLower;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            A = StringEditor.RemoveSpace;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
        }
    }
}
