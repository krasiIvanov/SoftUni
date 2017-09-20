using System.Collections.Generic;
using System.IO;

namespace BashSoft
{
    public static class StudentsRepository
    {
        public static bool isDataInitilize = false;
        private static Dictionary<string, Dictionary<string, List<int>>> studentsByCourse;

        public static void InitializeData(string fileName)
        {
            if (!isDataInitilize)
            {
                OutputWriter.WriteMessegesOnNewLine("Read Data...");
                studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
                ReadData(fileName);
                isDataInitilize = true;
            }
            else
            {
                OutputWriter.WriteMessegesOnNewLine(ExceptionMessages.DataAlreadyInitializedException);
            }
        }

        private static void ReadData(string fileName)
        {
            string path = SessionData.currentPath + "\\" + fileName;
            if (Directory.Exists(path))
            {
                string[] tokens = path.Split(' ');
                string course = tokens[0];
                string student = tokens[1];
                int mark = int.Parse(tokens[2]);

                if (!studentsByCourse.ContainsKey(course))
                {
                    studentsByCourse.Add(course, new Dictionary<string, List<int>>());
                }
                if (!studentsByCourse[course].ContainsKey(student))
                {
                    studentsByCourse[course].Add(student, new List<int>());
                }
                studentsByCourse[course][student].Add(mark);

                string[] allInputLines = File.ReadAllLines(path);
                for (int i = 0; i < allInputLines.Length; i++)
                {
                    if (!string.IsNullOrEmpty(allInputLines[i]))
                    {
                        string[] data = allInputLines[i].Split(' ');
                    }
                }
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
            }

            isDataInitilize = true;
            OutputWriter.WriteMessegesOnNewLine("Data Read!");
        }

        private static bool isQueryForCoursePossible(string courseName)
        {
            if (isDataInitilize)
            {
                if (studentsByCourse.ContainsKey(courseName))
                {
                    return true;
                }
                else
                {
                    OutputWriter.DisplayException(ExceptionMessages.InexistingCourseInDataBase);
                }
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.DataNotInitializedExceptionMessage);
            }
            return false;
        }

        private static bool isQueryForStudentPossible(string courseName, string studentUserName)
        {
            if (isQueryForCoursePossible(courseName) && studentsByCourse[courseName].ContainsKey(studentUserName))
            {
                return true;
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InexistingStudentInDataBase);
            }
            return false;
        }

        public static void GetStudentScoreFromCourse(string courseName, string studentUserName)
        {
            if (isQueryForStudentPossible(courseName, studentUserName))
            {
                OutputWriter.PrintStudent(new KeyValuePair<string, List<int>>(studentUserName, studentsByCourse[courseName][studentUserName]));
            }
        }

        public static void GetAllStudentFromCourse(string courseName)
        {
            if (isQueryForCoursePossible(courseName))
            {
                OutputWriter.WriteMessegesOnNewLine($"{courseName}");
                foreach (var item in studentsByCourse[courseName])
                {
                    OutputWriter.PrintStudent(item);
                }
            }
        }
    }
}