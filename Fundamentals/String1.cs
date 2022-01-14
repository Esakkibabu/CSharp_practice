//C# String
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string greeting = "Welcome";
      Console.WriteLine(greeting);  
	  
	  // String Length
	  string txt = "Happy Birthday";
      Console.WriteLine("The length of the txt string is: " + txt.Length);
	  
	  // string case
	  string txt1 = "Happy New Year";
      Console.WriteLine(txt1.ToUpper());   
      Console.WriteLine(txt1.ToLower());   
      
	  // String Concatenation
	  string firstName = "Bala ";
      string lastName = "Murugan";
      string name = firstName + lastName;
      Console.WriteLine(name);
	  
	  string firstName1 = "Somu";
      string lastName1 = "Sekar";
      string name1 = string.Concat(firstName1, lastName1);
      Console.WriteLine(name1);
	  
	  // string Interpolation
	  string firstName2 = "Raj";
      string lastName2 = "Babu";
      string name2 = $"My full name is: {firstName2} {lastName2}";
      Console.WriteLine(name2);
     }
  }
}

/*
OUTPUT:
Welcome
The length of the txt string is: 14
HAPPY NEW YEAR
happy new year
Bala Murugan
SomuSekar
My full name is: Raj Babus
*/

