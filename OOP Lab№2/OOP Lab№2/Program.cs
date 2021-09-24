using System;
using System.Text;
using System.Linq;

namespace OOP_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1a 

            bool Bool = true;
            byte Byte = 255;    // [0, 255]
            sbyte SByte = 127;  // [-128, 127]
            char Char = 'A';
            decimal Decimal = 1.23M;    // Precision 28-29 digits
            double Double = 1.23;       // Precision 15-17 digits
            float Float = 1.23f;        // Precision 6-9 digits
            int Int = 1;
            uint UInt = 1;
            nint NInt = 2;
            nuint NUInt = 2;
            long Long = 3;
            ulong ULong = 3;
            short Short = 4;
            ushort UShort = 4;

            //

            Console.WriteLine("bool = {0}, byte = {1}, sbyte = {2}, char = {3}" +
                "\ndecimal = {4}, double = {5}, float = {6}, int = {7}" +
                "\nuint = {8}, nint = {9}, nuint = {10}, long = {11}" +
                "\nulong = {12}, short = {13}, ushort = {14}", 
                Bool, Byte, SByte, Char, Decimal, Double, Float, Int, UInt,
                NInt, NUInt, Long, ULong, Short, UShort);

            // 1b

            short ShortNum = 12;        // Неявное
            int IntNum = ShortNum;      // zero extension

            sbyte SByteNum = -4;        // Знаковый бит копируется в добавленные разряды
            ShortNum = SByteNum;        // ff fc

            IntNum = SByteNum;

            Long = IntNum;

            Double = Float;


            double DoubleNum = 1.23;    // Явное
            int DoubleToIntNum = (int)DoubleNum;

            int IntParse = int.Parse("12");

            float FloatParse = float.Parse("12,24");

            double DoubleConvert = Convert.ToDouble(FloatParse);

            float FloatConvert = Convert.ToSingle(DoubleNum);

            // 1c
            Object BoxInt = Int;
            int UnboxInt = (int)BoxInt;

            // 1d
            var VarFloat = 22.34f;
            Console.WriteLine($"\nVarFloat = {VarFloat}");

            // 1e
            // int NullInt = null;
            Nullable<int> NullInt = null;
            Console.WriteLine($"\nNullable int = {NullInt}");

            // 1f


            // 2a
            string Name = "Alexadr";
            string AlsoName = "Alexadr";

            if (String.Compare(Name, AlsoName) == 0)
            {
                Console.WriteLine($"\nСтроки {Name} и {AlsoName} идентичны!");
            }
            else
            {
                Console.WriteLine($"\nСтроки {Name} и {AlsoName} различны!");
            }

            // 2b
            string List = "apple, banana, apricot, pear, kiwi, papaya";
            string Copy;
            string Surname = " Mozolevskiy";
            string NameAndSurname = Name + Surname;         // Сцепление
            Copy = NameAndSurname;                          // Копирование
            Console.WriteLine($"\nСтудент: {Copy}");
            Console.WriteLine("\n" + Name.Substring(0, 3)); // Выделение подстроки

            string[] Fruits = List.Split(", ");             // Разделение строки
            Console.Write("\nСписок фруктов: ");
            foreach (string s in Fruits)
            {
                Console.Write(s + " ");
            }

            string A = "рак";       // Вставка подстроки в заданную позицию
            string B = "Атасия";
            Console.WriteLine("\n\n" + B.Substring(0, 3) + A + B.Remove(0, 3));

            string Del = "Анорак";
            Console.WriteLine("\n" + Del.Replace(A, ""));   // Удаление подстроки

            // 2c
            string Empty = "";
            string Null = null;

            if (String.IsNullOrWhiteSpace(Empty) || String.IsNullOrEmpty(Null))
            {
                Console.WriteLine("\nОбе строки равны null или пустые!");
            }
            else
            {
                Console.WriteLine("\nОдна из строк не null или не пустая!");
            }

            // 2d
            StringBuilder Quote = new StringBuilder(" музыка делает");
            Quote.Insert(0, "Порой");
            Quote.Remove(13, 6);
            Quote.Append("творит чудеса.");
            Console.WriteLine("\n" + Quote + "\n");

            // 3a
            int[,] Matrix = new int[3, 3] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // 3b
            try
            {
                Console.Write("\nСписок фруктов: ");
                foreach (string s in Fruits)
                {
                    Console.Write(s + " ");
                }

                Console.Write("\nВведите позицию: ");
                int Index = Convert.ToInt32(Console.ReadLine());
                if (Index - 1 > Fruits.Length)
                {
                    throw new Exception("Неверный индекс!");
                }
                Console.Write("Введите значение: ");
                string Change = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(Change))
                {
                    throw new Exception("Неверное значение!");
                }

                Fruits[Index - 1] = Change;
                Console.Write("Новый список фруктов: ");
                foreach (string s in Fruits)
                {
                    Console.Write(s + " ");
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // 3c
            Random Rnd = new Random();
            float[][] SArray = new float[3][];
            SArray[0] = new float[2];
            SArray[1] = new float[3];
            SArray[2] = new float[4];
            
            Console.WriteLine("\n\nСтупенчатый массив: ");
            for (int i = 0; i < SArray.Length; i++)
            {
                for (int j = 0; j < SArray[i].Length; j++)
                {
                    SArray[i][j] = Convert.ToSingle(Math.Round(Rnd.NextDouble() * 5, 2));
                    Console.Write(SArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

            // 3d
            var VarInt = new int[] { 1, 2, 3, 4, 5 };
            var VarStr = "Abcdefg";

            // 4a - 4b 
            (int, string, char, string, ulong) Cortege = (18, "Александр", 'М', "Мозолевский", 3031666);
            Console.WriteLine("\n--------Информация--------");
            Console.WriteLine("Возраст:         " + Cortege.Item1);
            Console.WriteLine("Имя:             " + Cortege.Item2);
            Console.WriteLine("Пол:             " + Cortege.Item3);
            Console.WriteLine("Фамилия:         " + Cortege.Item4);
            Console.WriteLine("Дом. телефон:    " + Cortege.Item5);

            // Частичный вывод
            Console.WriteLine("\n" + Cortege.Item1 + " " + Cortege.Item3 + " " + Cortege.Item4);

            // 4c
            (var a, var b) = (144, "156");
            Console.WriteLine("\n" + a + " " + b);

            // 4d
            var First = (a: 10, b: "20");
            var Second = (a: 10, b: "20");
            if (First == Second)
            {
                Console.WriteLine("\nКортежи равны!");
            }
            else
            {
                Console.WriteLine("\nКортежи не равны!");
            }

            // 5
            Tuple<int, int, int, char> Collector(int[] num, string str)
            {
                return Tuple.Create(num.Max(), num.Min(), num.Sum(), str[0]);
            }
            int[] ArrToTuple = { 5, 12, 56 };
            string StrToTuple = "ABC";
            Tuple<int, int, int, char> T = Collector(ArrToTuple, StrToTuple);
            Console.WriteLine("\nКортёж: " + T);

            // 6
            void FirstFoo()
            {
                try
                {
                    checked
                    {
                        int x = int.MaxValue;
                        x++;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Произошло переполнение!");
                }
            }

            void SecondFoo()
            {
                try
                {
                    unchecked // Не вызывает OverflowException
                    {
                        int x = int.MaxValue;
                        x++;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Произошло переполнение!");
                }
            }

            FirstFoo();
            SecondFoo();
            Console.ReadKey();
            cout << "Hello World"
        }
    }
}

