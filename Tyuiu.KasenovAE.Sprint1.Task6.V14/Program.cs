using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KasenovAE.Sprint1.Task6.V14.Lib;

namespace Tyuiu.KasenovAE.Sprint1.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Касенов А. Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите строку");
            string h = Console.ReadLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            if (ds.CheckLowerCaseRusLetters(h))
            {
                Console.WriteLine("Строка содержит только строчные русские буквы");
            }
            else
            {
                Console.WriteLine("Строка не состоит только из строчных русских букв");
            }
            Console.ReadKey();
        }
    }
}
