

// C# TextWriter Example
//Let's see the simple example of TextWriter class to write two lines data.

using System;  
using System.IO;  
namespace TextWriterExample  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            using (TextWriter writer = File.CreateText("e:\\f.txt"))  
            {  
                writer.WriteLine("Hello C#");  
                writer.WriteLine("C# File Handling by JavaTpoint");  
            }  
            Console.WriteLine("Data written successfully...");  
        }  
    }  
}  