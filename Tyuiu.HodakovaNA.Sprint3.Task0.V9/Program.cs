using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.HodakovaNA.Sprint3.Task0.V9.Lib;

namespace Tyuiu.HodakovaNA.Sprint3.Task0.V9
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
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #9                                                               *");
            Console.WriteLine("* Выполнила: Ходакова Надежда Антоновна | АСОиУБ-23-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда по   *");
            Console.WriteLine("* формуле, при x = 0,5                                                     *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*     15                                                                   *");
            Console.WriteLine("* S = Σ (1/(3+x^i))^i                                                      *");
            Console.WriteLine("*    i=1                                                                   *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            double value = 0.5;
            int startValue = 1;
            int stopValue = 7;
            double SumSeries = ds.GetSumSeries(value, startValue, stopValue);
            Console.WriteLine("Старт шага равен " + startValue);
            Console.WriteLine("Конец шага равен " + stopValue);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Произведение ряда с округлением до 3 цифр после запятой равно " + SumSeries);

            Console.ReadKey();
        }
    }
}
