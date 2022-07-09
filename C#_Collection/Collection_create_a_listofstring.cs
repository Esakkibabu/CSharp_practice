/* C# List<T>
C# List<T> class is used to store and fetch elements. It can have duplicate elements. It is found in System.Collections.Generic namespace.

C# List<T> example
Let's see an example of generic List<T> class that stores elements using Add() method and iterates the list using for-each loop.
*/

using System;  
using System.Collections.Generic;  
  
public class ListExample  
{  
    public static void Main(string[] args)  
    {  
        // Create a list of strings  
        var names = new List<string>();  
        names.Add("Sonoo Jaiswal");  
        names.Add("Ankit");  
        names.Add("Peter");  
        names.Add("Irfan");  
  
        // Iterate list element using foreach loop  
        foreach (var name in names)  
        {  
            Console.WriteLine(name);  
        }  
    }  
}  
/*Output:

Sonoo Jaiswal
Ankit
Peter

*/