using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KolesnikovMN.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        private string[] strValues;

        public double LoadFromDataFile(string path)
        {
            double res = double.MinValue;
            using ( StreamReader reader = new StreamReader(path) )
            {
                string line;
                string[] values;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] strValues = line.Split();
                    double[] dbValues = new double[strValues.Length];
                    for (int i = 0; i < strValues.Length; i++)
                    {
                        dbValues[i] = double.Parse(strValues[i], System.Globalization.CultureInfo.InvariantCulture);
                    }
                    for (int j = 0;j < dbValues.Length; j++)
                    {
                        if (Math.Round(dbValues[j], 0) == dbValues[j])
                            if (dbValues[j] > res)
                                res = dbValues[j];

                    }
                }
            }
            return res;
        }
    }
}
