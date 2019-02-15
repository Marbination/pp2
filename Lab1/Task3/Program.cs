using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static int[] Duplicate(int[] arr) //метод для дублирования массива
        {
            int[] arr2 = new int[2000];  // открытие массива вместимостью 2000 знаков чтобы мы могли наверяка иметь место для записи
            for (int i = 0; i < arr.Length; i++) 
            {
                arr2[i * 2] = arr[i];       // Сперва сохраняет основное число
                arr2[i * 2 + 1] = arr[i];   // Потом дублирует на следующее число
            }
            return arr2; 
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //Прочитывает данные с консоли  
            string[] s = Console.ReadLine().Split(); //Сохраняет числа в массив строк игнорируя лишние символи кроме чисел
            int[] arr = new int[n];              //Создание числового масиива
            for (int i = 0; i < n; i++) arr[i] = int.Parse(s[i]); //Переобразовать числа из string на int 
            int[] arr2 = Duplicate(arr);         //Новый массив для сохранения результатов метода Duplicate
            for (int i = 0; i < n * 2; i++) Console.Write(arr2[i] + " "); //Вывести результат,n*2 потому что масиив дублировался два раза
        }
    }
}