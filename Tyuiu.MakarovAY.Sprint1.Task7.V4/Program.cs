using Tyuiu.MakarovAY.Sprint1.Task7.V4.Lib;
namespace Tyuiu.MakarovAY.Sprint1.Task7.V4
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Макаров А. Я.   | РППб-25-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*         |                    (          y        )  |                   *");
            Console.WriteLine("*  z = ln | (y - sqrt(|x|)) *  ( x - ------------- )  |                   *");
            Console.WriteLine("*         |                    (     x + (x^4) / 4 )  |                   *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("z = " + ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
