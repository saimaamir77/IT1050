﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningClass
{
    public class Person
    {
            public string firstName;
            public string lastName;
            public string GetFullName()
            {
                return this.firstName + " " + this.lastName;
            }

        
    }
}
