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

        // Collection of sudents in the course
        public Dictionary<string, Student> Students = new Dictionary<string, Student>();

        // title assingment pair of assingments in the course
        public Dictionary<string, Assignment> Assignments = new Dictionary<string, Assignment>();


        public Course(string courseName, List<Student> students, List<Assignment> assignments)
        {
            CourseName = courseName;
            //Assignments = assignments;

            foreach (var student in students)
            {
                this.addStudent(student);
            }

            foreach (var assignment in assignments)
            {
                this.addAssignment(assignment);
            }
        }

        /// <summary>
        /// When a student is added to this course, add them to the list of students,
        /// and add this course to the student's course dictionary. 
        /// </summary>
        /// <param name="student"></param>
        public void addStudent (Student student)
        {
            if(!Students.ContainsKey(student.Username))
            {
                Students[student.Username] = student;
                student.Courses.Add(this.CourseName, this);

                foreach(var assignment in Assignments.Values)
                {
                    student.addAssignment(assignment);
                }
            }
        }

        /// <summary>
        /// Add assignemt to course list and add and instace to each student.
        /// </summary>
        /// <param name="assignment"></param>
        public void addAssignment (Assignment assignment)
        {
            Assignments[assignment.Title] = assignment;

            foreach (var student in Students.Values)
            {
                student.addAssignment(assignment);
            }
        }

    }
}
