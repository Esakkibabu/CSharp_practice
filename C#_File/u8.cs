

//C# TextReader Example: Read All Data
//Let's see the simple example of TextReader class that reads data till the end of file.

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
                Console.WriteLine(tr.ReadToEnd());  
            }  
        }  
    }  
}  