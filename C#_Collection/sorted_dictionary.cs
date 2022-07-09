/*C# SortedDictionary<TKey, TValue> example
Let's see an example of generic SortedDictionary<TKey, TValue> class that stores elements using Add() method and iterates elements using for-each loop. Here, we are using KeyValuePair class to get key and value.
*/
using System;  
using System.Collections.Generic;  
  
public class SortedDictionaryExample  
{  
    public static void Main(string[] args)  
    {  
        SortedDictionary<string, string> names = new SortedDictionary<string, string>();  
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