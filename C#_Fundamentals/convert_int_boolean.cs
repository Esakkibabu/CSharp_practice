//Convert Int to Boolean
using System;
namespace Conversion 
{
  class Program 
  {
    static void Main(string[] args) 
	{
      // create int variables
      int num1 = 0;
      int num2 = 1;
	  Console.WriteLine("OUTPUT:");
      // convert int to Boolean
      Boolean bool1 = Convert.ToBoolean(num1);
      Boolean bool2 = Convert.ToBoolean(num2);
      Console.WriteLine("Boolean value of 0 is: " + bool1);
    }
  }
}
/*
OUTPUT:
Boolean value of 0 is: False
*/
