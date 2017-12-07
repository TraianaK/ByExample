using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace FileHelper
{
    public static class FileHelper
    {
        static void Main()
        {

        }
        public static void UpdateFile(string fileName, string content)
        {
            using (StreamWriter writer = File.AppendText(fileName))
            {
                writer.Write(content);
            }
        }

        public static string ReadFile(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        public static bool FileExists(string fileName)
        {
            return File.Exists(fileName);
        }

        public static void DeleteFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            else
            {
                Debug.Write(fileName + "does not exists ");
            }
        }
    }
}
