using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker_Test
{
    internal class Student : User
    {

        Dictionary<Assignment, Assignment> studentAssignments = new Dictionary<Assignment, Assignment>();
        
        public Student (string username, string password)
            : base (username, password)
        {

        }

        public void addAssignment(Assignment courseAssignment)
        {
            Assignment studentAssignment = new Assignment(courseAssignment.Title, courseAssignment.FullPoints);
            studentAssignments[courseAssignment] = studentAssignment;
        }
    }
}
