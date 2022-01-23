// C# If...Else
using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("OUTPUT:");
    // if 
      if (40 > 20) 
      {
        Console.WriteLine("40 is greater than 20");
      }   
    // if....else
	  int x = 10;
      if (x < 5) 
      {
        Console.WriteLine("Welcome");
      } 
      else 
      {
        Console.WriteLine("Thank you.");
      }
    //else if
	  int x2 = 20;
      if (x2 < 10) 
      {
        Console.WriteLine("X2 is less than 10");
      } 
      else if (x2 < 20) 
      {
        Console.WriteLine("x2 is less than 20");
      } 
      else 
      {
        Console.WriteLine("others");
      }
    //soft hand if..else (ternary Operators)	  
	  int x3 = 50;
      if (x3 < 20) 
      {
        Console.WriteLine("Condition 1");
      } 
      else 
      {
        Console.WriteLine("Condition 2");
      }
	  int x4 = 20;
      string Status = (x4 < 10) ? "Condition A" : "Condition B";
      Console.WriteLine(Status);
    }
  }
}
/* OUTPUT:
40 is greater than 20
Thank you.
others
Condition 2
Condition B
*/