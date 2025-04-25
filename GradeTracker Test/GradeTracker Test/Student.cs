using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker_Test
{
    public class Student : User
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
    }
}
