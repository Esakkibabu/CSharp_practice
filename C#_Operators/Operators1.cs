// C# Operators
using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int sum1 = 100 + 50;     // 150 (100 + 50)
      int sum2 = sum1 + 250;   // 400 (150 + 250)
      int sum3 = sum2 + sum2;  // 800 (400 + 400)
	  Console.WriteLine("OUTPUT:");
      Console.WriteLine(sum1);
      Console.WriteLine(sum2);
      Console.WriteLine(sum3);
	  // Assignment Operators
	  int x = 10;
      Console.WriteLine(x); 
	  // Addition assignment Operators
	  int x3 = 10;
      x3 += 5;
      Console.WriteLine(x3);  
	  // Comparision Operators
	  int x1 = 5;
      int y1 = 3;
      Console.WriteLine(x1 == y1);  // returns False because 5 is not equal to 3
	  // Logical Operators
	  int x2 = 5;
      Console.WriteLine(x2 > 3 && x2 < 10); // returns True because 5 is greater than 3 AND 5 is less than 10
     }
  }
}
/*
OUTPUT:
150
400
800
10
15
False
True
*/