using System;
using System.Collections.Generic;
using System.Linq;

namespace ByExample
{
    class Program
    {
        static void Main()
        {
            Person Pesho = new Person("Pesho", 18);
            Person Minka = new Person("Minka", "minkaeboginq@gmail.com", 48);
            Console.WriteLine(Pesho);
            Console.WriteLine(Minka);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        private string email;
        private int age;

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (email != null && !email.Contains("@"))
                {
                    throw new ArgumentException("Invalid e-mail address.");
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (age < 0 || age > 200)
                {
                    throw new IndexOutOfRangeException("Invalid age.");
                }
            }
        }

        public Person(string name, string email, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age): this (name, null, age)
        {

        }
    }
}
