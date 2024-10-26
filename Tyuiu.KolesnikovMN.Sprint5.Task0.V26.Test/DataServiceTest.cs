using Tyuiu.KolesnikovMN.Sprint5.Task0.V26.Lib;

namespace Tyuiu.KolesnikovMN.Sprint5.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Matvey\source\repos\Tyuiu.KolesnikovMN.Sprint5\Tyuiu.KolesnikovMN.Sprint5.Task0.V26\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}