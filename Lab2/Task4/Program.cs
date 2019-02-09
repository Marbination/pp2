using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    // Simple synchronous file copy operations with no user interface.
    // To run this sample, first create the following directories and files:
    // C:\Users\Public\TestFolder
    // C:\Users\Public\TestFolder\test.txt
    // C:\Users\Public\TestFolder\SubDir\test.txt
    {
        static void Main()
        {
            string fileName = "3-test.txt";
            string sourcePath = @"C:\Users\ACER\Desktop\c#\Lab2\Test-1";
            string targetPath = @"C:\Users\ACER\Desktop\c#\Lab2\Test-2";

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);

            // Delete a file by using File class static method...
            if (System.IO.File.Exists(@"C:\Users\ACER\Desktop\c#\Lab2\Test-1\3-test.txt"))
            {
                // Use a try block to catch IOExceptions, to
                // handle the case of the file already being
                // opened by another process.
                try
                {
                    System.IO.File.Delete(@"C:\Users\ACER\Desktop\c#\Lab2\Test-1\3-test.txt");
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
        }
    }
}