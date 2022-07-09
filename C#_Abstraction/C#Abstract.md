# C# Abstract Class
 
An abstract class is an incomplete class or special class we can't be instantiated. The purpose of an abstract class is to provide a blueprint for derived classes and set some rules what the derived classes must implement when they inherit an abstract class.
 
We can use an abstract class as a base class and all derived classes must implement abstract definitions. An abstract method must be implemented in all non-abstract classes using the override keyword. After overriding the abstract method is in the non-Abstract class. We can derive this class in another class and again we can override the same abstract method with it.
 
C# Abstract Class Features
An abstract class can inherit from a class and one or more interfaces.
An abstract class can implement code with non-Abstract methods.
An Abstract class can have modifiers for methods, properties etc.
An Abstract class can have constants and fields.
An abstract class can implement a property.
An abstract class can have constructors or destructors.
An abstract class cannot be inherited from by structures.
An abstract class cannot support multiple inheritance.
Example 1
	#region  
  
//An abstract calss can inherit from a class and one or more interfaces.  
  
interface IVendorTransDetails  
{  
    void getVendorID();  
}  
interface IClaimsTracker  
{  
    void getSeqID();  
}  
class ClaimsMaster  
{  
    string getDCNNO()  
    {  
        return "PC20100308A00005";  
    }  
}  
Example 2
abstract class Abstract : ClaimsMaster, IClaimsTracker, IVendorTransDetails  
{  
    //Here we should implement modifiers oterwise it throws complie-time error  
    public void getVendorID()  
    {  
        int s = new int();  
        s = 001;  
        Console.Write(s);  
    }  
  
    public void getSeqID()  
    {  
        int SeqID = new int();  
        SeqID = 001;  
        Console.Write(SeqID);  
    }  
}   
#endregion  
Example 3
    #region  
  
    //An abstract class can implement code with non-Abstract methods.  
  
abstract class NonAbstractMethod  
{  
    //It is a Non-abstract method we should implement code into the non-abstract method on the class.   
    public string getDcn()  
    {  
        return "PS20100301A0012";  
    }   
    public abstract void getSeqID();   
}   
class Utilize : NonAbstractMethod  
{  
    public override void getSeqID()  
    {  
    }  
  
}   
#endregion  
Example 4
#region   
//Abstract class can have modifiers for methods,properties and An abstract class can implement a property  
  
public abstract class abstractModifier  
{  
    private int id;   
    public int ID  
    {  
        get { return id; }  
        set { id = value; }  
    }   
    internal abstract void Add();  
}   
#endregion  
Example 5
#region   
//Abstract class can have constant and fields  
public abstract class ConstantFields  
{  
    public int no;  
    private const int id = 10;  
}  
#endregion
Example 6
#region   
//An abstract class can have constructors or destructors  
abstract class ConsDes  
{  
    ConsDes()  
    {  
    }  
    ~ConsDes()  
    {  
    }  
}  
#endregion  
Example 7
#region   
//An abstract class cannot be inherited from by structures  
public struct test  
{  
}  
//We can't inheritance the struct class on the abstract class  
abstract class NotInheritanceStruct  
{  
}  
#endregion  
Example 8
#region   
//An abstract class cannot support multiple inheritance  
class A  
{  
}  
class B : A  
{  
}  
abstract class Container : B //But we can't iherit like this : A,B  
{  
}  
#endregion  
Conclusion
 
In this article I have given some simple examples of how to use abstract classes in C#. 
 
Here is a detailed article on Abstract Classes In C#. 
 
Here is another related reading: Method Overloading and Overriding In C# 