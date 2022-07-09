/*C# allows us to create generic methods also.
 In the following example, we are creating generic method that can be called by passing any type of argument.
*/

using System;  
namespace CSharpProgram  
{  
    class GenericClass  
    {  
        public void Show<T>(T msg)  
        {  
            Console.WriteLine(msg);  
        }  
    }  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            GenericClass genC = new GenericClass();  
            genC.Show("This is generic method");  
            genC.Show(101);  
            genC.Show('I');  
        }  
    }  
}  
/*Output:

This is generic method
101
I*/
