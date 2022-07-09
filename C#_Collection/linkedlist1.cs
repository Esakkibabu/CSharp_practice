/*C# LinkedList<T> example
Let's see an example of generic LinkedList<T> class that stores elements using AddLast() and AddFirst() methods and iterates elements using for-each loop.
*/

using System;  
using System.Collections.Generic;  
  
public class LinkedListExample  
{  
    public static void Main(string[] args)  
    {  
        // Create a list of strings  
        var names = new LinkedList<string>();  
        names.AddLast("Sonoo Jaiswal");  
        names.AddLast("Ankit");  
        names.AddLast("Peter");  
        names.AddLast("Irfan");  
        names.AddFirst("John");//added to first index  
  
        // Iterate list element using foreach loop  
        foreach (var name in names)  
        {  
            Console.WriteLine(name);  
        }  
    }  
}  
/*Output:
John
Sonoo Jaiswal
Ankit
Peter
Irfan
*/