

//C# StreamReader example to read one line
//Let's see the simple example of StreamReader class that reads a single line of data from the file.

using System;  
using System.IO;  
public class StreamReaderExample  
{  
    public static void Main(string[] args)  
    {  
        FileStream f = new FileStream("e:\\output.txt", FileMode.OpenOrCreate);  
        StreamReader s = new StreamReader(f);  
  
        string line=s.ReadLine();  
        Console.WriteLine(line);  
  
        s.Close();  
        f.Close();  
    }  
}