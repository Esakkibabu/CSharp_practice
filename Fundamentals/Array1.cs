//C# Array
using System;
using System.Linq;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
// acess the elements of an array
      string[] Days = {"Sun","Mon", "Tue", "Wed", "Thu","Fri","Sat"};
      Console.WriteLine(Days[4]);  
//Change an array element
	  string[] Days1 = {"Sun","Mon", "Tue", "Wed", "Thu","Fri","Sat"};
      Days1[0] = "Mon";
      Console.WriteLine(Days1[0]); 
// Array Length
	 string[] Days2 = {"Sun","Mon", "Tue", "Wed", "Thu","Fri","Sat"};
      Console.WriteLine(Days2.Length);      
// Loop Through an Array
		string[] Days3 = {"Sun","Mon", "Tue", "Wed", "Thu","Fri","Sat"};
      for (int i = 0; i < Days3.Length; i++) 
      {
        Console.WriteLine(Days3[i]);
      }
// foreach loop
		string[] Days4 = {"Sun","Mon", "Tue", "Wed", "Thu","Fri","Sat"};
      foreach (string i1 in Days4) 
      {
        Console.WriteLine(i1);
      }  
//Sorts Array
	   // Sort a string
      string[] Days5 = {"Sun","Mon", "Tue", "Wed", "Thu","Fri","Sat"};
      Array.Sort(Days5);
      foreach (string i2 in Days5)
      {
        Console.WriteLine(i2);
      }    
      // Sort an int
      int[] myNumbers = {5, 1, 8, 9};
      Array.Sort(myNumbers);
      foreach (int i in myNumbers)
      {
        Console.WriteLine(i);
      }
//System.Linq Namespace
   //Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:  
	  int[] myNumbers1 = {5, 1, 8, 9};
      Console.WriteLine(myNumbers1.Max());  // largest value
      Console.WriteLine(myNumbers1.Min());  // smallest value
      Console.WriteLine(myNumbers1.Sum());  // sum of myNumbers
    }
  }
}

/*OUTPUT:
Thu
Mon
7
Sun
Mon
Tue
Wed
Thu
Fri
Sat
Sun
Mon
Tue
Wed
Thu
Fri
Sat
Fri
Mon
Sat
Sun
Thu
Tue
Wed
1
5
8
9
9
1
23


*/