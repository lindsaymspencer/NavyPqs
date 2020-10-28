using System.Text;
using System.IO;

namespace NavyPqsTestFixture.Services
{
    internal static class FileIoForTests
    {
        internal const string TestDirectory = @"C:\TempTests";
        internal const string TestFileName = "MyTest";
        internal static string TestFileFullName;
        internal static bool deleteDirectory = false;

        internal static void CreateTestDirectory()
        {
            Directory.CreateDirectory(TestDirectory);
            deleteDirectory = true;
        }

        internal static void CreateTestFile(string extension)
        {
            if (!Directory.Exists(TestDirectory))
            {
                CreateTestDirectory();
            }

            TestFileFullName = Path.Combine(TestDirectory, TestFileName + extension);

            if (File.Exists(TestFileFullName))
            {
                File.Delete(TestFileFullName);
            }

            using (FileStream fs = File.Create(TestFileFullName))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("");
                fs.Write(info, 0, info.Length);
            }
        }

        internal static void CleanUpTestFile()
        {
            if (File.Exists(TestFileFullName))
            {
                File.Delete(TestFileFullName);
            }
        }

        internal static void CleanUpTestDirectory()
        {
            if (!Directory.Exists(TestDirectory))
            {
                return;
            }

            // https://www.csharp-examples.net/delete-all-files/
            string[] filePaths = Directory.GetFiles(TestDirectory);
            foreach (string filePath in filePaths)
            {
                File.Delete(filePath);
            }

            Directory.Delete(TestDirectory);
        }

        internal static string ReadTestFileContents()
        {
            string contents = "";
            using (StreamReader sr = File.OpenText(TestFileFullName))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    contents += s;
                }
            }
            return contents;
        }

        internal static void TearDown()
        {
            CleanUpTestFile();
            if (deleteDirectory)
            {
                CleanUpTestDirectory();
            }

        }
    }
}
