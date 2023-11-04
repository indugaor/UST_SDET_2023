﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regular
{
    internal class FamilyMember
    {
        public FamilyMember(string? name, int age)
        {
            Name = name;
            Age = age;
            Children=new List<FamilyMember>();
        }

        public string? Name { get; set; }
        public int Age { get; set; }   
        public List<FamilyMember> Children { get; set; }

    }
}
