//C# Switch
using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int day = 2;
      switch (day) 
      {
        case 1:
          Console.WriteLine("Monday");
          break;
        case 2:
          Console.WriteLine("Tuesday");
          break;
        case 3:
          Console.WriteLine("Wednesday");
          break;
        case 4:
          Console.WriteLine("Thursday");
          break;
        case 5:
          Console.WriteLine("Friday");
          break;
        case 6:
          Console.WriteLine("Saturday");
          break;
        case 7:
          Console.WriteLine("Sunday");
          break;
      }  
	// Default
	int day1 = 8;
      switch (day1) 
      {
        case 6:
          Console.WriteLine("Today is Saturday.");
          break;
        case 7:
          Console.WriteLine("Today is Sunday.");
          break;
        default:
          Console.WriteLine("Wrong Selection");
          break;
      }  
    }
  }
}

/*
OUTPUT:
Tuesday
Wrong Selection
*/