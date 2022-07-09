
// C# string writer

using System;  
using System.IO;  
using System.Text;  
namespace CSharpProgram  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            string text = "Hello, Welcome to the javatpoint \n" +  
                "It is nice site. \n" +  
                "It provides technical tutorials";  
            // Creating StringBuilder instance  
            StringBuilder sb = new StringBuilder();  
            // Passing StringBuilder instance into StringWriter  
            StringWriter writer = new StringWriter(sb);  
            // Writing data using StringWriter  
            writer.WriteLine(text);  
            writer.Flush();  
            // Closing writer connection  
            writer.Close();  
            // Creating StringReader instance and passing StringBuilder  
            StringReader reader = new StringReader(sb.ToString());  
            // Reading data  
            while (reader.Peek() > -1)  
            {  
                Console.WriteLine(reader.ReadLine());  
            }  
        }  
    }  
}  