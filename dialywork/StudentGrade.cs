﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class StudentGrade:StudentMarks
    {
        public string? Grade { get; set; } = string.Empty;
        public string CalculateGrade()
        {
            if (Average > 90)

                Grade = "A";
            else if (Average >= 600) Grade = "B";
            else if (Average >= 40) Grade = "C";
            else Grade = "D";
            return Grade;
            
        }

    }
}
