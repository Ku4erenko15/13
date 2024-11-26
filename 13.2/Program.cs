using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 2.Найти минимальную величину их трех целых переменных a, b, c 
            //с использованием вспомогательных методов(ввода аргументов,
            //нахождения минимальной величины, вывода результата).
            int x = Input("x=");
            int y = Input("y=");
            int z = Input("z=");
            int min = Min(Min(x, y),z);
            Console.WriteLine(min);
            Console.ReadLine();
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
