using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string inputFilePath = @"input.txt"; 
            string outputFilePath = @"output.txt"; 
            string fileContents = File.ReadAllText(inputFilePath);

            
            fileContents = RemoveInsignificantSpaces(fileContents);

            
            File.WriteAllText(outputFilePath, fileContents);

            Console.WriteLine("Result text has been written to file: " + outputFilePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static string RemoveInsignificantSpaces(string text)
    {
        // Remove leading/trailing whitespace
        text = text.Trim();

        // Remove multiple spaces between words
        while (text.Contains("  "))
        {
            text = text.Replace("  ", " ");
        }

        // Remove spaces before punctuation marks
        text = text.Replace(" ,", ",");
        text = text.Replace(" .", ".");
        text = text.Replace(" !", "!");
        text = text.Replace(" ?", "?");
        text = text.Replace(" :", ":");
        text = text.Replace(" ;", ";");

        return text;
    }
}
