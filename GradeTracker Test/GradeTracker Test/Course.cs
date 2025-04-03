using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker_Test
{
    internal class Course
    {
        public string CourseName { get; set; }

        // not sure if this should be private
        public List<Student> Students = new List<Student>();

        public List<Assignment> Assignments = new List<Assignment>();


        public Course(string courseName, List<Student> students, List<Assignment> assignments)
        {
            CourseName = courseName;
            Students = students;
            Assignments = assignments;
        }


    }
}
