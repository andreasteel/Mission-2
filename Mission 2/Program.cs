using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that simulates the rolling of two 6-sided dice. Use an Array to keep track of the
//number of times that each total number is thrown. In other words, keep track of how many times
//the combination of the two simulated dice is 2, how many times the combination is 3, and so on,
//all the way up through 12.
//Allow the user to choose how many times the “dice” will be thrown. Then, once the dice have
//been thrown the specified number of times, print a histogram (using the* character) that shows
//the total percentage each number was rolled. Each * will represent 1% of the total rolls.

namespace Mission_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //welcome message and grabbing roll count
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How mant dice rolls would you like to simulate? ");
            string Rolls = Console.ReadLine();
            int numRolls = Convert.ToInt32(Rolls);

            //creating the arrays for the rolls
           
            int[] rollTotal = new int[11];
            Random r = new Random();

            //looping through rolls and getting random #s in array
            for (int i = 0; i < numRolls; i++)
            {
                int rollResult = 0;
                //roll the dice
                rollResult = r.Next(1, 7);
                rollResult += r.Next(1, 7);

                //adding the rolls together
                rollTotal[rollResult] += 1;
            }


             //print message
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represnts 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls);

            for (int i = 0; i < rollTotal.Length; i++)
            {
                float starsCount = (rollTotal[i] / (float)numRolls) * 100;
                string stars = "";

                for (int j = 0; i < starsCount; j++)
                {
                    stars += "*";
                }

                Console.WriteLine((i + 1) + ": " + stars);
            }




            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
            
        }
    }
}
