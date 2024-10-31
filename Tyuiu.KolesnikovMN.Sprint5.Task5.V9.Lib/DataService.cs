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
                //string line;
                //while ( ( line = reader.ReadLine() ) != null)
                //{
                //    line = line.Replace('.', ',');
                //    if ( res < Convert.ToDouble( line ) )
                //        res = Convert.ToDouble( line );
                //}
                string line = reader.ReadLine();
                string[] nums = line.Split();
                for ( int i = 0; i < nums.Length; i++)
                {
                    nums[i] = nums[i].Replace('.', ',');
                    if ( nums[i][nums[i].Length-1] == '0')
                    {
                        if (res < Convert.ToDouble(nums[i]))
                            res = Convert.ToDouble(nums[i]);
                    }
                }
            }
            return res;
        }
    }
}
