//C# Reflection Example: Get Assembly
using System;  
using System.Reflection;  
public class ReflectionExample  
{  
   public static void Main()  
    {  
        Type t = typeof(System.String);  
        Console.WriteLine(t.Assembly);   
   }  
}  
/*Output:

mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
*/