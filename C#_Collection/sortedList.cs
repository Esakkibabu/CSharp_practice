/*C# SortedList<TKey, TValue> vs SortedDictionary<TKey, TValue>
SortedList<TKey, TValue> class uses less memory than SortedDictionary<TKey, TValue>.
It is recommended to use SortedList<TKey, TValue> if you have to store and retrieve key/valye pairs. 
The SortedDictionary<TKey, TValue> class is faster than SortedList<TKey, TValue> class if you perform insertion and removal for unsorted data.

C# SortedList<TKey, TValue> example
Let's see an example of generic SortedList<TKey, TValue> class that stores elements using Add() method and iterates elements using for-each loop. 
Here, we are using KeyValuePair class to get key and value.
*/

using System;  
using System.Collections.Generic;  
  
public class SortedDictionaryExample  
{  
    public static void Main(string[] args)  
    {  
        SortedList<string, string> names = new SortedList<string, string>();  
        names.Add("1","Sonoo");    
        names.Add("4","Peter");    
        names.Add("5","James");    
        names.Add("3","Ratan");    
        names.Add("2","Irfan");    
        foreach (KeyValuePair<string, string> kv in names)  
        {  
            Console.WriteLine(kv.Key+" "+kv.Value);  
        }  
    }  
}  
/*Output:

1 Sonoo
2 Irfan
3 Ratan
4 Peter
5 James
*/