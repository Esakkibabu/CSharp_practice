The foreach statement in C# iterates through a collection of items such as an array or list, The foreach body must be enclosed in {} braces unless it consists of a single statement.
 
The code in Listing 1 creates an array of odd numbers and uses foreach loop to loop through the array items and read them.
using System;  
  
class Program  
{  
    static void Main(string[] args)  
    {  
        Console.WriteLine("foreach loop Sample!");  
        int[] oddArray = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };  
        foreach (int num in oddArray)  
        {  
            Console.WriteLine(num);  
        }  
        Console.ReadKey();  
    }  
}  
Listing 1.
 
The output of Listing 1 looks like Figure 1.
 
 
 
Figure 1.  
If you’re not familiar with Arrays in C#, please read article: Arrays Tutorial in C#. 

Listing 2 is an example of for loop that can also be used read an array items.
for (int counter = 0; counter < oddArray.Length; counter++)  
{  
    Console.WriteLine(oddArray[counter]);  
}  
Listing 2.
 
You can stop and exit a foreach loop by using the break, return, goto, and throw statements. The code snippet in Listing 3 quits execution once the number equals to 15. 
using System;  
  
class Program  
{  
    static void Main(string[] args)  
    {  
        Console.WriteLine("foreach loop Sample!");  
        // Array of odd numbers  
        int[] oddArray = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };  
        // Loop through array items  
        foreach (int num in oddArray)  
        {  
            Console.WriteLine(num);  
            // Don't read any number after 15  
            if (num == 15) break;  
        }  
        Console.ReadKey();  
    }  
}  
Listing 3.
 
Use foreach to find a char in a string
Remember your early days, when you need to find a character in a string. We can use foreach loop for this to check one character at a time in a string using a foreach,in loop. Strings are an important . Strings in C#

Code snippet in Listing 4 creates an array of chars from a string and reads one character at a time. The code also makes sure that whitespace between characters is skipped.

// Read a string - one character at a time and if space, skip it  
string name = "Mahesh Chand Beniwal";  
  
// Convert string into an array of chars  
char[] chArray = name.ToCharArray();  
  
// Loop through chars and display one char at a time  
foreach (char ch in chArray)  
{  
if (ch.ToString() != " ")  
Console.WriteLine(ch);  
}  
Listing 4. 

Foreach in Collection
Let’s look at another use of the foreach, in loop. Do you remember your early programming days when you need to go through a string and find the number of occurrences of a character in a string? The code in Listing 5 does the same using a foreach, in loop.

// Find number of occurrences of a char in a string  
string str = "A monkey stole a banana, climb on a tree and ate it.";  
char[] chars = str.ToCharArray();  
int ncount = 0;  
// Loop through chars and find all 'n' and count them  
foreach (char ch in chars)  
{  
if (ch == 'n')  
ncount++;  
}  
Console.WriteLine($"Total n found {ncount}");  
Listing 5. 

Foreach in Array
Here is another example of using a foreach, in loop. The code snippet in Listing 6 creates an array of strings, reads and display each string one at a time.

// Array of authors - string  
string[] authorList = new string[]  
{ "Mahesh Chand", "Raj Kumar", "Naveen Sharma", "Allen O'neill", "Dave McCarter" };  
// Loop through array and read all authors  
foreach (string author in authorList )  
{  
Console.WriteLine(author);  
}  
Listing 6. 

Summary
The foreach, in loop in C# is used to loop through the items in a collection. In this article and code samples, we saw various usage of the foreach, in loop. 

Next reading: The for vs foreach in C# 
 
CSharp for eachCSharp foreachfor each loop C#for each statement C#foreach inforeach loop C#


Next Recommended Reading
Parallel.ForEach() Vs Foreach() Loop in C#