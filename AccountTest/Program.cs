using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();
            Console.WriteLine(" this is what you got" + myAccount.GetName());
            Console.WriteLine("Enter the name");
            string theName = Console.ReadLine();
            myAccount.SetName(theName);
            Console.WriteLine("my aacount name is" + myAccount.GetName());



        }
    }
}
