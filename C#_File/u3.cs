// C# FileStream example: reading all bytes from file
//Let's see the example of FileStream class to read data from the file. Here, ReadByte() method of FileStream class returns single byte. To all read all the bytes, you need to use loop.

using System;  
using System.IO;  
public class FileStreamExample  
{  
    public static void Main(string[] args)  
    {  
        FileStream f = new FileStream("e:\\b.txt", FileMode.OpenOrCreate);  
        int i = 0;  
        while ((i = f.ReadByte()) != -1)  
        {  
            Console.Write((char)i);  
        }  
        f.Close();  
    }  
} 

