﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker_Test
{
    internal class Assignment
    {
        public string Title { get; set; }
        public int FullPoints { get; set; }

        public Assignment(string title, int fullPoints)
        {
            Title = title;
            FullPoints = fullPoints;
        }

    }
}
