using System;


//Write a program that simulates the rolling of two 6-sided dice. Use an Array to keep track of the
//number of times that each total number is thrown. In other words, keep track of how many times
//the combination of the two simulated dice is 2, how many times the combination is 3, and so on,
//all the way up through 12.
//Allow the user to choose how many times the “dice” will be thrown. Then, once the dice have
//been thrown the specified number of times, print a histogram (using the* character) that shows
//the total percentage each number was rolled. Each * will represent 1% of the total rolls.

namespace Mission_2
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //creating array and random seed
            Random dice = new Random();
            int[] diceTotal = new int[11];


            //welcome message and input of roll count
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How mant dice rolls would you like to simulate? ");
            string Rolls = Console.ReadLine();
            int numRolls = Convert.ToInt32(Rolls);


            //roll the dice and save the value 
            for (int i = 0; i < numRolls; i++)
            {
                int roll1 = dice.Next(1, 7);
                int roll2 = dice.Next(1, 7);
                int sum = roll1 + roll2;

                diceTotal[sum - 2] += 1;
            }

            //print message
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represnts 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls);


            //convert to percent and add stars to string and then print for every num in array
            for (int i = 0; i < diceTotal.Length; i++)
            {
                int percent = (diceTotal[i] / numRolls) * 100;
                string stars = "";

                for (int j = 0; j < percent; j++)
                {
                    stars += "*";
                }

                Console.WriteLine((i + 2) + ": " + stars);
            }

            //end message
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
            
    }
}
