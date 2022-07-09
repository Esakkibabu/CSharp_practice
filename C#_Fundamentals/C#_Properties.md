Property in C# is a member of a class that provides a flexible mechanism for classes to expose private fields. Internally, C# properties are special methods called accessors. A C# property have two accessors, get property accessor and set property accessor. A get accessor returns a property value, and a set accessor assigns a new value. The value keyword represents the value of a property.

Properties in C# and .NET have various access levels that is defined by an access modifier. Properties can be read-write, read-only, or write-only. The read-write property implements both, a get and a set accessor. A write-only property implements a set accessor, but no get accessor. A read-only property implements a get accessor, but no set accessor.

C# Properties
 
In C#, properties are nothing but a natural extension of data fields. They are usually known as 'smart fields' in C# community. We know that data encapsulation and hiding are the two fundamental characteristics of any object oriented programming language. In C#, data encapsulation is possible through either classes or structures. By using various access modifiers like private, public, protected, internal etc it is possible to control the accessibility of the class members. 
Usually, inside a class, we declare a data field as private and will provide a set of public SET and GET methods to access the data fields. This is a good programming practice since the data fields are not directly accessible outside the class. We must use the set/get methods to access the data fields. 

An example, which uses a set of set/get methods, is shown below. 

//SET/GET methods  
//Author: rajeshvs@msn.com  
using System;  
class MyClass  
{  
    private int x;  
    public void SetX(int i)  
    {  
        x = i;  
    }  
    public int GetX()  
    {  
        return x;  
    }  
}  
class MyClient  
{  
    public static void Main()  
    {  
        MyClass mc = new MyClass();  
        mc.SetX(10);  
        int xVal = mc.GetX();  
        Console.WriteLine(xVal);
    }  
}
The output from above listing is shown below. 
 
 
 
But C# provides a built in mechanism called properties to do the above. In C#, properties are defined using the property declaration syntax. The general form of declaring a property is as follows.
<acces_modifier> <return_type> <property_name>  
   {  
      get  
   {  
   }  
      set  
   {  
   }  
}  
Where <access_modifier> can be private, public, protected or internal. The <return_type> can be any valid C# type. Note that the first part of the syntax looks quite similar to a field declaration and second part consists of a get accessor and a set accessor. 
For example, the above program can be modified with a property X as follows.

class MyClass  
{  
    private int x;  
    public int X  
    {  
        get  
        {  
            return x;  
        }  
        set  
        {  
            x = value;  
        }  
    }  
}  
The object of the class MyClass can access the property X as follows.
MyClass mc = new MyClass();  
mc.X = 10; // calls set accessor of the property X, and pass 10 as value of the standard field 'value'. 
This is used for setting value for the data member x.

Console.WriteLine(mc.X);// displays 10. Calls the get accessor of the property X. 
The complete program is shown below.

//C#: Property  
//Author: rajeshvs@msn.com  
using System;  
class MyClass  
{  
    private int x;  
    public int X  
    {  
        get  
        {  
            return x;  
        }  
        set  
        {  
            x = value;  
        }  
    }  
}  
class MyClient  
{  
    public static void Main()  
    {  
        MyClass mc = new MyClass();  
        mc.X = 10;  
        int xVal = mc.X;  
        Console.WriteLine(xVal);//Displays 10  
    }  
}  
Remember that a property should have at least one accessor, either set or get. The set accessor has a free variable available in it called value, which gets created automatically by the compiler. We can't declare any variable with the name value inside the set accessor.
We can do very complicated calculations inside the set or get accessor. Even they can throw exceptions. 

Since normal data fields and properties are stored in the same memory space, in C#, it is not possible to declare a field and property with the same name. 

Static Properties
C# also supports static properties, which belongs to the class rather than to the objects of the class. All the rules applicable to a static member are applicable to static properties also. 

The following program shows a class with a static property.

//C# : static Property  
//Author: rajeshvs@msn.com  
using System;  
class MyClass  
{  
    private static int x;  
    public static int X  
    {  
        get  
        {  
            return x;  
        }  
        set  
        {  
            x = value;  
        }  
    }  
}  
class MyClient  
{  
    public static void Main()  
    {  
        MyClass.X = 10;  
        int xVal = MyClass.X;  
        Console.WriteLine(xVal);//Displays 10  
    }  
}  
Remember that set/get accessor of static property can access only other static members of the class. Also ,static properties are invoking by using the class name. 
 
Properties & Inheritance 
The properties of a Base class can be inherited to a Derived class.

//C# : Property : Inheritance  
//Author: rajeshvs@msn.com  
using System;  
class Base  
{  
    public int X  
    {  
        get  
        {  
            Console.Write("Base GET");  
            return 10;  
        }  
        set  
        {  
            Console.Write("Base SET");  
        }  
    }  
}  
class Derived : Base  
{  
}  
class MyClient  
{  
    public static void Main()  
    {  
        Derived d1 = new Derived();  
        d1.X = 10;  
        Console.WriteLine(d1.X);
    }  
}
The output from above listing is shown below.
 
 
 
The above program is very straightforward. The inheritance of properties is just like inheritance any other member.
 
Properties & Polymorphism 
A Base class property can be polymorphically overridden in a Derived class. But remember that the modifiers like virtual, override etc are using at property level, not at accessor level.

//C# : Property : Polymorphism  
//Author: rajeshvs@msn.com  
using System;  
class Base  
{  
    public virtual int X  
    {  
        get  
        {  
            Console.Write("Base GET");  
            return 10;  
        }  
        set  
        {  
            Console.Write("Base SET");  
        }  
    }  
}  
class Derived : Base  
{  
    public override int X  
    {  
        get  
        {  
            Console.Write("Derived GET");  
            return 10;  
        }  
        set  
        {  
            Console.Write("Derived SET");  
        }  
    }  
}  
class MyClient  
{  
    public static void Main()  
    {  
        Base b1 = new Derived();  
        b1.X = 10;  
        Console.WriteLine(b1.X);
    }  
}
The output from above listing is shown below.
 
 
 
Abstract Properties 

A property inside a class can be declared as abstract by using the keyword abstract. Remember that an abstract property in a class carries no code at all. The get/set accessors are simply represented with a semicolon. In the derived class we must implement both set and get assessors. 
If the abstract class contains only set accessor, we can implement only set in the derived class. 

The following program shows an abstract property in action.

//C# : Property : Abstract  
//Author: rajeshvs@msn.com  
using System;  
abstract class Abstract  
{  
    public abstract int X  
    {  
        get;  
        set;  
    }  
}  
class Concrete : Abstract  
{  
    public override int X  
    {  
        get  
        {  
            Console.Write(" GET");  
            return 10;  
        }  
        set  
        {  
            Console.Write(" SET");  
        }  
    }  
}  
class MyClient  
{  
    public static void Main()  
    {  
        Concrete c1 = new Concrete();  
        c1.X = 10;  
        Console.WriteLine(c1.X);
    }  
}  
The output from above listing is shown below.
 
 
 
The properties are important features added in language level inside C#. They are very useful in GUI programming. Remember that the compiler actually generates the appropriate getter and setter methods when it parses the C# property syntax.
 
Properties Access Modifiers
 
Access modifiers defines the access level of a property whether a property can be accessed by any caller program, within an assembly, or just within a class.
 
The following table describes access level modifiers. 
public - The type or member can be accessed by any other code in the same assembly or another assembly that references it.
Private - The type or member can be accessed only by code in the same class or struct.
protected - The type or member can be accessed only by code in the same class, or in a class that is derived from that class.
internal - The type or member can be accessed by any code in the same assembly, but not from another assembly.
protected internal - The type or member can be accessed by any code in the assembly in which it is declared, or from within a derived class in another assembly.
private protected - The type or member can be accessed only within its declaring assembly, by code in the same class or in a type that is derived from that class.
Automatically Implemented Properties
 
A typical implementation of a public property looks like Listing . The default implementation of a property needs a getter and setter.
private string name;  
public string Name  
{  
   get { return this.name; }  
   set { this.name = value; }  
}  
Auto-implemented properties in C# makes code more readable and clean if there is no additional calculation needed. The above code of Listing can be replaced by the following one line of code in Listing
public string Name { get; set; }  
In case of auto-implemented properties, the compiler creates a private field variable that can only be accessed through the property's getter and setter.
 
Code listed in Listing is a class with several auto-initialized properties.
using System;  
class Author {  
    // Read-write properties    
    public string Name {  
        get;  
        set;  
    }  
    public string Publisher {  
        get;  
        set;  
    }  
    public string Book {  
        get;  
        set;  
    }  
    public Int16 Year {  
        get;  
        set;  
    }  
    public double Price {  
        get;  
        set;  
    }  
    public string PriceInString {  
        get {  
            return string.Format("${0}", Price);  
        }  
    }  
    // Read-only properties    
    public string Names {  
        get;  
    }  
    // Initialization of a property    
    public double AuthorCount {  
        get;  
        private set;  
    } = 99;  
    // Class constructor    
    public Author(string name, string publisher, string book, Int16 year, double price) {  
        Name = name;  
        Publisher = publisher;  
        Book = book;  
        Year = year;  
        Price = price;  
    }  
    // Public methods    
    public string AuthorDetails() {  
        return string.Format("{0} is an author of {1} published by {2} in year {3}. Price: ${4}", Name, Book, Publisher, Year, Price);  
    }  
    public double CostOfThousandBooks() {  
        if (Price > 0) return Price * 1000;  
        return 0;  
    }  
} 
The code in Listing is creates an instance of the class and calls its methods and properties.
class Program   
{  
    static void Main()   
  {  
        Author author = new Author("Mahesh Chand", "Apress", "Programming C#", 2003, 49.95);  
        Console.WriteLine(author.AuthorDetails());  
        Console.WriteLine("Author published his book in {0}", author.Year);  
        author.Price = 50;  
        Console.WriteLine(author.CostOfThousandBooks().ToString());  
        Console.ReadKey();  
    }  
}  