using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] grid;
            grid = new string[8,8];
            Console.WriteLine("values in the grid array by row are");

            for (int i = 0; i < 8; i++)
            {

                //grid[i] = new string[8];
                for (int j = 0; j < 8; j++)
                {
                    grid[i,j] = "  ";
                    if (i == 0 || i == 1 || i == 6 || i == 7)
                        grid[i,j] = " x ";
                }               
            }

            int tx=0, ty=0, dx=0, dy=0;
            printarray(grid);
               
           //Asking about target and destination cordinates
           
            while ( (tx >= 0 && tx <= 7) &&
                    (ty >= 0 && ty <= 7) &&
                    (dx >= 0 && dx <= 7) &&
                    (dy >= 0 && dy <= 7) 
                )
            {
                Console.Write("Enter Target X Coordinate Between 0 and 7 : ");
                tx = int.Parse(Console.ReadLine());
                Console.Write("Enter Target Y Coordinate Between 0 and 7 : ");
                ty = int.Parse(Console.ReadLine());
                Console.Write("Enter Destination X Coordinate Between 0 and 7 : ");
                dx = int.Parse(Console.ReadLine());
                Console.Write("Enter Destination Y Coordinate Between 0 and 7 : ");
                dy = int.Parse(Console.ReadLine());

                
                if ((tx >= 0 && tx <= 7) && (ty >= 0 && ty <= 7) && (dx >= 0 && dx <= 7) && (dy >= 0 && dy <= 7))
                {
                    grid[tx, ty] = "   ";
                    grid[dx, dy] = " x ";
                    printarray(grid);
                }
            }

                                                  
            Console.WriteLine("your typed a wrong value,goodbye");

            Console.ReadLine();


            void printarray(string [,] arraytoPrint)
            {
                Console.Clear();
                Console.Write(" ");
                for (int m =0; m < 8; m++)
                {
                    Console.Write("  " + m);
                }
                Console.WriteLine("");


                for (int i = 0; i < 8; i++)
                {
                    Console.Write(i + " ");
                    for (int j = 0; j < 8; j++)
                    {

                        Console.Write(arraytoPrint[i,j]);
                    }
                    Console.WriteLine("");
                }


            }
        }    


    }

}                    
    





