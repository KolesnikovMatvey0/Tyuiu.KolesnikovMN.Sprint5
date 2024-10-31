using Tyuiu.KolesnikovMN.Sprint5.Task4.V17.Lib;

namespace Tyuiu.KolesnikovMN.Sprint5.Task4.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Колесников М. Н. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Колесников Матвей Николаевич | РППб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt (файл взять из        *");
            Console.WriteLine("*  архива согласно вашему варианту. Создать папку в ручную                *");
            Console.WriteLine("*  С:\\DataSprint5\\ и скопировать в неё файл) в котором есть               *");
            Console.WriteLine("*  вещественное значение. Прочитать значение из файла и подставить вместо *");
            Console.WriteLine("*  Х в формуле . Вычислить значение по формуле (Полученное значение       *");
            Console.WriteLine("*  округлить до трёх знаков после запятой) и вернуть полученный результат *");
            Console.WriteLine("*  на консоль.                                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask4V0.txt";

            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
