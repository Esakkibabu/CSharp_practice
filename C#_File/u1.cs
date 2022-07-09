
//C# FileStream example: writing single byte into file
//Let's see the simple example of FileStream class to write single byte of data into file. Here, we are using OpenOrCreate file mode which can be used for read and write operations.

using System;  
using System.IO;  
public class FileStreamExample  
{  
    public static void Main(string[] args)  
    {  
        FileStream f = new FileStream("e:\\b.txt", FileMode.OpenOrCreate);//creating file stream  
        f.WriteByte(65);//writing byte into stream  
        f.Close();//closing stream  
    }  
}  