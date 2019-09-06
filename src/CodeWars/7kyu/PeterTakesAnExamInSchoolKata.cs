using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._7kyu
{
    public class PeterTakesAnExamInSchoolKata
    {
        public static List<string> PassedStudentList(List<Student> gradeList, int acceptanceGrade)
        {
            var stringStudents = new List<string>();

            foreach (Student student in gradeList.Where(x => x.Grade >= acceptanceGrade).OrderBy(x => x.Name))
            {
                stringStudents.Add(student.Name);
            }

            return stringStudents;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public double Grade { get; set; }
    }
}
