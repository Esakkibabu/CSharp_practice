// How to Create an object for class in C# 
using System;
namespace MyApplication
{
  class Cricket
  {
    string  match= "ODI";
    static void Main(string[] args)
    {
      Cricket myObj = new Cricket();
      Console.WriteLine(myObj.match);
    }	
  }
}