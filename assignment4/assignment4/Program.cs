using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            string matinee, showtimeM, evening, showtimeE, showtime;
            double
                Noofadults = 0, adultprice = 0,
                Noofchildren = 0, childprice = 0,
                Noofseniors = 0, seniorprice = 0,
                totalticketprice = 0, totalNooftickets = 0, ticketdiscount = 0,
                Noofsmallsodas = 0, smallsodaprice = 0,
                Nooflargesodas = 0, largesodaprice = 0,
                Noofhotdogs = 0, hotdogprice = 0,
                Noofpopcorn = 0, popcornprice = 0, additionalpopcorn = 0,
                Noofcandy = 0, candyprice = 0, extracandy = 0,
                totalconcessionitemsprice = 0, totalprice=0, discount=0;

            Console.WriteLine(" what showtime you are going matinee/evening?");
            showtime = Console.ReadLine();
            Console.WriteLine("how many children going with you?");
            Noofchildren = Double.Parse(Console.ReadLine());
            Console.WriteLine(" how many adults are going?");
            Noofadults = Double.Parse(Console.ReadLine());
            Console.WriteLine(" how many seniors are going ?");
            Noofseniors = Double.Parse(Console.ReadLine());
            Console.WriteLine(" how many small sodas you buy?");
            Noofsmallsodas = Double.Parse(Console.ReadLine());
            Console.WriteLine(" how many large sodas you buy?");
            Nooflargesodas = Double.Parse(Console.ReadLine());
            Console.WriteLine("how many popcorns you buy?");
            Noofpopcorn = Double.Parse(Console.ReadLine());
            Console.WriteLine("how many hotdogs you buy?");
            Noofhotdogs = Double.Parse(Console.ReadLine());
            Console.WriteLine("how many candy you buy?");
            Noofcandy = Double.Parse(Console.ReadLine());

            if (showtime == "matinee")
            {
                childprice = Noofchildren * 3.99;
                adultprice = Noofadults * 5.99;
                seniorprice = Noofseniors * 4.50;
                totalNooftickets = Noofchildren + Noofadults + Noofseniors;
                totalticketprice = childprice + adultprice + seniorprice;
                smallsodaprice = Noofsmallsodas * 3.50;
                largesodaprice = Nooflargesodas * 5.99;
                hotdogprice = Noofhotdogs * 3.99;
                popcornprice = Noofpopcorn * 4.50;
                candyprice = Noofcandy * 1.99;
                extracandy = Noofcandy / 3;
                
                if (Noofpopcorn > 0 && Nooflargesodas > 0)
                    ticketdiscount = ticketdiscount - 2;
                if (Noofcandy >= 3)
                    extracandy = Noofcandy / 3;

                totalconcessionitemsprice = smallsodaprice + largesodaprice + hotdogprice + 
                    popcornprice + candyprice;

            }
            else //showtime == "evening"
            { 
                childprice = Noofchildren * 6.99;
                adultprice = Noofadults * 10.99;
                seniorprice = Noofseniors * 8.50;
                totalNooftickets = Noofchildren + Noofadults + Noofseniors;
                totalticketprice = childprice + adultprice + seniorprice;
                smallsodaprice = Noofsmallsodas * 3.50;
                largesodaprice = Nooflargesodas * 5.99;
                hotdogprice = Noofhotdogs * 3.99;
                popcornprice = Noofpopcorn * 4.50;
                candyprice = Noofcandy * 1.99;
                extracandy = Noofcandy / 3;

                if( totalNooftickets >= 3)
                {
                    additionalpopcorn = additionalpopcorn + 1;
                }
                 
                if (Noofpopcorn > 0 && Nooflargesodas > 0)
                    ticketdiscount = ticketdiscount - 2;
                if (Noofcandy >= 3)
                    extracandy = Noofcandy / 3;

                totalconcessionitemsprice = smallsodaprice + largesodaprice + hotdogprice +
                    popcornprice + candyprice;
            }

            Console.WriteLine("toatal number of tickets:  " + totalNooftickets + " priced: " + totalticketprice);
            Console.WriteLine("total ticket Discount: "  +  ticketdiscount );
            Console.WriteLine("Final ticket price: " + (totalticketprice + ticketdiscount));
            Console.WriteLine("Number of children: " + Noofchildren + " priced: " + childprice);
            Console.WriteLine("Number of adults: " + Noofadults + " priced: " + adultprice);
            Console.WriteLine("Number of seniors: " + Noofseniors + " priced: " + seniorprice);
            Console.WriteLine("number of small soda:" + Noofsmallsodas + "priced: " + smallsodaprice);
            Console.WriteLine("number of large soda:" + Nooflargesodas + "priced:" + largesodaprice);
            Console.WriteLine("number of hotdog:" + Noofhotdogs + "priced:" + hotdogprice);
            Console.WriteLine("number of popcorn:" + Noofpopcorn + "priced:" + popcornprice);
            Console.WriteLine("number of candy:" + Noofcandy + "priced:" + candyprice);

            Console.ReadLine();
            
        }
    }
}
