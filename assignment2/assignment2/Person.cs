using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Person
    {
        public int age;
        public string firstname;
        public string lastname;
        public Person spouse ;
       public static int sumofAllAges;
        
        public string GetFullName()
        {
            return this.firstname + " " + this.lastname;
        }
        public void PrintNameAndAge()
        {
           Console.WriteLine(this.firstname + " " + this.lastname + this.age);
        }

            


    }
}
