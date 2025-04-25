using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker_Test
{
    public class Teacher : User
    {
        //public List<Course> CourseList;
        //public Dictionary<string, Course> CourseList = new Dictionary<string, Course>();

        public Teacher(string username, string password)
        : base(username, password)
        {

        }

    }
}
