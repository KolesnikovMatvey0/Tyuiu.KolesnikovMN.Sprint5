using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KolesnikovMN.Sprint5.Task1.V8.Lib
{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string[] paths = { $@"{Path.GetTempPath()}", "OutPutFileTask1.txt" };
            string fullPath = Path.Combine( paths );

            FileInfo fileInfo = new FileInfo( fullPath );
            bool fileExists = fileInfo.Exists;

            if ( fileExists )
            {
                File.Delete( fullPath );
            }

            double y;
            string strY;

            for ( int x = startValue; x <= stopValue; x++ )
            {
                if ( 2 * x - 2 == 0 )
                {
                    strY = "0";
                }
                else
                {
                    y = Math.Round( 4 - ( 2 * x ) + ( 2 + Math.Cos( x ) ) / ( 2 * x - 2), 2 );
                    strY = y.ToString();
                }

                if (x != stopValue)
                {
                    File.AppendAllText( fullPath, strY + Environment.NewLine );
                }
                else
                {
                    File.AppendAllText ( fullPath, strY );
                }
            }
            return fullPath;
        }
    }
}
