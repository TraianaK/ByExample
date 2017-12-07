using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TextFile
{
    class Program
    {
        static void Main()
        {
            string fileName = "students.txt";

            List<Student> students = new List<Student>();

            students.Add(CreateStudent("John", "Smith", 3123));
            students.Add(CreateStudent("Pesho", "Kolev", 1234));
            students.Add(CreateStudent("Minka", "Patrisheva", 6521));
            students.Add(CreateStudent("Patrisiya", "Kalestrova", 1259));
            students.Add(CreateStudent("Kiro", "Kalchev", 5216));
            students.Add(CreateStudent("Misho", "Stoyanov", 4963));

            DisplayStudents(students);

            //DeleteFile(fileName);

            SaveStudentsToFile(fileName, students);

            List<Student> studentsFromFile = ReadStudentsFromFile(fileName);

            Console.ReadKey();



        }

        static Student CreateStudent(string firstName, string lastName, int studentNumber)
        {
            return new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                StudentNumber = studentNumber
            };
        }

        static void DisplayStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }

        static void SaveStudentsToFile(string fileName, List<Student> students)
        {
            StringBuilder content = new StringBuilder();
            foreach (Student student in students)
            {
                content.Append(student.ToExportString());
                content.Append(Environment.NewLine);
            }

            using (StreamWriter writer = File.AppendText(fileName))
            {
                writer.Write(content);
            }
        }
    

    static List<Student> ReadStudentsFromFile(string fileName)
    {
        IEnumerable<string> studentRecords = File.ReadLines(fileName);

        List<Student> students = new List<Student>();

        foreach (string record in studentRecords)
        {
            string[] rec = record.Split(';');

            students.Add(CreateStudent(rec[1], rec[2], int.Parse(rec[0])));
        }

        return students;
    }

    public static void DeleteFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            File.Delete(fileName);
        }
    }
}


    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentNumber { get; set; }

        public override string ToString()
        {
            return string.Format("{2:0000000} - {0} {1}", FirstName, LastName, StudentNumber);
        }
        public string ToExportString()
        {
            return string.Format("{2:0000000} - {0} {1}", FirstName, LastName, StudentNumber);
        }

    }
}
