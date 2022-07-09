//C# FileStream example: writing multiple bytes into file
//Let's see another example to write multiple bytes of data into file using loop.



using System;  
using System.IO;  
public class FileStreamExample  
{  
    public static void Main(string[] args)  
    {  
        FileStream f = new FileStream("e:\\b.txt", FileMode.OpenOrCreate);  
        for (int i = 65; i <= 90; i++)  
        {  
            f.WriteByte((byte)i);  
        }  
        f.Close();  
    }  
}  