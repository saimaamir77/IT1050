using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor("John", "English");
            Instructor Mike = new Instructor("Mike", "Math");
            Student Jane = new Student("Jane", John);
            Student Joe = new Student("Joe", John);
            Student Melissa = new Student("Melissa", Mike);
            Student Matt = new Student("Matt", Mike);
            John.SetstudentGrade(Jane, 95);
            John.SetstudentGrade(Joe, 85);
            Mike.SetstudentGrade(Melissa, 90);
            Mike.SetstudentGrade(Matt, 92);
            Jane.print();
            Joe.print();
            Melissa.print();
            Matt.print();
            Console.ReadLine();
       
        
        }
       
     
        
    }
}
