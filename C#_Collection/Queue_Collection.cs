/*C# Queue<T> example
Let's see an example of generic Queue<T> class that stores elements using Enqueue() method, removes elements using Dequeue() method and iterates elements using for-each loop.
*/

using System;  
using System.Collections.Generic;  
  
public class QueueExample  
{  
    public static void Main(string[] args)  
    {  
        Queue<string> names = new Queue<string>();  
        names.Enqueue("Sonoo");  
        names.Enqueue("Peter");  
        names.Enqueue("James");  
        names.Enqueue("Ratan");  
        names.Enqueue("Irfan");  
  
        foreach (string name in names)  
        {  
            Console.WriteLine(name);  
        }  
  
        Console.WriteLine("Peek element: "+names.Peek());  
        Console.WriteLine("Dequeue: "+ names.Dequeue());  
        Console.WriteLine("After Dequeue, Peek element: " + names.Peek());  
    }  
}  
/*Output:

Sonoo
Peter
James
Ratan
Irfan
Peek element: Sonoo
Dequeue: Sonoo
After Dequeue, Peek element: Peter*/