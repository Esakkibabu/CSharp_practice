// C# for loop
using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
	  Console.WriteLine("OUTPUT:");
	  // for loop
	  Console.WriteLine("For Loop");
      for (int i = 0; i < 5; i++) 
      {
        Console.WriteLine(i);
      }  
	  for (int i1 = 10; i1 <= 20; i1 = i1 + 2)
      {
        Console.WriteLine(i1);
      } 
	  // foreach 
	  Console.WriteLine("foreach");
	  string[] Days = {"mon", "tue", "wed", "thu","fri","sat","sun"};
      foreach (string i2 in Days) 
      {
        Console.WriteLine(i2);
      }  
	  //break
	  Console.WriteLine("Break");
	  for (int i3 = 5; i3 < 15; i3++) 
      {
        if (i3 == 11) 
        {
          break;
        }
        Console.WriteLine(i3);
      }   
      Console.WriteLine("Continue");
	  // continue
	  for (int i4 = 0; i4 < 8; i4++) 
      {
        if (i4 == 4) 
        {
          continue;
        }
        Console.WriteLine(i4);
      }   
      Console.WriteLine("Break and Continue");
	  // break and continue
	  int i6 = 20;
      while (i6 < 30) 
      {
        Console.WriteLine(i6);
        i6++;
        if (i6 == 25) 
        {
          break;
        }
      }
	  // continue
	  Console.WriteLine("Continue");
	  int i7 = 0;
      while (i7 < 20) 
      {
        if (i7 == 15) 
        {
          i7++;
          continue;
        }
        Console.WriteLine(i7);
        i7++;
      } 
    }
  }
}
/*
OUTPUT:
For Loop
0
1
2
3
4
10
12
14
16
18
20
foreach
mon
tue
wed
thu
fri
sat
sun
Break
5
6
7
8
9
10
Continue
0
1
2
3
5
6
7
Break and Continue
20
21
22
23
24
Continue
0
1
2
3
4
5
6
7
8
9
10
11
12
13
14
16
17
18
19
*/