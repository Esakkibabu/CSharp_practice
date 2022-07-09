//C# DirectoryInfo Example: Deleting Directory
using System;  
using System.IO;  
namespace CSharpProgram  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            // Providing directory name with complete location.  
            DirectoryInfo directory = new DirectoryInfo(@"F:\javatpoint");  
            try  
            {  
                // Deleting directory  
                directory.Delete();  
                Console.WriteLine("The directory is deleted successfully.");  
            }  
            catch (Exception e)  
            {  
                Console.WriteLine("Something went wrong: {0}", e.ToString());  
            }  
        }  
    }  
}  