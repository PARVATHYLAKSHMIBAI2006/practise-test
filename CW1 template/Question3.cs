using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_template
{
    public class Question3
    {
        public static void question3()
        {
            // Question 3:
            Console.WriteLine("\n-------Question 3-------");
            int number;
            int Total = 0;

            while (true)
            {
                Console.WriteLine("Enter an integer (enter 0 to exit):");
                number = Convert.ToInt32(Console.ReadLine());

                // Check if the user entered 0
                if (number == 0)
                {
                    break;  // Exit the loop
                }

                // Add number to the total
                Total += number;

                Console.WriteLine("The total so far is: " + Total);
            }

            Console.WriteLine("Final total: " + Total);
            Console.WriteLine("Exiting the loop...");// Enter code and comments here...

           
        }
    }
}
