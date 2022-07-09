/*C# Dictionary<TKey, TValue> example
Let's see an example of generic Dictionary<TKey, TValue> class that stores elements using Add() method and iterates elements using for-each loop. Here, we are using KeyValuePair class to get key and value.
*/
using System;  
using System.Collections.Generic;  
  
public class DictionaryExample  
{  
    public static void Main(string[] args)  
    {  
        Dictionary<string, string> names = new Dictionary<string, string>();  
        names.Add("1","Sonoo");  
        names.Add("2","Peter");  
        names.Add("3","James");  
        names.Add("4","Ratan");  
        names.Add("5","Irfan");  
  
        foreach (KeyValuePair<string, string> kv in names)  
        {  
            Console.WriteLine(kv.Key+" "+kv.Value);  
        }  
    }  
}  
/*Output:

1 Sonoo
2 Peter
3 James
4 Ratan
5 Irfan
*/