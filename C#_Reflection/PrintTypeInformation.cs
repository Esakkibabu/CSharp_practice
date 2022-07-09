//C# Reflection Example: Print Type Information
using System;  
using System.Reflection;  
public class ReflectionExample  
{  
    public static void Main()  
    {  
        Type t = typeof(System.String);  
        Console.WriteLine(t.FullName);  
        Console.WriteLine(t.BaseType);  
        Console.WriteLine(t.IsClass);  
        Console.WriteLine(t.IsEnum);  
        Console.WriteLine(t.IsInterface);  
    }  
}  
/*Output:

System.String
System.Object
true
false
false
*/