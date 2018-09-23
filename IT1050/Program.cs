using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, middleInitial, lastName, fullName;
            int age, heightFeet;
            bool isCitizen, canVote;
            double heightInches, totalHeightCM;

            Console.WriteLine("What is your first name? ");

            firstName = Console.ReadLine();
            Console.WriteLine("What is your middle initial name? ");
            middleInitial = Console.ReadLine();
            Console.WriteLine("What is your last name? ");
            lastName = Console.ReadLine();
            fullName = firstName + " " + middleInitial + " " + lastName;
            Console.WriteLine("Your full name is " + fullName);
            Console.WriteLine("What is your height in feet?");
            heightFeet = int.Parse(Console.ReadLine());
            Console.WriteLine("How many inches from your base height in feet?");
            heightInches = double.Parse(Console.ReadLine());
            totalHeightCM = (heightFeet * 12 + heightInches) * 2.54;
            Console.WriteLine("What is your age? ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Are you a citizen?");
            isCitizen = bool.Parse(Console.ReadLine());
            canVote = (isCitizen) && (age >= 18);
            Console.WriteLine(fullName);
            Console.WriteLine(totalHeightCM);
            Console.WriteLine(canVote);









            Console.ReadLine();



        }

    }

}