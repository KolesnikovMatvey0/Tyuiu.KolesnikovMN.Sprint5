using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KolesnikovMN.Sprint5.Task4.V17.Lib
{
    public class DataService : ISprint5Task4V17
    {
        public double LoadFromDataFile(string path)
        {
            double x = Convert.ToDouble( File.ReadAllText(path) );

            double res = Math.Round( Math.Sin( 2 / ( 3 * x ) ) + Math.Pow( x, 2 ), 3 );

            return res;
        }
    }
}
