using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Students
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AvgGrade
        {
            get
            {
                return this.Grades.Average();
            }
        }

        public static List<Students> ReadStudents()
        {
            var list = new List<Students>();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] info = Console.ReadLine().Split(' ');
                List<double> grades = new List<double>();
                for (int j = 1; j < info.Length; j++)
                {
                    grades.Add(double.Parse(info[j]));
                }
                var newStudent = new Students() { Name = info[0], Grades = grades };
                list.Add(newStudent);
                
            }
            
            return list;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var listOfStudents = Students.ReadStudents().OrderByDescending(x=>x.AvgGrade);
            var sortedList = listOfStudents.OrderBy(x => x.Name);

            foreach (var item in sortedList)
            {
                if (item.AvgGrade>=5)
                {
                    Console.WriteLine($"{item.Name} -> {item.AvgGrade:f2}");
                }
            }
        }
    }
}
