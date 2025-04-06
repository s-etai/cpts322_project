using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker_Test
{
    internal class Assignment
    {
        public string Title { get; set; }
        public double FullPoints { get; set; }

        public double pointsScored { get; set; }

        public List<String> comments;

        public Assignment(string title, double fullPoints)
        {
            Title = title;
            FullPoints = fullPoints;
            pointsScored = 0;
        }

    }
}
