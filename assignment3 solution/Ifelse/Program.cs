using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            string score = Console.ReadLine();
            int number = int.Parse(score);
            if (number > 80)
            {
                Console.WriteLine(" good student");
                //Console.ReadLine();
            }
            else if (number > 30)
            {
                Console.WriteLine("struggling");
                //Console.ReadLine();

            }

            else 
            {
                Console.WriteLine("fail");
                //Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
