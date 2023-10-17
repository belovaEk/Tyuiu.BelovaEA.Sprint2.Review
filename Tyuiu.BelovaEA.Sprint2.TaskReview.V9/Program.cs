using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BelovaEA.Sprint2.TaskReview.V9.Lib;

namespace Tyuiu.BelovaEA.Sprint2.TaskReview.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Белова Е. А. | ИИПб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* SprintReview                                                            *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                               *");
            Console.WriteLine("* Задание #8                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила: Белова Екатерина Андреевна | ИИПб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает координаты точки (x, y) и *");
            Console.WriteLine("* проверяет находится ли эта точка в заштрихованной области.              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите x:                                                                *");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y:                                                                *");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"x = {x}\ny = {y}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (ds.CheckDotInShadedArea(x,y))
            {
                Console.WriteLine($"Точка с координатами ({x}, {y}) находится в заштрихованной области.");
            }
            else
            {
                Console.WriteLine($"Точка с координатами ({x}, {y}) не находится в заштрихованной области.");
            }
            

            Console.ReadKey();
        }
    }
}
