using Tyuiu.KolesnikovMN.Sprint5.Task1.V8.Lib;

namespace Tyuiu.KolesnikovMN.Sprint5.Task1.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Колесников М. Н. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Колесников Матвей Николаевич | РППб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Дана функция, на заданном диапозоне [-5; 5] с шагом 1. Произвести      *");
            Console.WriteLine("*  проверку деления на 0. При делении на ноль вернуть значение 0.         *");
            Console.WriteLine("*  Результат сохрвнить в текстовый файл OutPutFileTask1.txt и вывести     *");
            Console.WriteLine("*  на консоль в таблицу. Значения округлить до двух знаков после запятой. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"start value  = {startValue}");
            Console.WriteLine($"stop value  = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine($"Файл: {res}");
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
