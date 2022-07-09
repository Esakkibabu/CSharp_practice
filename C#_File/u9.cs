
//C# TextReader Example: Read One Line
//Let's see the simple example of TextReader class that reads single line from the file.


using System;  
using System.IO;  
namespace TextReaderExample  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            using (TextReader tr = File.OpenText("e:\\f.txt"))  
            {  
                Console.WriteLine(tr.ReadLine());  
            }  
        }  
    }  
}  