using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker_Test
{
    internal class Student : User
    {

        Dictionary<Course, List<int>> GradeSheet = new Dictionary<Course, List<int>>();
        public List<List<int>> Grades;
        public Student (string username, string password)
            : base (username, password)
        {

        }
    }
}
