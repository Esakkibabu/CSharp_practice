/*
Note: Unlike List, you cannot create LinkedList using Collection initializer.
C# LinkedList<T> example 2
Let's see another example of generic LinkedList<T> class that stores elements before and after specific node.
 To get the specific node, we are calling Find() method.
*/

using System;  
using System.Collections.Generic;  
  
public class LinkedListExample  
{  
    public static void Main(string[] args)  
    {  
        // Create a list of strings  
        var names = new LinkedList<string>();  
        names.AddLast("Sonoo");  
        names.AddLast("Ankit");  
        names.AddLast("Peter");  
        names.AddLast("Irfan");  
          
        //insert new element before "Peter"  
        LinkedListNode<String> node=names.Find("Peter");  
        names.AddBefore(node, "John");  
        names.AddAfter(node, "Lucy");  
  
        // Iterate list element using foreach loop  
        foreach (var name in names)  
        {  
            Console.WriteLine(name);  
        }  
    }  
}  
/*Output:

Sonoo
Ankit
John
Peter
Lucy
Irfan
*/