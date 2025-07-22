// Write a console program that takes a meter serial number as input and prints it.

using System;
 
 
 
class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the meter serial number
        Console.Write("Enter the meter serial number: ");
 
        // Read user input from the console
        string meterSerialNumber = Console.ReadLine();
 
        // Display the entered serial number
        Console.WriteLine("Meter Serial Number: " + meterSerialNumber);
 
 
 
    }
}
