using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KolesnikovMN.Sprint5.Task3.V4.Lib
{
    public class DataService : ISprint5Task3V4
    {
        public string SaveToFileTextData(int x)
        {
            string[] paths = { $@"{ Path.GetTempPath() }", "OutPutFileTask3.bin" };
            string path = Path.Combine( paths );

            double res = Math.Round(Math.Log( (x + 1.0) / (x + 2.0) ), 3 );

            using ( BinaryWriter writer = new BinaryWriter( File.Open ( path, FileMode.OpenOrCreate ), Encoding.UTF8 ) )
            {
                writer.Write( BitConverter.GetBytes(res) );
            }
            return path;
        }
    }
}
