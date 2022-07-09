# Fundamentals

1. C# syntax?

	using System;            // importing namespace section
	namespace firstprogram   // Namespace declaration section
	{
		class myprogram      // class declaration section
		{
			static void Main(string[] args)    // main method
			{
				Console.WriteLine("Welcome");
			}
		}
	}
	
2. Data Types in C#
	
	int x; int y=15;  
	string name ="hello";
	char z='A';
	double num=3.14D'
	bool  mybool="true";
	
3. Type Casting
	
	Implicit Casting (automatically)
		
		char -> int -> long-> float-> double
		 eg. int myint = 9;
		     double = mydoub = myint;
			 
	Explicit Casting (manually)
	
		double-> float -> long-> int -> char
		
		 eg. double mydoub=9.78;
			 int myint = (int)mydoub;  
			 
	Type Conversion using Parse()
	
	type conversion between non-compatible types like int and string, we use Parse().
	We cannot use Parse() to convert a textual string like "test" to an int.
	
	
	Type Conversion using Convert Class
	
In C#, we can use the Convert class to perform type conversion. The Convert class provides various methods to convert one type to another.

			| Method	  |Description							 |
			|-------------|--------------------------------------|	
			| ToBoolean() |	converts a type to a Boolean value	 |	
			| ToChar()	  |	converts a type to a char type		 |
			| ToDouble()  | converts a type to a double type	 |
			| ToInt16()	  | converts a type to a 16-bit int type |
			| ToString()  | converts a type to a string			 |

	Convert int to String and Double
	
	Convert.ToString(a) - converts an int type num to string
    Convert.ToDouble(a) - converts num to the Double type
	
4. User Input
		
		Console.WriteLine("Enter your name :");     // Display
		string name = Console.ReadLine();			// get the input from user
	    Console.WriteLine("My name is " + name);    // display
		
		Console.WriteLine("Enter your ID number:");
		int id = Covert.ToInt32(Console.ReadLine());  // get the input from user
		Console.WriteLine("My ID number is:" + id);  //display 
		
		
		