/*****************************************************************************************************/
/* Практическая работа №8.                                                                           */
/* Выполнила: Парамонова Т. Е., 2ИСПд                                                                */
/* Задание: состаывить программу работы алгоритма с использованием итерационных циклических структур */
/*****************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая___8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Здраствуйте! Эта программа написана для суммы и среднего квадратического.");
                for (; ; ) 
                {
                    int sum = 0;
                    int count = 0;
                    double squareSum = 0;
                    Console.WriteLine("Введите последовательность целых чисел (для завершения введите 0):");
                    int n;
                    do
                    {
                        n = int.Parse(Console.ReadLine());
                        sum += n;
                        count++;
                        squareSum += Math.Pow(n, 2);
                    }
                    while (n != 0);
                    {
                         n = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine(squareSum);
                    Console.WriteLine(count);
                    double average = Math.Sqrt(squareSum / count);
                    Console.WriteLine($"Выведено число: {count}");
                    Console.WriteLine($"Сумма чисел: {sum}");
                    Console.WriteLine($"Среднее квадратическое: {average}");
                    Console.ReadLine();
                    Console.WriteLine("Хотите продолжить выполнение программы ? (Да, Нет)");
                    string choose = Console.ReadLine();
                    if (choose == "Да")
                    {
                        continue;
                    }
                    else if (choose == "Нет")
                    {
                        break ;
                    }
                    
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Что-то пошло не так. Ошибка: {e.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ReadKey();
        }
    }
}
