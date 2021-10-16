using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace OOP_Lab_12
{
    public static class Reflector
    {
        public static string GetAssemblyVesion()
            => typeof(Program)
            .Assembly
            .FullName;

        public static bool IncludeConstructor(object ob)
            => Type
            .GetType(ob.ToString())
            .GetConstructors(BindingFlags.Public | BindingFlags.Instance)
            .Length != 0;

        public static void GetPublicMethods(object ob)
            => Type
            .GetType(ob.ToString())
            .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
            .ToList()
            .ForEach(x => Console.Write($"{x.Name} "));

        public static void GetPropetry(object ob)
            => Type
            .GetType(ob.ToString())
            .GetProperties()
            .ToList()
            .ForEach(x => Console.Write($"{x.Name} "));

        public static void GetFields(object ob)
            => Type
            .GetType(ob.ToString())
            .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
            .ToList()
            .ForEach(x => Console.Write($"{x.Name} "));

        public static void GetInterfaces(object ob)
            => Type
            .GetType(ob.ToString())
            .GetInterfaces()
            .ToList()
            .ForEach(x => Console.Write($"{x.Name} "));

        public static void GetMethodsByParam(object ob, string par)
            => Type
            .GetType(ob.ToString())
            .GetMethods()
            .Where(x => x.GetParameters().Any(n => n.ToString() == par))
            .ToList()
            .ForEach(x => Console.Write($"{x.Name} "));

        public static void InvokeFromFile()
        {
            StreamReader sr = new StreamReader(@"D:\2 курс\Лабораторные по ООП\OOP Lab№12\OOP Lab№12\Invoke.txt");
            Type type = typeof(Hi);
            string methodName = sr.ReadLine();
            List<string> paramValue = new List<string>();
            while(!sr.EndOfStream)
                paramValue.Add(sr.ReadLine());

            MethodInfo method = type.GetMethod(methodName);
            object obj = Activator.CreateInstance(type);
            method.Invoke(obj, new object[] { paramValue[0], paramValue[1] });
        }

        public static object Create(string brand, string model)
        {
            Type type = typeof(Car);
            ConstructorInfo info = type.GetConstructor(new Type[] { typeof(string), typeof(string) });
            object obj = info.Invoke(new object[] { brand, model });

            return obj;
        }
    }
}
