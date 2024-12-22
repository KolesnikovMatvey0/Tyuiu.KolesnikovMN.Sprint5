using Tyuiu.KolesnikovMN.Sprint5.Task6.V17.Lib;

namespace Tyuiu.KolesnikovMN.Sprint5.Task6.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Колесников М. Н. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Колесников Матвей Николаевич | РППб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Дан файл С:\\DataSprint5\\InPutDataFileTask6V17.txt (файл взять из       *");
            Console.WriteLine("*  архива согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\*");
            Console.WriteLine("*  и скопировать в неё файл) в котором есть набор символьных данных.      *");
            Console.WriteLine("*  Найти количество пробелов, идущих подряд больше одного, в заданной     *");
            Console.WriteLine("*  строке.                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string[] paths = {Path.GetTempPath(),"InPutDataFileTask6V17.txt"};
            string path = Path.Combine(paths);

            Console.WriteLine($"Данные находится в файле = {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine($"Результат = {res}");
            Console.ReadKey();
        }
    }
}
