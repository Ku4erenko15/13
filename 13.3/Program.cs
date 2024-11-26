using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 3.Найти s = min(a, b) + min(c, d), 
            //используя вспомогательные функции
            //(ввода аргументов, нахождения минимальной величины, вывода результата).
            int a = Input("a=");
            int b = Input("b=");
            int c = Input("c=");
            int d = Input("d=");
            int s = Min(a, b) + Min(c, d);
            Console.Write(s);
            Console.Read();

        }
        static int Min(int x, int y)
        {
            return x < y ? x : y;
        }
        public static int Input(string a)
        {
            Console.Write(a);
            return int.Parse(Console.ReadLine());
        }
    }
    
}

