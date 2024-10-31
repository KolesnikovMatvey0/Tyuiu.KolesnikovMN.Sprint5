using Tyuiu.KolesnikovMN.Sprint5.Task5.V9.Lib;

namespace Tyuiu.KolesnikovMN.Sprint5.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Колесников М. Н. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Колесников Матвей Николаевич | РППб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Дан файл С:\\DataSprint5\\InPutDataFileTask5V9.txt (файл взять из архива *");
            Console.WriteLine("*  согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и     *");
            Console.WriteLine("*  скопировать в неё файл) в котором есть набор значений.Найти            *");
            Console.WriteLine("*  максимальное целое число в файле. Полученный результат вывести на      *");
            Console.WriteLine("*  консоль. У вещественных значений округлить до трёх знаков после        *");
            Console.WriteLine("*  запятой.                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask5V9.txt";

            Console.WriteLine($"Данные находится в файле = { path }");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine($"Максимальный элемент = { res }");
            Console.ReadKey();
        }
    }
}
