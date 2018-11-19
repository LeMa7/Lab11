using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1:");
            string[] year = { "january", "february","march","april","may","june","july","august","september","october","november","december" };
            int n = 4;
            var selectedMonthWithNLetters = from m in year
                                where m.Length == n
                                select m;
            foreach(var i in selectedMonthWithNLetters)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            var selectedSummerWinterMonth = from m in year
                                            where m.Contains("january") || m.Contains("february") || m.Contains("december") || m.Contains("june") || m.Contains("july") || m.Contains("august")
                                            select m;
            foreach(var i in selectedSummerWinterMonth)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            var selectedMonthAtoZ = from m in year
                                    orderby m
                                    select m;
            foreach (var i in selectedMonthAtoZ)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            var selectedMonthWithMoreThenFourLettersAndContainsU = from m in year
                                                                   where m.Contains('u') && m.Length > 4
                                                                   select m;
            foreach (var i in selectedMonthWithMoreThenFourLettersAndContainsU)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("Задание 2-3:");
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Vasya", "Vasiliev", "Vasilievich", 18, "Bobruiskaya 25", "1337228", "FIT", 2, 3));
            students.Add(new Student(2, "Petya", "Petiev", "Petievich", 19, "Dzerzhinskogo 131", "1234567", "FIT", 3, 3));
            students.Add(new Student(3, "Vova", "Voviev", "Vovievich", 20, "Pushkina 45", "7654321", "FIT", 4, 1));

            var selectedStudentsFaculty = from s in students
                                  where s.Faculty == "FIT"
                                  select s;
            foreach(var i in selectedStudentsFaculty)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            var selectedStudentsGroup = from s in students
                                where s.Group == 2
                                select s;
            foreach (var i in selectedStudentsGroup)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            var selectedYoungStudent = from s in students
                                       orderby s.Age
                                       select s;
            Console.WriteLine(selectedYoungStudent.First());
            Console.WriteLine();

            var selectedNumberOfStudentsAndSortBySurname = from s in students
                                                           orderby s.Surname
                                                           where s.Group == 3
                                                           select s;
            foreach (var i in selectedNumberOfStudentsAndSortBySurname)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            var selectedFirstStudentWithThisName = from s in students
                                                   where s.Name == "Vova"
                                                   select s;
            Console.WriteLine(selectedFirstStudentWithThisName.First());
            Console.WriteLine();

            Console.WriteLine("Задание 4-5:");
            Console.WriteLine();

            List<int> list1 = new List<int>();
            list1.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            List<int> list2 = new List<int>();
            list2.AddRange(new int[] { 2, 4, 6, 8, 10 });

            var selectedList = from t1 in list1
                               join t2 in list2 on t1 equals t2
                               orderby t1
                               select t1;

            foreach (var s in selectedList)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }
}
