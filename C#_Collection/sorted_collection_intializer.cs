/*
C# SortedSet<T> example 2
Let's see another example of generic SortedSet<T> class that stores elements using Collection initializer.
*/

using System;  
using System.Collections.Generic;  
  
public class SortedSetExample  
{  
    public static void Main(string[] args)  
    {  
        // Create a set of strings  
        var names = new SortedSet<string>(){"Sonoo", "Ankit", "Peter", "Irfan"};  
          
        // Iterate SortedSet elements using foreach loop  
        foreach (var name in names)  
        {  
            Console.WriteLine(name);  
        }  
    }  
}  
/*Output:

Ankit
Irfan
Peter
Sonoo*/