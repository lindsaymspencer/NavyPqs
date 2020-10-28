using System.IO;

namespace NavyPqs.Services
{
    public class FileHelper
    {
        public static void WriteTo(string path, string content)
        {
            EnsureDirectoryExists(path);
            EnsureFileExists(path);
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(content);
            }
        }

        public static void WriteOver(string path, string content)
        {
            EnsureFileExists(path);
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(content);
            }
        }

        private static void EnsureDirectoryExists(string path)
        {
            string directory = Path.GetDirectoryName(path);
            if (!File.Exists(directory))
            {
                CreateDirectory(directory);
            }
        }

        private static void EnsureFileExists(string path)
        {
            EnsureDirectoryExists(path);
            if (!File.Exists(path))
            {
                using (FileStream f = File.Create(path)) { }
            }
        }

        private static void CreateDirectory(string directory)
        {
            Directory.CreateDirectory(directory);
        }
    }
}
