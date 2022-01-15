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
			 
4. User Input
		
		Console.WriteLine("Enter your name :");     // Display
		string name = Console.ReadLine();			// get the input from user
	    Console.WriteLine("My name is " + name);    // display
		
		Console.WriteLine("Enter your ID number:");
		int id = Covert.ToInt32(Console.ReadLine());  // get the input from user
		Console.WriteLine("My ID number is:" + id);  //display 
		
		
		