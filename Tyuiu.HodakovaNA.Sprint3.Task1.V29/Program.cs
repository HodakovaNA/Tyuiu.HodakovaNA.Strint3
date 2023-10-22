using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.HodakovaNA.Sprint3.Task1.V29.Lib;

namespace Tyuiu.HodakovaNA.Sprint3.Task1.V29
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
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #29                                                              *");
            Console.WriteLine("* Выполнила: Ходакова Надежда Антоновна | АСОиУБ-23-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение    *");
            Console.WriteLine("* ряда по формуле, при x = 0,25                                            *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*     11                                                                   *");
            Console.WriteLine("* S = П ((x^2)*i)+2                                                        *");
            Console.WriteLine("*    i=1                                                                   *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            double value = 0.25;
            int startValue = 1;
            int stopValue = 11;
            double MultiplySeries = ds.GetMultiplySeries(value, startValue, stopValue);
            Console.WriteLine("Старт шага равен " + startValue);
            Console.WriteLine("Конец шага равен " + stopValue);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Произведение ряда с округлением до 3 цифр после запятой равно " + MultiplySeries);

            Console.ReadKey();
        }
    }
}
