/*
C# HashSet<T> example 2
Let's see another example of generic HashSet<T> class that stores elements using Collection initializer.

*/
using System;  
using System.Collections.Generic;  
  
public class HashSetExample  
{  
    public static void Main(string[] args)  
    {  
        // Create a set of strings  
        var names = new HashSet<string>(){"Sonoo", "Ankit", "Peter", "Irfan"};  
          
        // Iterate HashSet elements using foreach loop  
        foreach (var name in names)  
        {  
            Console.WriteLine(name);  
        }  
    }  
}  
/*Output:

Sonoo
Ankit
Peter
Irfan*/