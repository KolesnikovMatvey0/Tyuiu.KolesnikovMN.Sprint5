using Tyuiu.KolesnikovMN.Sprint5.Task7.V27.Lib;

namespace Tyuiu.KolesnikovMN.Sprint5.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\Matvey\AppData\Local\Temp\OutPutDataFileTask7V27.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            
            Assert.IsTrue(fileExists);
        }
    }
}