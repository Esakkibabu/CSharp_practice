// C# Data Types

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myNum = 5;               // integer (whole number)
      double myDoubleNum = 5.99D;  // floating point number
      char myLetter = 'D';         // character
      bool myBool = true;          // boolean
      string myText = "Hello";     // string
	  
	  
      Console.WriteLine(myNum);
      Console.WriteLine(myDoubleNum);
      Console.WriteLine(myLetter);
      Console.WriteLine(myBool);
      Console.WriteLine(myText);
	  
	  // Strings
	  string greeting = "Hello World";
      Console.WriteLine(greeting);
	  
	  //Characters
	  
	  char myGrade = 'B';
      Console.WriteLine(myGrade);
	  
	  // Scientifc
	  
	  float f1 = 35e3F;
      double d1 = 12E4D;
      Console.WriteLine(f1);
      Console.WriteLine(d1);
	  
	  // double
	  double myNum1 = 19.99D;
      Console.WriteLine(myNum1);
	  
	  // Long
	  long myNum2 = 15000000000L;
	  Console.WriteLine(myNum2);


    }
  }
}

/*
OUTPUT:
5
5.99
D
True
Hello
Hello World
B
35000
120000
19.99
15000000000
*/
