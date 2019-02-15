using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Student //Публичный класс Студент
    {
        private string n; //Обьявляем пременные для Name,ID,Year
        private string i;
        private string y;

        public Student(string name, string id, string year) //Внутренний класс Студента с параметрами строк для 3 данных
        {
            n = name;  //Используем переменные и прировняем их к параметрам класса
            i = id;
            y = year;
        }
        public void PrintInfo() //Метод для вывода данных для класса Student
        {
            Console.WriteLine(n + " " + i + " " + y);
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Student s = new Student("Marlen", "18BD11059", "2018-2022");  //обьявляем новую локальную переменную для класса Student
            s.PrintInfo();  //объявить метод PrintInfo
        }
    }
}
