using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KasenovAE.Sprint1.Task3.V18.Lib;

namespace Tyuiu.KasenovAE.Sprint1.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Касенов А. Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Касенов Айдархан Есенаевич | ПКТб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет, сколько квадратов со стороной C  *");
            Console.WriteLine("* можно разместить внутри прямоугольника с размерами A x B без наложений. *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("A = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("B = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("C = ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Console.Write($"В прямоугольник поместится {ds.HowManySquares(a, b, c)} квадратов");
            Console.ReadKey();
        }
    }
}
