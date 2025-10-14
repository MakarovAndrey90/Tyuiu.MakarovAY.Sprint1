using Tyuiu.MakarovAY.Sprint1.Task3.V18.Lib;
namespace Tyuiu.MakarovAY.Sprint1.Task2.V27
{
    class Programm()
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Макаров А. Я. | РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые Навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Макаров А. Я.   | РППб-25-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет, сколько квадратов со стороной C  *");
            Console.WriteLine("* можно разместить внутри прямоугольника с размерами A x B без наложений. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            int a;

            Console.WriteLine("Введите значение a");
            a = Convert.ToInt32(Console.ReadLine());

            int b;

            Console.WriteLine("Введите значение b");
            b = Convert.ToInt32(Console.ReadLine());
            
            int c;

            Console.WriteLine("Введите значение c");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество квадратов, которые можно разместить внутри прямоугольника равно = " + ds.HowManySquares(a, b, c));

            Console.ReadKey();
        }
    }
}
