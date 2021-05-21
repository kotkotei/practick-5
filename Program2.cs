using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите наруто число");
            int a = Convert.ToInt32(Console.ReadLine()); ;
            int i = 2;
            while (i < a)
            {
                i++;
             }
            Console.WriteLine(i);
            Console.ReadKey();
            
        }
    }
}
