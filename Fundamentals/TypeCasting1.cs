//C# Type Casting
//Type casting is when you assign a value of one data type to another type.

//In C#, there are two types of casting:

//Implicit Casting (automatically) - converting a smaller type to a larger type size
//char -> int -> long -> float -> double

//Explicit Casting (manually) - converting a larger type to a smaller size type
//double -> float -> long -> int -> char

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
		
		// Implicit Casting
      int myInt = 8;
      double myDouble = myInt;  // Automatic casting: int to double

      Console.WriteLine(myInt);
      Console.WriteLine(myDouble);
	  
	  //Explicit Casting
	  double myDouble1 = 1.32;
      int myInt1 = (int) myDouble;  // Manual casting: double to int

      Console.WriteLine(myDouble1);
      Console.WriteLine(myInt1);
	  	  
	  // Type Conversion Method 
	  int myInt2 = 10;
      double myDouble2 = 3.75;
      bool myBool2 = true;

      Console.WriteLine(Convert.ToString(myInt));    // Convert int to string
      Console.WriteLine(Convert.ToDouble(myInt2));    // Convert int to double
      Console.WriteLine(Convert.ToInt32(myDouble2));  // Convert double to int
      Console.WriteLine(Convert.ToString(myBool2));   // Convert bool to string
    
    }
  }
}

/*
OUTPUT:
8
8
1.32
8
8
10
4
True

*/