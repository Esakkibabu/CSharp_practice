/*C# HashSet<T> example
Let's see an example of generic HashSet<T> class that stores elements using Add() method and iterates elements using for-each loop.
*/
using System;  
using System.Collections.Generic;  
  
public class HashSetExample  
{  
    public static void Main(string[] args)  
    {  
        // Create a set of strings  
        var names = new HashSet<string>();  
        names.Add("Sonoo");  
        names.Add("Ankit");  
        names.Add("Peter");  
        names.Add("Irfan");  
        names.Add("Ankit");//will not be added  
          
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
Irfan
*/