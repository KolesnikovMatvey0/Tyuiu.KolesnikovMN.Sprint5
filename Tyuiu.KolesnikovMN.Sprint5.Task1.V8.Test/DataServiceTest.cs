using Tyuiu.KolesnikovMN.Sprint5.Task1.V8.Lib;

namespace Tyuiu.KolesnikovMN.Sprint5.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedFileExists()
        {
            string path = @"C:\Users\Matvey\AppData\Local\Temp\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.IsTrue(fileExists);
        }
    }
}