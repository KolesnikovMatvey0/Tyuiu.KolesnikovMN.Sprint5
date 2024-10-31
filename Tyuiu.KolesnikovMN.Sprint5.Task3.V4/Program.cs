using Tyuiu.KolesnikovMN.Sprint5.Task3.V4.Lib;

namespace Tyuiu.KolesnikovMN.Sprint5.Task3.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Колесников М. Н. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Колесников Матвей Николаевич | РППб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Дано выражение вычислить его значение при x = 3, результат сохранить   *");
            Console.WriteLine("*  в бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить    *");
            Console.WriteLine("*  до трёх знаков после запятой.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int x = 3;

            Console.WriteLine($"Переменная X = {x}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine($"Файл: {res}");
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
