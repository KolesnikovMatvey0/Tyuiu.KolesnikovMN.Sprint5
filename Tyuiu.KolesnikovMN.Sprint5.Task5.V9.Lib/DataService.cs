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
                while ( ( line = reader.ReadLine() ) != null)
                {
                    line = line.Replace('.', ',');
                    if ( res < Convert.ToDouble( line ) )
                        res = Convert.ToDouble( line );
                }
            }
            return res;
        }
    }
}
