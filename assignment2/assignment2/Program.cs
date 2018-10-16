using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args) 
        {
            Person p1, p2;
            p1 = new Person();
            p2 = new Person();

            string justType (string toDisplay)
            {
                string anyinput = "";
                Console.Write( toDisplay + ": ");
                return anyinput = Console.ReadLine();
            }

            Console.WriteLine("[ Enter information for P1 ]\n");
            setPersonValues(p1);
            Console.WriteLine("\n[Enter information for p2]\n");
            setPersonValues(p2);
            
            void setPersonValues(Person p)
            {
                p.firstname = justType("Enter you first name             ");
                p.lastname = justType("Enter your last name             ");
                p.age = int.Parse(justType("Enter your age                   "));
                p.spouse = new Person();
                p.spouse.firstname = justType("Enter your spouse first name     ");
                p.spouse.age = int.Parse(justType
                                             ("Enter your spouse age            "));
            }
                       
            //p1.firstname = justType(      "Enter you first name             ");
            //p1.lastname = justType(       "Enter your last name             "); 
            //p1.age = int.Parse(justType(  "Enter your age                   "));
            //p1.spouse = new Person();
            //p1.spouse.firstname =justType("Enter your spouse first name     ");
            //p1.spouse.age = int.Parse(justType
            //                             ("Enter your spouse age            "));

            //Console.WriteLine("\n[Enter information for p2]\n");
            //p2.firstname = justType      ("Enter your first name            "); 
            //p2.lastname = justType       ("Enter your last name             "); 
            //p2.age = int.Parse (justType ("Enter your age                   "));
            //p2.spouse = new Person();
            //p2.spouse.firstname =justType("Enter your spouse first name     ");
            //p2.spouse.age = int.Parse (justType
            //                             ("Enter your spouse age            "));

            Person.sumofAllAges = p1.age + p1.spouse.age + p2.age + p2.spouse.age;
            Console.WriteLine("sum of all ages : " + Person.sumofAllAges );
            
            Console.WriteLine("average age is : " + Person.sumofAllAges/4);
            int average = int.Parse(Console.ReadLine());





        }
    }
}
