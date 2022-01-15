// C# Class and Objects 
// C# class and Multiple Objects
using System;
namespace MyApplication
{
  class Sports
  {
    string Cricket = "Test Match";
	int x =5,y=90;
    static void Main(string[] args)
    {
      Sports myObj = new Sports();
      Console.WriteLine(myObj.Cricket);
	  
	  // Multiplie Objects
	  Sports myObj1 = new Sports();
      Sports myObj2 = new Sports();
      Console.WriteLine(myObj1.x +  "Days");
      Console.WriteLine(myObj2.y +" "+ "Overs per Day");
    }
  }
}

/* 
OUTPUT:
Test Match
5Days
90 Overs per Day
*/
