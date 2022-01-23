// C# while Loop
using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
	// while loop
      int i = 0;
      Console.WriteLine("While Loop");
      while (i < 5) 
      {
        Console.WriteLine(i);
        i++;
      }
	  // Do while 
	  Console.WriteLine("Do While loop");
	  int i1 = 0;
      do 
      {
        Console.WriteLine(i1);
        i1++;
      }
      while (i1 < 5);
    }
  }
}
/*OUTPUT
While Loop
0
1
2
3
4
Do While loop
0
1
2
3
4
*/
