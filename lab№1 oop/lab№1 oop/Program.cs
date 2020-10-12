using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace tipe
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            bool alone = true;
//            int a = 5;
//            double b = 10.5;
//            char c = 'F';
//            string d = "Pasha";
//            Console.WriteLine(alone);
//            Console.WriteLine(a);
//            Console.WriteLine(b);
//            Console.WriteLine(c);
//            Console.WriteLine(d);
//            Console.ReadKey();
//        }
//    }
//}

//namespace Z_tipe
//{
//    class Program
//    {
//        static void Main()
//        {
//            int i = 250;
//            byte x = 15;
//            short y = x;
//            short p = 19;
//            int f = p ;
//            long b = i;
//            float k = 1.5f;
//            double d = k;
//            ushort r = 77;
//            uint o = r;
//            Console.WriteLine("Неявные приведения:");
//            Console.WriteLine("Ushort = {0} Uint = {1}", r, o);
//            Console.WriteLine("Short = {0} Int = {1}", p, f);
//            Console.WriteLine("Byte = {0} Short = {1}", x, y);
//            Console.WriteLine("Int = {0} Long = {1}", i, b);
//            Console.WriteLine("Float = {0} Double = {1}", k, d);
//            short s = 45;
//            byte w = (byte)s;
//            double doubleData = 245.45567;
//            int intData = (int)doubleData;
//            float floatData = (float)doubleData;
//            short l = (short)i;
//            int v = (int)b;
//            Console.WriteLine("Явные приведения:");
//            Console.WriteLine("Long = {0} Int = {1}", b, v);
//            Console.WriteLine("Int = {0} Short = {1}", i, p);
//            Console.WriteLine("Short = {0} Byte = {1}", l, w);
//            Console.WriteLine("Double = {0} Int = {1}", doubleData, intData);
//            Console.WriteLine("Double = {0} Float = {1}", doubleData, floatData);
//            Console.ReadKey();
//        }
//    }
//}


//namespace 3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = 888;
//            object o = a; // типо указатель
//            Console.WriteLine(a);
//            o = 999;
//            a =(int) o;
//            Console.WriteLine(0); // распаковка f

//            //неявноя типизация
//            int z = 2;
//            var f = 0.5;
//            var sl = z + f;
//            Console.WriteLine(sl);


//            // обнуляемая

//            int? d = 1;
//             if (d.HasValue)
//            {
//                Console.WriteLine(d.Value);
//            }
//            else
//            {
//                Console.WriteLine("не имеет значения");
//            }

//            int? w = null;
//            if (w.HasValue)//Has value - имеет значение 
//            {
//                Console.WriteLine(w.Value);
//            }
//            else
//            {
//                Console.WriteLine("не имеет значения");
//            }

//            Console.ReadKey();
//        }
//    }
//}

//namespace strocc
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string strok1 = "asus";
//            string strok2 = "aplle";
//           

//            bool res = strok1.Equals(strok2);
//            Console.WriteLine(res);
//            string strok3 = "lala";
//            string strok4 = "press f to pay resp";
//            string strok5 = "+";
//            string strok6 =strok4 + " " + strok3 ;
//            string strok7 = String.Concat(strok5, strok6);
//            Console.WriteLine(strok7);

//            string text = "А кто знает, почему и зачем? ";
//            string[] wor = text.Split(new char[] { ' ' }); 
//            foreach (string s  in wor)
//            {
//                Console.WriteLine(s);
//            }


//            strok2 = strok2.Insert(5, strok2) ;

//            Console.WriteLine(strok1);
//            strok2 = strok2.Remove(5, 5);
//            Console.WriteLine(strok2);
//            Console.ReadKey();


//            string empty = "";
//            string Nullstr = null;
//            if(string.IsNullOrEmpty(empty))
//            {
//                Console.WriteLine("null");

//            }
//            bool res2 = empty.Equals(Nullstr);
//            Console.WriteLine(res2);

//            StringBuilder qw = new StringBuilder("как дела?:D");
//            Console.WriteLine(qw);
//            qw.Insert(0,"L");
//            qw.Insert(4, "W");
//            qw.Remove(4, 2);
//            Console.WriteLine(qw);

//        }
//    }
//}

//namespace arr1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//           int[,] arr = { 
//             { 1, 2, 3 },
//             { 4, 5, 6 },
//             { 7, 8, 9 } 
//                           };
//            int gro = arr.GetUpperBound(0) + 1;
//            int col = arr.Length / gro;
//            for(int i=0; i<gro; i++)
//            {
//                for(int o = 0; o < col; o++)
//                {
//                    Console.WriteLine($"{arr[i,o]} \t");
//                }
//                Console.WriteLine();
//            }
//            Console.ReadKey();
//        }


//    }
//}

namespace arr1
{
    class Program
    {
        static void Main(string[] args)
        {

            (int age, string name, char sex, string surname, ulong dtOFbith) tuple = (18, "Pavel", 'm', "Bobrov", 03_07_2002);
            Console.WriteLine(tuple);
            Console.WriteLine("Имя: {0}; Фамилия: {1}; Возраст:{2};", tuple.name, tuple.surname, tuple.age);
            (int a, int b) tu1 = (1, 42);
            (int c, double d) tu2 = (1, 42);
            (int c, double d) tu4 = (1, 42);
            (int a, int b) tu3 = (2, 42);
            Console.WriteLine(tu1.CompareTo(tu3));
            Console.WriteLine(tu4.CompareTo(tu2));


            (int age, string name, char sex, string surname, ulong dtOFbith) Func() => (18, "Pavel", 'm', "Bobrov", 03_07_2002);
            {


                (string first, string middle, string last) = ("one", "two", "three");
                Console.WriteLine($"{first},{middle}, {last}");
                Console.WriteLine();
                Console.ReadKey();

            }

            ret Func;

        }
    }
} 


//    namespace func
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            int[] f = new int [] { 1, 2, 4, 8, 9 };
//            string q = "hello from pasha";


//            var tuple = GetValues(f, q);
//            Console.WriteLine($"Макс элемент: {tuple.Max}");

//            Console.WriteLine($"Мин элемент: {tuple.Min}");
//            Console.WriteLine($"Сумма элементов: {tuple.Sum}");


//            Console.WriteLine($"Первый символ строки: {tuple.First}");
//            Console.ReadKey();

//        }
//        private static (int Max, int Min, int Sum, string First) GetValues(int[] f, string q)
//        {
//            var result = (Max: f[0], Min: f[0], Sum: 0, First: "");
//            result.First = q.Remove(1);
//            for (int i = 0; i <f.Length; i++ )
//            {
//                result.Sum += f[i];
//            }
//            for(int i =0; i< f.Length; i++ )
//            {
//              if (result.Max < f[i])
//                {
//                    result.Max = f[i];
//                }

//            }
//            return result;
//        }
        
//    }
//}





