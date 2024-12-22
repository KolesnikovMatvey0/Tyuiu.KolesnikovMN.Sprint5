using Tyuiu.KolesnikovMN.Sprint5.Task7.V27.Lib;

namespace Tyuiu.KolesnikovMN.Sprint5.Task7.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Колесников М. Н. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Колесников Матвей Николаевич | РППб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Дан файл С:\\DataSprint5\\InPutDataFileTask7V27.txt (файл взять из       *");
            Console.WriteLine("*  архива согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\*");
            Console.WriteLine("*  и скопировать в неё файл) в котором есть набор символьных данных.      *");
            Console.WriteLine("*  Удалить все пробелы, идущие подряд больше одного. Полученный результат *");
            Console.WriteLine("*  сохранить в файл OutPutDataFileTask7V27.txt.                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string path = Console.ReadLine();

            Console.WriteLine($"Данные находится в файле = {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string pathSaveFile = ds.LoadDataAndSave(path);

            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
