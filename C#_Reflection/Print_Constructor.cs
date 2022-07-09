//C# Reflection Example: Print Constructors
using System;  
using System.Reflection;  
public class ReflectionExample  
{  
    public static void Main()  
    {  
        Type t = typeof(System.String);  
          
        Console.WriteLine("Constructors of {0} type...", t);  
        ConstructorInfo[] ci = t.GetConstructors(BindingFlags.Public | BindingFlags.Instance);  
        foreach (ConstructorInfo c in ci)  
        {  
            Console.WriteLine(c);  
        }  
    }  
}  
/*Output:

Constructors of System.String type...
Void .ctor(Char*)
Void .ctor(Char*, Int32, Int32)
Void .ctor(SByte*)
Void .ctor(SByte*, Int32, Int32)
Void .ctor(SByte*, Int32, Int32, System.Text.Encoding)
Void .ctor(Char[], Int32, Int32)
Void .ctor(Char[])
Void .ctor(Char, Int32)
*/