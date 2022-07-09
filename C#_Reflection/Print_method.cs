//C# Reflection Example: Print Methods
using System;  
using System.Reflection;  
public class ReflectionExample  
{  
    public static void Main()  
    {  
        Type t = typeof(System.String);  
          
        Console.WriteLine("Methods of {0} type...", t);  
        MethodInfo[] ci = t.GetMethods(BindingFlags.Public | BindingFlags.Instance);  
        foreach (MethodInfo m in ci)  
        {  
            Console.WriteLine(m);  
        }  
    }  
}  
/*Output:

Methods of System.String type...
Boolean Equals(System.Object)
Boolean Equals(System.String)
Boolean Equals(System.String, System.StringComparison)
Char get_Chars(Int32)
Void copyTo(Int32, char[], Int32, Int32)
Char[] ToCharArray()
....
*/