//Create a program that checks if a meter's reading is within a valid range (100–200).

using System;
 
namespace ConsoleApp

{

    internal class MeterCheckProgram

    {

        static void Main(string[] args)

        {

            // Sample list of meter readings

            int[] meterReadings = { 95, 105, 150, 210, 180 };
 
            Console.WriteLine("Checking multiple meter readings:");

            Console.WriteLine();
 
            // foreach loop to process each reading

            foreach (int reading in meterReadings)

            {

                Console.WriteLine($"Reading: {reading}");
 
                // Comparison and logical operators

                if (reading >= 100 && reading <= 200)

                {

                    Console.WriteLine("Status: VALID");

                }

                else

                {

                    Console.WriteLine("Status: INVALID");

                }
 
                // Arithmetic operator example

                int nextCheck = reading + 10;

                Console.WriteLine($"Suggested next reading check: {nextCheck}");
 
                // Switch example based on reading category

                string level;

                switch (reading)

                {

                    case < 100:

                        level = "Low";

                        break;

                    case <= 150:

                        level = "Moderate";

                        break;

                    case <= 200:

                        level = "High";

                        break;

                    default:

                        level = "Critical";

                        break;

                }
 
                Console.WriteLine($"Level: {level}");

                Console.WriteLine("--------------------------");

            }
 
            // while loop: ask user for input until valid

            string userInput;

            int userReading=0;

            bool isValidInput = false;
 
            while (!isValidInput)

            {

                Console.Write("Enter a meter reading between 100 and 200: ");

                userInput = Console.ReadLine();
 
                if (int.TryParse(userInput, out userReading))

                {

                    if (userReading >= 100 && userReading <= 200)

                    {

                        Console.WriteLine("✔ Your reading is valid.");

                        isValidInput = true;

                    }

                    else

                    {

                        Console.WriteLine("✘ Out of range. Try again.");

                    }

                }

                else

                {

                    Console.WriteLine("✘ Invalid input. Enter a number.");

                }

            }
 
            // for loop: simulate checking last 5 readings

            Console.WriteLine("\nSimulated last 5 readings with +5 intervals:");

            for (int i = 0; i < 5; i++)

            {

                int simulatedReading = userReading + (i * 5);

                Console.WriteLine($"Simulated Reading {i + 1}: {simulatedReading}");

            }

        }

    }

}

 
