

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using is a keyword, highlighted with blue by the editor. 
The using keyword imports a namespace, and a namespace is a collection of classes. 
Classes brings us some sort of functionality, and when working with an advanced IDE like Visual Studio,
it will usually create parts of the trivial code for us.


namespace ConsoleApp1

The namespace ConsoleApp1 is now the main namespace for this application, and new classes will be a part of it by default. 
Obviously, you can change this, and create classes in another namespace. 
In that case, you will have to import this new namespace to use it in your application, with the using statement, like any other namespace.


class Program

We can have more classes, even in the same file. 
For now, we only need one class.
A class can contain several variables, properties and methods,

static void Main(string[] args)
The static keyword tells us that this method should be accesible without instantiating the class,

The next keyword is void, and tells us what this method should return. 
For instance, it could be an integer or a string of text, but in this case, we don't want our method to return anything 
(C# uses the keyword void to express the concept of nothing).

The next word is Main, which is simply the name of our method. 
This method is the so-called entry-point of our application, that is, the first piece of code to be executed, and in our example, the only piece to be executed.

Now, after the name of a method, a set of arguments can be specified within a set of parentheses. 
In our example, our method takes only one argument, called args. 
The type of the argument is a string, or to be more precise, an array of strings, but more on that later. 
If you think about it, this makes perfect sense, since Windows applications can always be called with an optional set of arguments.
 These arguments will be passed as text strings to our main method.