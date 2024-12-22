using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KolesnikovMN.Sprint5.Task6.V17.Lib
{
    public class DataService : ISprint5Task6V17
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int chCount = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == ' ')
                            chCount++;
                        if (line[i] != ' ')
                            chCount = 0;
                        if (chCount > 1)
                            count += chCount;

                            
                    }
                }
            }
            return count;
        }
    }
}
