// C# variables
using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
	  Console.WriteLine("OUTPUT:");
	   // Declaring Variables  
	  string name1 = "Balu";
      Console.WriteLine(name1); 
      string name2 = "Somu";
      Console.WriteLine("My name is " + name2);
	  int myNum = 5;
      Console.WriteLine(myNum);
	  int myNum2 = 15;
      myNum = 20;
      Console.WriteLine(myNum);
	  // Constants
	  // const int myNum = 15;     
	  //myNum = 20;					 // error
	  // Display Varibales
	  string firstName = "Happy";
      string lastName = "Birthday";
      string fullName = firstName + lastName;
      Console.WriteLine(fullName);
	  int x1 = 10;
      int y1 = 20;
      Console.WriteLine(x1 + y1);
	  //Declare many Variable
	  int x2 = 10, y2 = 20, z2 = 50;
      Console.WriteLine(x2 + y2 + z2); 
    }
  }
}
/* Output:
Balu
My name is  Somu
5
20
HappyBirthday
30
80
*/
