using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace OOP_Lab_12
{
    public static class Reflector
    {
        public static string GetAssemblyVesion()
            => typeof(Program).Assembly.FullName;

        public static bool IncludeConstructor(object ob)
            => Type.GetType(ob.ToString()).GetConstructors(BindingFlags.Public | BindingFlags.Instance).Length != 0;

        public static List<MethodInfo> GetPublicMethods(object ob)
            => Type.GetType(ob.ToString()).GetMethods(BindingFlags.Public | BindingFlags.Instance).ToList();
    }
}
