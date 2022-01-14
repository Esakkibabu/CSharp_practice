// C# User input 

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // Type your username and press enter
      Console.WriteLine("Enter username:");

      // Create a string variable and get user input from the keyboard and store it in the variable
      string userName = Console.ReadLine();

      // Print the value of the variable (userName), which will display the input value
      Console.WriteLine("Username is: " + userName);
	  
	  
	  //The Console.ReadLine() method returns a string. 
	  //Therefore, you cannot get information from another data type, such as int.
	  //The following program will cause an error:
	  
	  // User Input and Numbers
	  Console.WriteLine("Enter your age:");
      int age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Your age is: " + age);  
    }
  }
}

/*
OUTPUT:
Enter username:
abcd
Username is: abcd
Enter your age:
45
Your age is: 45
*/