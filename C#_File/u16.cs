//C# FileInfo Example: Reading text from the file
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
                // Specifying file to read  
                string loc = "F:\\abc.txt";  
                // Creating FileInfo instance  
                FileInfo file = new FileInfo(loc);  
                // Opening file to read  
                StreamReader sr = file.OpenText();  
                string data = "";  
                while ((data = sr.ReadLine()) != null)  
                {  
                     Console.WriteLine(data);  
                }  
            }  
            catch (IOException e)  
            {  
                Console.WriteLine("Something went wrong: " + e);  
            }  
        }  
    }  
}  