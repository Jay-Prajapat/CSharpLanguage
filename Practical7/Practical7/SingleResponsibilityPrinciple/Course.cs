﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }

        public void Subscribe(Student std)
        {
            Logger.Log("Starting Subscribe()");
            if(this.Type == "online")
            {
                Console.WriteLine("Course is Online");
            }
            else if(this.Type == "live")
            {
                Console.WriteLine("This course is Live");
            }
        }
    }
}
