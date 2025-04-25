using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker_Test
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        //Course name as key, course as value.
        //For teachers, the list of couses they have.
        //For Students the list of couses they are in.
        public Dictionary<String, Course> Courses { get; set; } = new Dictionary<String, Course>();

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        /// <summary>
        /// Needed for the student to return a ref to their assignment copy.
        /// </summary>
        /// <param name="assignment"></param>
        /// <returns></returns>
        public virtual Assignment GetAssignment(Assignment assignment)
        {
            return assignment;
        }
        
    }
}
