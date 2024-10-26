using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KolesnikovMN.Sprint5.Task0.V26.Lib
{
    public class DataService : ISprint5Task0V26
    {
        public string SaveToFileTextData(int x)
        {
            string[] paths = { $@"{Path.GetTempPath()}", "OutPutFileTask0.txt" };
            string fullPath = Path.Combine(paths);
            double z = Math.Round( 0.7 * Math.Pow( x, 3 ) + 1.52 * Math.Pow( x, 2 ), 3 );
            File.WriteAllText( fullPath, z.ToString() );
            return fullPath;
        }
    }
}
