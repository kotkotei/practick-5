using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {//ВАРИАНТ 10 Задание 1 Дано натуральное число.Определить произведение его цифр,больших семи;
            Console.WriteLine("Введите наруто число");
            int n = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            int s = 1;
            while (n > 0)
            {
                b = n % 10;
                n = n / 10;
                if (b > 7)
                {
                    s = s * b;
                }
                Console.WriteLine(s);
                Console.ReadKey();



            }
        }
    }
}
