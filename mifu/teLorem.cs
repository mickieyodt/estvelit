using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Replace 'dirPath' with the actual directory path
        string dirPath = @"your_directory_path_here";

        try
        {
            // Get all files in the directory, excluding hidden files
            string[] files = Directory.EnumerateFiles(dirPath)
                                      .Where(file => (new FileInfo(file).Attributes & FileAttributes.Hidden) == 0)
                                      .ToArray();

            // Process the files as needed
            foreach (var file in files)
            {
                Console.WriteLine(file);
                // Add your file processing logic here
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions (e.g., directory not found, no permission)
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
