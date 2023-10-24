using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"C:\Users\kshiv\OneDrive\Documents\StudentData.txt";


        // Check if the file exists
        if (File.Exists(filePath))
        {
            // Read the contents of the file
            string fileContents = File.ReadAllText(filePath);

            // Display the contents of the file on the console
            Console.WriteLine(fileContents);
        }
        else
        {
            Console.WriteLine("The file does not exist.");
        }

        // Wait for the user to press any key before exiting
        Console.ReadKey();
    }
}