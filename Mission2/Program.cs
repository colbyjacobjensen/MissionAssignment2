// Colby Jensen
// Section 4 - Group 6
// Dice Roll Simulator
// 1/18/2023

using System;

namespace Mission2
{
    class Program
    {
        static void Main (string[] args)
        {
            Random r = new Random(); // Random number
            int[] rollResults = new int[13]; // Starting with a blank array

            // Intro and user prompt for times to be rolled
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.WriteLine("How many dice rolls would you like to simulate?");
            int rollCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \" * \" represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rollCount + ".\n");

            // Simulate roll of 2 dice for rollCount times and summing total
            for (int i = 0; i < rollCount; i++)
            {
                int dice1 = r.Next(1, 7);
                int dice2 = r.Next(1, 7);
                int total = dice1 + dice2;
                rollResults[total]++;
            }

            // Print results
            for (int i = 2; i <= 12; i++)
            {
                Console.Write(i + ": "); // Print result of dice roll combination

                // Math to get percent
                int roll = rollResults[i] * 100;
                int percentage = (roll / rollCount);

                // For loop to print * for every 1%
                for (int count = 0; count < percentage; count++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!"); // Outro

        } // End Main
    }
}