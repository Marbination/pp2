using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static bool isPrime(int n)
        {
            if (n < 2) //Ниже 2 простых чисел нет
            {
                return false;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static bool StIsPrime(string s)
        {
            return isPrime(int.Parse(s));
        }
        static void Main(string[] args)
        {
            List<string> res = new List<string>();
            FileStream fs = new FileStream(@"C:\Desktop\c#\Lab2\Task2\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs)

        }
    }
}
