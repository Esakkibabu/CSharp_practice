//C# DirectoryInfo Example
// In the following example, we are creating a javatpoint directory by specifying the directory path.

using System;  
using System.IO;  
namespace CSharpProgram  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            // Provide directory name with complete location.  
            DirectoryInfo directory = new DirectoryInfo(@"F:\javatpoint");  
            try  
            {  
                // Check, directory exist or not.  
                if (directory.Exists)  
                {  
                    Console.WriteLine("Directory already exist.");  
                    return;  
                }  
                // Creating a new directory.  
                directory.Create();  
                Console.WriteLine("The directory is created successfully.");  
            }  
            catch (Exception e)  
            {  
                Console.WriteLine("Directory not created: {0}", e.ToString());  
            }  
        }  
    }  
}  