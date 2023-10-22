using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.HodakovaNA.Sprint3.Task2.V10.Lib;

namespace Tyuiu.HodakovaNA.Sprint3.Task2.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Ходакова Н. А. | АСОиУБ-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                    *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #10                                                              *");
            Console.WriteLine("* Выполнила: Ходакова Надежда Антоновна | АСОиУБ-23-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет          *");
            Console.WriteLine("* произведение ряда по формуле, при t = 1                                  *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*     13                                                                   *");
            Console.WriteLine("* S = П ((1^k)+(1/k+1))                                                        *");
            Console.WriteLine("*    k=1                                                                   *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int value = 1;
            int startValue = 1;
            int stopValue = 13;

            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага равен " + startValue);
            Console.WriteLine("Конец шага равен " + stopValue);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Произведение ряда с округлением до 3 цифр после запятой равно " + ds.GetMultiplySeries(value, startValue, stopValue));

            Console.ReadKey();
        }
    }
}