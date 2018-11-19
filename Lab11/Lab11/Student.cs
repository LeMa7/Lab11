using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class Student
    {
        private int number;
        private string surname;
        private string name;
        private string patronymic;
        private int age;
        private string adress;
        private string telephoneNumber;
        private string faculty;
        private int course;
        private int group;
        private readonly int id;
        private const string university = "BSTU";
        private static int quantity = 0;

        public int Number { get => number; set => number = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public int Age { get => age; set => age = value; }
        public string Adress { get => adress; set => adress = value; }
        public string TelephoneNumber { get => telephoneNumber; set => telephoneNumber = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public int Course { get => course; set => course = value; }
        public int Group { get => group; set => group = value; }

        public Student()
        {
            quantity++;
            Console.Write("Student number ");
            Console.WriteLine(quantity);
        }

        static Student()
        {
            Console.WriteLine("Создаем студентов");
            Console.WriteLine();
        }

        public Student(int number, string name, string surname, string patronymic, int age, string adress, string telephoneNumber, string faculty, int course, int group)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.age = age;
            this.adress = adress;
            this.telephoneNumber = telephoneNumber;
            this.faculty = faculty;
            this.course = course;
            this.group = group;
            id = number * 4273;
        }

        public void Info()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(patronymic);
            Console.WriteLine(age);
            Console.WriteLine(adress);
            Console.WriteLine(telephoneNumber);
            Console.WriteLine(university);
            Console.WriteLine(faculty);
            Console.WriteLine(course);
            Console.WriteLine(group);
        }

        public override string ToString()
        {
            return this.Name;
        }

    }

}
