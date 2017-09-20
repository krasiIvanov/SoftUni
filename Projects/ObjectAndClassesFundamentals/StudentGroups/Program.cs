using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    class Town
    {
        public string TownName { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }

        public static Town NewTownRead(string str)
        {
            string[] tokens = str.Split(new char[] {'=','>'},StringSplitOptions.RemoveEmptyEntries);
            var seats = tokens[1].Trim().Split();
            var countOfSeats = int.Parse( seats[0].Trim());
            var town = new Town()
            {
                TownName = tokens[0].Trim(),
                SeatsCount = countOfSeats,
                Students = new List<Student>()
            };

            return town;
        }     

    }
    class Student
    {
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public DateTime RegistrationDate { get; set; }

        public static Student NewStudentRead(string str)
        {
            string[] tokens = str.Split('|');
            var newStud = new Student()
            {
                StudentName = tokens[0].Trim(),
                StudentEmail = tokens[1].Trim(),
                RegistrationDate = DateTime.ParseExact(tokens[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture)
            };

            return newStud;
        }
        public override string ToString()
        {
            return String.Format($"{StudentName} | {StudentEmail} | {RegistrationDate:d-MMM-yyyy}");
        }
    }

    class Groups
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }

        public static List<Groups> StudentIntoGroups(List<Town> town)
        {
            List<Groups> newList = new List<Groups>();
            

            foreach (var item in town.OrderBy(x => x.TownName))
            {
                int count = 0;
                bool flag = false;
                var newGr = new Groups() { Town = item, Students = new List<Student>() };
                var sortedList = item.Students.OrderBy(x => x.RegistrationDate).ThenBy(m => m.StudentName).ThenBy(n => n.StudentEmail);

                foreach (var stud in sortedList)
                {
                    if (count < item.SeatsCount)
                    {
                        newGr.Students.Add(stud);
                        flag = true;
                        count++;
                    }
                    if (count == item.SeatsCount)
                    {
                        newList.Add(newGr);
                        flag = false;
                        newGr = new Groups() { Town = item, Students = new List<Student>() };
                        count = 0;
                    }
                }
                if (flag)
                {
                    newList.Add(newGr);
                }

            }

            return newList;

        }
    }

    class Program
    {
        static List<Town> ReadTownAndStudents()
        {
            List<Town> newList = new List<Town>();
            int pos = -1;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                if (input.Contains("=>"))
                {
                    var town = Town.NewTownRead(input);
                    newList.Add(town);
                    pos++;
                }
                else
                {
                    var newStud = Student.NewStudentRead(input);
                    newList[pos].Students.Add(newStud);

                }

            }
            return newList;
        }


        static void Main(string[] args)
        {
            List<Town> townsAndStudent = ReadTownAndStudents();
            List<Groups> groups = Groups.StudentIntoGroups(townsAndStudent);


            Console.WriteLine($"Created {groups.Count} groups in {townsAndStudent.Count} towns");
           
            foreach (var item in groups)
            {
                var emailList = new List<string>();
                foreach (var stud in item.Students)
                {
                    emailList.Add(stud.StudentEmail);
                }
                Console.WriteLine($"{item.Town.TownName} => {string.Join(", ",emailList)}");
            }
            }
    }
}
