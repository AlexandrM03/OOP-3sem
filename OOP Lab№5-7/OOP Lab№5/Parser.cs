using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace OOP_Lab_5
{
    class Parser
    {
        public void ParseTextFile(Present<Goods> present)
        {
            StreamReader stream = new StreamReader(@"D:\2 курс\Лабораторные по ООП\OOP Lab№5-6\OOP Lab№5\list.txt");
            while (stream.ReadLine() is string line)
            {
                switch (line)
                {
                    case "clocks" or "Clocks":
                        present.Add(new Clocks());
                        break;
                    case "flowers" or "Flowers":
                        present.Add(new Flowers());
                        break;
                }
            }
        }
        public void ParseJSON(Present<Goods> present)
        {
            string json = @"['Flowers', 'Clocks', 'Flowers']";
            List<string> items = JsonConvert.DeserializeObject<List<string>>(json);
            foreach(string item in items)
            {
                switch (item.ToLower())
                {
                    case "clocks":
                        present.Add(new Clocks());
                        break;
                    case "flowers":
                        present.Add(new Flowers());
                        break;
                }
            }
        }
    }
}
