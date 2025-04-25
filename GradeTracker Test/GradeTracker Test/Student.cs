using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker_Test
{
    internal class Student : User
    {
        /// <summary>
        /// Keep all the students assignment info (their grade and comments spesific to them)
        /// with the assignemt in the course as the key to the student copy as value.
        /// </summary>
        public Dictionary<Assignment, Assignment> studentAssignments = new Dictionary<Assignment, Assignment>();
        
        public Student (string username, string password)
            : base (username, password)
        {

        }

        // Add a copy of the assignment in course for this student with couses assignemt as key.
        public void addAssignment(Assignment courseAssignment)
        {
            Assignment studentAssignment = new Assignment(courseAssignment.Title, courseAssignment.FullPoints);
            studentAssignments[courseAssignment] = studentAssignment;
        }

        //Return a ref to the students copy given the course assignment.
        public override Assignment GetAssignment(Assignment courseAssignment)
        {
            return studentAssignments[courseAssignment];
        }

        public double CalculateGrade(Course course)
        {
            double scored = 0;
            double total = 0;

            foreach (Assignment courseAssignment in course.Assignments.Values)
            {
                scored += this.studentAssignments[courseAssignment].pointsScored;
                total += this.studentAssignments[courseAssignment].FullPoints;
            }

            if (total != 0)
            {
                return (scored / total) * 100;
            }
            else
            {
                return 0;
            }
        }

        public double CalculateGPA()
        {
            double total = 0;
            double count = 0;
            foreach(var course in this.Courses.Values)
            {
                total += this.CalculateGrade(course);
                count++;
            }

            return ((total / count)/100)*4;
        }
    }
}
