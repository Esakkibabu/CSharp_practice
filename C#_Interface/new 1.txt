This article explains the following:

Why to use an interface in C#?
What is an interface?
What is the best example of an interface?
Why to use an interface

I hope everyone is quite familiar with OOP concepts in C++. (Class and Object, Inheritance and its type, so on).

Inheritance allows creating classes that are derived from other classes, so that they automatically include some of its "parent's" members, plus its own. The following are types of inheritances.

Multi-Level Inheritance
class Father {  
    //Father Relations--Members  
}  
class Mother: Father {  
    //Mother Relations--Members  
}  
class Child: Mother //Multi- Level Inheritance  
{  
    //Accessing both Relations class members.  
}  
Multiple Inheritance
class Father {  
    //Father Relations--Members  
}  
class Mother {  
    //Mother Relations--Members  
}  
class Child: Mother, Father //Multiple Inheritance  
{  
    //Accessing both Relations class members.  
}  
This type of multiple inheritance is possible in C++ but it's not possible in C#.

Interfaces in C#

What is Interface?

An interface looks like a class, but has no implementation. The only thing it contains are declarations of events, indexers, methods and/or properties. The reason interfaces only provide declarations is because they are inherited by structs and classes, that must provide an implementation for each interface member declared.

So, what are interfaces good for if they don't implement functionality? They're great for putting together plug-n-play like architectures where components can be interchanged at will. Since all interchangeable components implement the same interface, they can be used without any extra programming. The interface forces each component to expose specific public members that will be used in a certain way.

Because interfaces must be implemented by derived structs and classes, they define a contract. 

interface IMyInterface {  
    void MethodToImplement(); //Abstract Method signature.  
}  
class InterfaceImplementer: IMyInterface {  
    static void Main() {  
        InterfaceImplementer obj = new InterfaceImplementer();  
        obj.MethodToImplement();  
    }  
    public void MethodToImplement() {  
        //Abstract Method Implementation  
    }  
}  
Here, we advised to use "I" as the prefix for the interface to understand that the interface is an interface.

Best example for Interface

Here I have the best example for understanding interfaces.

Not Possible:
InterF.jpg
Open a Console Application and give "InterFaceDemo" as the project name, then add a new class item and rename it "ODDEVEN.CS".

ODDEVEN.cs 

using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
namespace InterFaceDemo {  
    interface IOne {  
        void ONE(); //Pure Abstract Method Signature  
    }  
    interface ITwo {  
        void TWO();  
    }  
    interface IThree: IOne {  
        void THREE();  
    }  
    interface IFour {  
        void FOUR();  
    }  
    interface IFive: IThree {  
        void FIVE();  
    }  
    interface IEVEN: ITwo, IFour {}  
    class ODDEVEN: IEVEN, IFive //Must Implement all the abstract method, in Derived class.  
    {  
        public void ONE() //Implementation of Abstract Method.  
        {  
            Console.WriteLine("This is ONE");  
        }  
        public void TWO() {  
            Console.WriteLine("This is TWO");  
        }  
        public void THREE() {  
            Console.WriteLine("This is THERE");  
        }  
        public void FOUR() {  
            Console.WriteLine("This is FOUR");  
        }  
        public void FIVE() {  
            Console.WriteLine("This is FIVE");  
        }  
    }  
}  
Program.cs 

using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
namespace InterFaceDemo {  
    class Program {  
        static void Main(string[] args) {  
            Console.WriteLine("This is ODD");  
            IFive obj1 = new ODDEVEN();  
            obj1.ONE();  
            obj1.THREE();  
            obj1.FIVE();  
            Console.WriteLine("\n\nThis is EVEN");  
            IEVEN obj2 = new ODDEVEN();  
            obj2.TWO();  
            obj2.FOUR();  
            Console.ReadLine();  
        }  
    }  
}  
The following is the output:

sss.jpg

Enjoy Coding.