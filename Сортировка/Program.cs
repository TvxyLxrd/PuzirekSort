using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сортировка
{
    internal class Program
    {
        static int[] SortPuzirek(int[] mas)// Функция сортировки методом пузырька.
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)// Создаём цикл, где сравниваем число (i) с числом (j) и в зависимости от результата берём следующее число.
            {
                for (int j = i + 1; j < mas.Length; j++)// Если элемент массива под номером i будет больше, чем элемент массива под номером j, то меняем элементы местами и продолжаем сравнение дальше, как в алгоритме.
                {
                    if (mas[i] > mas[j]) // Сортировка по большему числу, можно сделать по меньшему, если поменять знак.
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;// Функция, возвращающая отсортированный массив.
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Количество чисел:"); // Считываем информацию, которую вводят с клавиатуры.
            int N = Convert.ToInt32(Console.ReadLine()); // Считываем информацию, которую вводят с клавиатуры.
            Console.WriteLine("Введите числа, чтобы отсортировать их:");// Считываем информацию, которую вводят с клавиатуры.
            int[] mas = new int[N]; // Считываем информацию, которую вводят с клавиатуры.
            for (int i = 0; i < mas.Length; i++) // Считываем информацию, которую вводят с клавиатуры.
            {
                mas[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            SortPuzirek(mas); // Вызываем функцию сортировки, передавая ей считанный массив и получаем отсортированный массив.
            Console.WriteLine("После сортировки:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.ReadLine();
        }
    }
}
