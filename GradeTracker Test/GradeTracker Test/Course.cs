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

        public Course(string courseName, List<Student> students)
        {
            CourseName = courseName;
            Students = students;
        }



        // not sure if this should be private
        public List<Student> Students = new List<Student>();
    }
}
