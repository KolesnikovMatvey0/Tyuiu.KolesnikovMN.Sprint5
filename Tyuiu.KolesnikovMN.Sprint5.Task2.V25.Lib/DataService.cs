using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KolesnikovMN.Sprint5.Task2.V25.Lib
{
    public class DataService : ISprint5Task2V25
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string[] paths = { $@"{Path.GetTempPath()}", "OutPutFileTask2.csv" };
            string path = Path.Combine(paths);

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
                File.Delete(path);

            for ( int i = 0; i < rows; i++ )
            {
                for ( int j = 0; j < columns; j++ )
                {
                    if ( matrix[i, j] % 2 != 0 )
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string str = "";

            for ( int i = 0;i < rows; i++ )
            {
                for ( int j = 0;j < columns; j++ )
                {
                    str += matrix[i, j] + ";";
                }

                if ( i != columns - 1 )
                    File.AppendAllText( path, str + Environment.NewLine );

                else
                    File.AppendAllText( path, str );
                str = "";
            }

            
            return path;
        }
    }
}
