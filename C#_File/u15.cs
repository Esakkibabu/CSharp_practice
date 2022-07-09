//C# FileInfo Example: writing to the file
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
                // Creating an file instance to write  
                StreamWriter sw = file.CreateText();  
                // Writing to the file  
                sw.WriteLine("This text is written to the file by using StreamWriter class.");  
                sw.Close();  
            }catch(IOException e)  
            {  
                Console.WriteLine("Something went wrong: "+e);  
            }  
        }  
    }  
}  