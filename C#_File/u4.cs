

//C# StreamWriter example
//Let's see a simple example of StreamWriter class which writes a single line of data into the file.

using System;  
using System.IO;  
public class StreamWriterExample  
{  
    public static void Main(string[] args)  
    {  
        FileStream f = new FileStream("e:\\output.txt", FileMode.Create);  
        StreamWriter s = new StreamWriter(f);  
  
        s.WriteLine("hello c#");  
        s.Close();  
        f.Close();  
     Console.WriteLine("File created successfully...");  
    }  
}  
