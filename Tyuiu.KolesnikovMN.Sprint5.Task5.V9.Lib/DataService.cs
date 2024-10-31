using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KolesnikovMN.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V7
    {
        public double LoadFromDataFile(string path)
        {
            double res = double.MinValue;
            using ( StreamReader reader = new StreamReader(path) )
            {
                string line;
                while ( ( line = reader.ReadLine() ) != null)
                {
                    if ( res < Convert.ToDouble( line ) )
                        res = Convert.ToDouble( line );
                }
            }
            return res;
        }
    }
}
