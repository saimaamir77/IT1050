using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Instructor
    {
        //class properties
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string CourseName { get; set; }
        private string Name { get; set; }
        
        //class Constructor
        public Instructor(string name, string coursename)
        {
            this.Name = name;
            this.CourseName = coursename;
        }

        //method
        public void SetstudentGrade(Student s, int Grade)
        {
            s.SetGrade(Grade);


        }
       
        public void print()
        {
            // Console.WriteLine(this.FirstName + " " + this.LastName + " " + this.CourseName + " ");
            Console.WriteLine(this.Name +  " " + this.CourseName + " ");
        }
    }
}
        
        
            

            

    
    

        
    

        

       