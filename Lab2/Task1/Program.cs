using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool IsPal(string s)
        {
            int i = 0;  //i - индекс первой буквы в слове
            int j = s.Length - 1; //j - индекс последней буквы в слове
            while (i < j) //пока индекс первой буквы меньше последнего:
            {
                if (s[i] != s[j]) return false; //если симметричные буквы не схожие вернуть ложное значение 
                i++; //увеличить индекс для букв первой половине
                j--; //уменшить индекс для букв второй половине
            }
            return true; //по проверке выдать правильное значение 
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\ACER\Desktop\c#\Lab2\Test-1\1-test.txt", FileMode.Open, FileAccess.Read); //использовать метод Filestream для работы с файлами в системе
            StreamReader sr = new StreamReader(fs); //использовать метод Streamreader для прочтения данных на которую отсылается Filestream
            string s = sr.ReadLine(); //Переобразуем Streamreader в строковый тип данных
            sr.Close(); //закрываем методы(закрываем обычно после того как мы уже закончили работу с файлом в системе)
            fs.Close(); //чтобы другой метод с другой функцией мог работать с файлом в системе
            if (IsPal(s)) Console.WriteLine("Yes"); // Если функция IsPal работает т.е проверяется строка s и если все правильно тогда выводится Yes
            else Console.WriteLine("No"); //иначе No
        }
    }
}