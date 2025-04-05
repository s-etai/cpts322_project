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
            Assignments = assignments;

            foreach (var student in students)
            {
                this.addStudent(student);
            }
        }

        /// <summary>
        /// When a student is added to this course, add them to the list of students,
        /// and add this course to the student's course dictionary. 
        /// </summary>
        /// <param name="student"></param>
        public void addStudent (Student student)
        {
            Students.Add(student);
            student.Courses.Add(this.CourseName, this);
        }


    }
}
