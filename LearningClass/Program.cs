using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1;
            p1 = new Person();
            p1.firstName = "Donnie";
            p1.lastName = "Santos";
            string s = p1.GetFullName();
            p1.
            Console.WriteLine("this is what you got " + s);
            Console.ReadLine();

        }
    }

    
}
