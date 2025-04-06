using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker_Test
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Dictionary<String, Course> Courses = new Dictionary<String, Course>();

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public virtual Assignment GetAssignment(Assignment assignment)
        {
            return assignment;
        }
        
    }
}
