/*C# Stack<T> example
Let's see an example of generic Stack<T> class that stores elements using Push() method, removes elements using Pop() method and iterates elements using for-each loop.
*/

using System;  
using System.Collections.Generic;  
  
public class StackExample  
{  
    public static void Main(string[] args)  
    {  
        Stack<string> names = new Stack<string>();  
        names.Push("Sonoo");  
        names.Push("Peter");  
        names.Push("James");  
        names.Push("Ratan");  
        names.Push("Irfan");  
  
        foreach (string name in names)  
        {  
            Console.WriteLine(name);  
        }  
  
        Console.WriteLine("Peek element: "+names.Peek());  
        Console.WriteLine("Pop: "+ names.Pop());  
        Console.WriteLine("After Pop, Peek element: " + names.Peek());  
  
    }  
}  
/*Output:

Sonoo
Peter
James
Ratan
Irfan
Peek element: Irfan
Pop: Irfan
After Pop, Peek element: Ratan
*/