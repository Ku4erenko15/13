using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 6.Определить статический метод void Numbers(int n), 
            //    который выводит на экран четные числа от 2 до числа n.
            //    Используя этот метод, вывести на экран четные числа:
            //а) от 2 до 20;
            //б) от 2 до 50;
            //в) от 2 до m
            Numbers(20);
            Console.WriteLine("Четные числа от 2 до 50:");
            Numbers(50);
            Console.Write("Введите значение m: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine($"Четные числа от 2 до {m}:");
            Numbers(m);
            Console.ReadKey();
        }
        public static void Numbers(int n)
        {
            
            for (int i = 2; i <= n; i += 2)
            {
                Console.WriteLine(i + " ");
            }
            
        }

    }
}
