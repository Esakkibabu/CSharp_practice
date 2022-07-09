# C# string
Strings are one of the most important data types in any modern language including C#. In this article, you will learn how to work with strings in C#. The article discusses the String class, its methods and properties and how to use them.  

1. C# String
In any programming language, to represent a value, we need a data type. The Char data type represents a character in .NET. In .NET, the text is stored as a sequential read-only collection of Char data types. There is no null-terminating character at the end of a C# string; therefore a C# string can contain any number of embedded null characters ('\0').

The System.String data type represents a string in .NET. A string class in C# is an object of type System.String. The String class in C# represents a string.

The following code creates three strings with a name, number, and double values.

// String of characters
System.String authorName = "Mahesh Chand";

// String made of an Integer
System.String age = "33";

// String made of a double
System.String numberString = "33.23";
C#
Here is the complete example that shows how to use stings in C# and .NET. 

using System;
namespace CSharpStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define .NET Strings
            // String of characters
            System.String authorName = "Mahesh Chand";

            // String made of an Integer
            System.String age = "33";

            // String made of a double
            System.String numberString = "33.23";

            // Write to Console.
            Console.WriteLine("Name: {0}", authorName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Number: {0}", numberString);
            Console.ReadKey();
        }
    }
}
C#
2. .NET String Class
String class defined in the .NET base class library represents text as a series of Unicode characters. The String class provides methods and properties to work with strings.

The String class has methods to clone a string, compare strings, concatenate strings, and copy strings. This class also provides methods to find a substring in a string, find the index of a character or substring, replace characters, split a string, trim a string, and add padding to a string. The string class also provides methods to convert a string's characters to uppercase or lowercase.

Check out these links to learn about a specific operation or functionality of strings.  

3. What is different between String and System.String?
.NET defines all data types as a class. The System.String class represents a collection of Unicode characters also known as a text. The System.String class also defines the properties and methods to work with string data types.

The String class is equivalent to the System.String in C# language. The string class also inherits all the properties and methods of the System.String class.

4. Create a string
There are several ways to construct strings in C# and .NET.

Create a string using a constructor
Create a string from a literal
Create a string using concatenation
Create a string using a property or a method
Create a string using formatting
Create a string using its constructor

The String class has several overloaded constructors that take an array of characters or bytes. The following code snippet creates a string from an array of characters.

char[] chars = { 'M', 'a', 'h', 'e', 's', 'h' };
string name = new string(chars);
Console.WriteLine(name);
C#
Create a string from a literal

This is the most common ways to instantiate a string.

You simply define a string type variable and assign a text value to the variable by placing the text value without double quotes. You can put almost any type of characters within double quotes accept some special character limitations.

The following code snippet defines a string variable named firstName and then assigns text value Mahesh to it.

string firstName;
firstName = "Mahesh";
C#
Alternatively, we can assign the text value directly to the variable.

string firstName = "Mahesh";
C#
Here is a complete sample example of how to create strings using literals.

using System;
namespace CSharpStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Mahesh";
            string lastName = "Chand";
            string age = "33";
            string numberString = "33.23";
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Number: {0}", numberString);
            Console.ReadKey();
        }
    }
}
C#
5. Create a string using concatenation
Sting concatenation operator (+) can be used to combine more than one string to create a single string. The following code snippet creates two strings. The first string adds a text Date and current date value from the DateTime object. The second string adds three strings and some hard coded text to create a larger string.

string nowDateTime = "Date: " + DateTime.Now.ToString("D");
string firstName = "Mahesh";
string lastName = "Chand";
string age = "33";
string authorDetails = firstName + " " + lastName + " is " + age + " years old.";

Console.WriteLine(nowDateTime);
Console.WriteLine(authorDetails);
C#
Here is a detailed article on string concatenation - Six Effetive Ways To Concatenate Strings In C#. 

6. Create a string using a property or a method
Some properties and methods of the String class returns a string object such as SubString method. The following code snippet takes one sentence string and finds the age within that string. The code returns 33.

string authorInfo = "Mahesh Chand is 33 years old.";
int startPosition = sentence.IndexOf("is ") + 1;
string age = authorInfo.Substring(startPosition +2, 2 );
Console.WriteLine("Age: " + age);
C#
7. Create a string with Format
The String.Format method returns a string. The following code snippet creates a new string using the Format method.

string name = "Mahesh Chand";
int age = 33;
string authorInfo = string.Format("{0} is {1} years old.", name, age.ToString());
Console.WriteLine(authorInfo);
C#
Here is a detailed article on formatting string - Use of String.Format() To format strings in C#

8. Create a string using ToString Method
The ToString method returns a string. We can apply ToString on pretty much any data type that can be converted to a string. The following code snippet converts an int data type to a string.

string name = "Mahesh Chand";
int age = 33;
string authorInfo = string.Format("{0} is {1} years old.", name, age.ToString());
Console.WriteLine(authorInfo);
C#
9. Get all characters of a string using C#
A string is a collection of characters.

The following code snippet reads all characters of a string and displays on the console.

string nameString = "Mahesh Chand";
for (int counter = 0; counter <= nameString.Length - 1; counter++)
Console.WriteLine(nameString[counter]);
C#
10. Get size of string
The Length property of the string class returns the number of characters in a string including white spaces.

The following code snippet returns the size of a string and displays on the console.

string nameString = "Mahesh Chand";
Console.WriteLine(nameString);
Console.WriteLine("Size of string {0}", nameString.Length);
C#
11. Get number of characters in a string
We can use the string.Length property to get the number of characters of a string but it will also count an empty character. So, to find out the exact number of characters in a string, we need to remove the empty character occurrences from a string.

The following code snippet uses the Replace method to remove empty characters and then displays the non-empty characters of a string.

string name = "Mahesh Chand";

string name = "Mahesh Chand";

// Get size of string
Console.WriteLine("Size of string: {0}", name.Length );

// Remove all empty characters
string nameWithoutEmptyChar = name.Replace(" ", "");

// Size after empty characters are removed
Console.WriteLine("Size of non empty char string: {0}", nameWithoutEmptyChar.Length);

// Read and print all characters
for (int counter = 0; counter <= nameWithoutEmptyChar.Length - 1; counter++)
Console.WriteLine(nameWithoutEmptyChar[counter]);
C#
12. Convert String to Char Array
ToCharArray method converts a string to an array of Unicode characters. The following code snippet converts a string to char array and displays them.

string sentence = "Mahesh Chand is an author and founder of C# Corner";
char[] charArr = sentence.ToCharArray();
foreach (char ch in charArr)
{
  Console.WriteLine(ch);
}
C#
13. What is an empty string
An empty string is a valid instance of a System.String object that contains zero characters. There are two ways to create an empty string. We can either use the string.Empty property or we can simply assign a text value with no text in it.

The following code snippet creates two empty strings.

string empStr = string.Empty;
string empStr2 = "";
C#
Both of the statements above generates the same output.

An empty string is sometimes used to compare the value of other strings. The following code snippet uses an empty string to compare with the name string.

string name = "Mahesh Chand";
if (name != empStr)
{
  Console.WriteLine(name);
}
C#
In real-world coding, we will probably never create an empty string unless you plan to use it somewhere else as a non-empty string. We can simply use the string.Empty direct to compare a string with an empty string.

if (name != string.Empty)
{
  Console.WriteLine(name);
}
C#
Here is a complete example of using an empty string. 

string empStr = string.Empty;
string empStr2 = "";
string name = "Mahesh Chand";
if (name != empStr)
{
  Console.WriteLine(name);
}
if (name != string.Empty)
{
  Console.WriteLine(name);
}
C#
14. Understanding Null Strings in C#
A null string is a string variable that has not been initialized yet and has a null value. If you try to call any methods or properties of a null string, you will get an exception. A null string valuable is exactly the same as any other variable defined in your code.

A null string is typically used in string concatenation and comparison operations with other strings.

The following code example shows how to use a null string.

string nullStr = null;
string empStr = string.Empty;
string name = "Mahesh Chand";

if ((name != nullStr) || (name != empStr))
{
  Console.WriteLine(name + " is neither null nor empty");
}
C#
15. Summary
In this article, we learned the basics of strings in C# and .NET and how to use the String class available in .NET in our code. Here are some more similar articles related to strings in .NET with C#. 

How to compare strings In C# 
How to use string interpolation In C#
How to trim strings In C#
How to use StringBuilder In C#
How to change a string to uppercase and lowercase in C#
How to remove and replace strings in C#
How to apply padding in strings in C#
How to use a StringCollection in C#
How to create and use substrings in C#
How to convert a byte array to a string in C#
How to create a random string in C#
How to split a string in C#