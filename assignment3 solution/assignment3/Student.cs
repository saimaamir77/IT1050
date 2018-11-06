using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Student
    {
        private string Name { get; set; }
        private Instructor Teacher { get; set; }
        private int Grade { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string CourseName { get; set; }

        public Student(string name, Instructor teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Grade = 0;
        }

        public void SetGrade(int studentGrade)
        {
            this.Grade = studentGrade;
        }
        public void print()
        {
            Console.Write(this.Name + " " + this.Grade + " "  );
            this.Teacher.print();
        }
      
        
          
            
              

            

}
}
