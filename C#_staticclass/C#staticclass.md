# C# static class

In C#, a static class is a class that cannot be instantiated. The main purpose of using static classes in C# is to provide blueprints of its inherited classes. Static classes are created using the static keyword in C# and .NET. A static class can contain static members only. You can‘t create an object for the static class.
Advantages of Static Classes

If you declare any member as a non-static member, you will get an error. 
When you try to create an instance to the static class, it again generates a compile time error, because the static members can be accessed directly with its class name.
The static keyword is used before the class keyword in a class definition to declare a static class.
A static class members are accessed by the class name followed by the member name. 
Syntax of static class
static class classname  
{  
   //static data members  
   //static methods  
}  
Static Class Demo
namespace StaticConstructorsDemo  
{  
    class MyCollege  
    {  
        //static fields  
        public static string CollegeName;  
        public static string Address;  
  
        //static constructor  
        static MyCollege()  
        {  
            CollegeName = "ABC College of Technology";  
            Address = "Hyderabad";  
        }  
    }  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            Console.WriteLine(MyCollege.CollegeName);  
            Console.WriteLine(MyCollege.Address);  
            Console.Read();  
        }  
    }  
} 
Static Members

There are two types of C# static class members, static and non-static.
 
Non-static members
 
This is the default type for all the members. If you do not use the "static" keyword for the declaration of a field / property or a method, then it can be called a "Non-static member". The main feature of a non-static member is it will be bound with the object only.

Non-static Fields / Properties
The memory is allocated when the object is created.
Non-static Methods
These methods can implement operations on non-static fields and properties

Static Members
 
If you use the "static" keyword for the declaration of a field / property or a method, then it is called a "Static member". The main feature of a non-static member is that it will not be bound with any object. It is individually accessible with the class name. In other words, the static members are accessible directly, without even creating one object also.

Static Fields / Properties
The memory will be allocated individually, without any relation with the object.
Static Methods
These methods can implement operations on static fields and properties only; and can‘t access the non-static members.

Static Members 

Demo on static members
using System;  
using System.Linq;  
using System.Text;  
using System.Collections.Generic;  
namespace StaticConstructorsDemo  
{  
    class Student  
    {  
        //non-statcic data members  
        public string StudentName;  
        public string Course;  
        public void SetStudentDetails(string StuName, string Cou)  
        {  
            StudentName = StuName;  
            Course = Cou;  
        }  
        public void DisplayStudentDetails()  
        {  
            Console.WriteLine(StudentName + " - " + Course);  
        }  
  
        //static data members  
        public static string CollegeName = "ABC College of Technology";  
        public static string CollegeAddress = "Hyderabad";  
  
        //static methods  
        public static void DisplayCollegeDetails()  
        {  
            Console.WriteLine(CollegeName);  
            Console.WriteLine(CollegeAddress);  
        }  
    }  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            //access static members  
            Student.DisplayCollegeDetails();  
  
            //acess non-static members  
            Console.WriteLine();  
            Student s1= new Student();  
            Student s2 = new Student();  
            s1.SetStudentDetails("Sarath","MCA");  
            s1.SetStudentDetails("Syam","MBA");  
            s1.DisplayStudentDetails();  
            s2.DisplayStudentDetails();  
            Console.Read();  
        }  
    }  
}
 
Static Constructors
A static constructor is used to initialize the static data members, whereas the normal constructor (non-static constructor) is used to initialize the non-static data members.

Syntax

static classname()  
{  
   //some code  
}  
Rules

Static constructors can‘t contain any access modifiers.
Static constructors can‘t be defined with arguments.
Static constructors can‘t access the non-static data members.
Demo on static constructors
namespace StaticConstructorsDemo  
{  
    class MyCollege  
    {  
        //static fields  
        public static string CollegeName;  
        public static string Address;  
  
        //static constructor  
        static MyCollege()  
        {  
            CollegeName = "ABC College of Technology";  
            Address = "Hyderabad";  
        }  
    }  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            Console.WriteLine(MyCollege.CollegeName);  
            Console.WriteLine(MyCollege.Address);  
            Console.Read();  
        }  
    }  
} 
Summary
 
In this article, we saw how to create and use a static class in C#.
C# Static ClassC# Static Class AdvantagesC# Static ConstructorsStatic Members


Next Recommended Reading
Rules for creating C# Static Classes