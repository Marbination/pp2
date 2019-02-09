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
        static bool IsPrime(int x)
        {
            if (x < 2) 
            {
                return false;
            }
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static bool StIsPrime(string s)
        {
            return IsPrime(int.Parse(s));
        }
        static void Main(string[] args)
        {
            List<string> res = new List<string>();
            FileStream fs = new FileStream(@"C:\Users\ACER\Desktop\c#\Lab2\Test\2-test-input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string text = sr.ReadLine();
            string[] nums = text.Split(' ');

            foreach (var x in nums)
            {
                if (StIsPrime(x)) res.Add(x);
            }
            sr.Close();
            fs.Close();

            FileStream fs1 = new FileStream(@"C:\Users\ACER\Desktop\c#\Lab2\Test\2-test-output.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs1);
            foreach (var x in res)
            {
                sw.Write(x + " ");
            }
            sw.Close();
            fs1.Close();
        }
    }
}