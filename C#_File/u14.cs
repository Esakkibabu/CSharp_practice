//C# FileInfo Example: Creating a File
using System;  
using System.IO;  
namespace CSharpProgram  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            try  
            {  
                // Specifying file location  
                string loc = "F:\\abc.txt";  
                // Creating FileInfo instance  
                FileInfo file = new FileInfo(loc);  
                // Creating an empty file  
                file.Create();  
                Console.WriteLine("File is created Successfuly");  
            }catch(IOException e)  
            {  
                Console.WriteLine("Something went wrong: "+e);  
            }  
        }  
    }  
}  

