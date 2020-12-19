using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Высокий уровень
            try
            {
                Console.WriteLine("Введите последовательность чисел:");
                int a = 0;
                int b = int.Parse(Console.ReadLine());
                while (b != 0)
                {
                    if (b < 0) a += b;
                    b = int.Parse(Console.ReadLine());
                }
                Console.Write($"Сумма отрицательных чисел равна: {a}");
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.ReadKey();
        }
    }
}
