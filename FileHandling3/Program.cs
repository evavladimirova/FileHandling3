using System.IO;
using System;

class Example
{
    public static void Main()
    {
        DirectoryInfo currDir = new DirectoryInfo(@"C:\Users\sport\Documents\ACS\Others\File_Handling");

        currDir.Create();

        string path = @"C:\Users\sport\Documents\ACS\Others\File_Handling\append.txt";

       
        try
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            using (StreamWriter writer = File.AppendText(path))
            {
                Console.WriteLine("Enter text to append to the file:");
                string input = Console.ReadLine();
                writer.WriteLine(input);
            }

            Console.WriteLine("Text appended to the file: " + path);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

    }


}
