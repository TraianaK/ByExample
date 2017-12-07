using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace FileUsage
{
    class FileUsage
    {
        static void Main()
        {
            string fileName = "test.txt";
            string fileContent = "line 1" + Environment.NewLine + "line 2" + Environment.NewLine + "line 3" + Environment.NewLine;

            UpdateFile(fileName, fileContent);

            fileContent = ReadFile(fileName);

            Console.WriteLine(fileContent);
            Console.WriteLine(CountWords(fileContent));

        }
        public static void UpdateFile(string fileName, string content)
        {
            if (!File.Exists(fileName))
            {
                StreamWriter writer = File.CreateText(fileName);
                writer.Write(content);
                writer.Close();
            }
            else
            {
                using (StreamWriter writer = File.AppendText(fileName))
                {
                    writer.Write(content);
                }

            }
        }
        public static string ReadFile(string fileName)
        {
            return File.ReadAllText(fileName);
        }
        public static int CountWords (string freeText)
        {
            int result = 0;
            freeText = freeText.Trim();
            if (string.IsNullOrEmpty(freeText))
            {
                return 0;
            }

            freeText = freeText.Replace(" ", " ");
            freeText = freeText.Replace(Environment.NewLine, " ");

            foreach  (string y  in freeText.Split(' ' ))
            {
                result++;
            }
            return result; 
        }
    }
}
