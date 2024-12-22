using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KolesnikovMN.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            double res = double.MinValue;
            using ( StreamReader reader = new StreamReader(path) )
            {
                string line;
                string[] values;
                while ((line = reader.ReadLine()) != null)
                {
                    values = line.Split();
                    for (int i = 0; i < values.Length; i++)
                    {
                        if (res < double.Parse(values[i], System.Globalization.CultureInfo.InvariantCulture))
                            res = Math.Round(double.Parse(values[i], System.Globalization.CultureInfo.InvariantCulture), 3);
                    }
                }
            }
            return res;
        }
    }
}
