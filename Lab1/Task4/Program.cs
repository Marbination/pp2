using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); //прочитать с консоли вводимое число
            for (int i = 1; i <= a; i++)
            {                                        //двойной цикл для вывода определенного символа 
                for (int j = 1; j <= i; j++)         //зависимо от увеличения переменного в цикле (i,j)
                {
                    Console.Write("[*]");  //вывести  символы
                }
                Console.Write("\n"); //Пропустить строку и начать с новой строки
            }
        }
    }
}