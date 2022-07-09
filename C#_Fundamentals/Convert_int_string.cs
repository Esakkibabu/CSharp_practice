//Convert Int to string and double
using System;
using System;
namespace Conversion 
{
  class Program 
  {
    static void Main(string[] args) 
	{
      // create int variable
      int num = 100;
      Console.WriteLine("OUTPUT:");
      Console.WriteLine("int value: " + num);
      // convert int to string
      string str = Convert.ToString(num);
      Console.WriteLine("string value: " + str);
      // convert int to Double
      Double doubleNum = Convert.ToDouble(num);
      Console.WriteLine("Double value: " + doubleNum);
    }
  }
}
/*
OUTPUT:
int value: 100
string value: 100
Double value: 100
*/