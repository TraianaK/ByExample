using System;
using System.IO;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "test.txt";

            int[] intArray = { 1, 2, 3, 4, 5 };

            WriteIntArrayToFile(fileName, intArray);

            intArray = ReadIntArrayFromFile(fileName);

        }

        public static void WriteIntArrayToFile(string fileName, int[] array)
        {
            StreamWriter writer = File.AppendText(fileName);
            foreach (int i in array)
            {
                writer.Write(i.ToString() + " ");
            }
            writer.Close();
        }

        public static int [] ReadIntArrayFromFile(string fileName)
        {
            string[] fileContent = File.ReadAllText(fileName).Trim().Split(' ');

            int[] intArray = new int[fileContent.Length];
            for (int i = 0; i < fileContent.Length; i++)
            {
                intArray[i] = int.Parse(fileContent[i]);
            }

            return intArray;
        }
    }
}
