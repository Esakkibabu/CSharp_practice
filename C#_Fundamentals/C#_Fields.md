Fields are ordinary member variables or member instances of a class. Properties are an abstraction to get and set their values. Properties are also called accessors because they offer a way to change and retrieve a field if you expose a field in the class as private. Generally, you should declare your member variables private, then declare or define properties for them.

There are three obvious reasons for the necessity of properties in C#.

You can delay the creation of actual reference fields until you use them, which saves resources. You can differentiate the representation and actual storage. Representation is implemented via properties and storage is implemented via fields. You can check constraints when setting and getting properties. If the value is not suitable, you do not store the data in the field and a type-safety error is returned. This really provides 100% type-safe accessors on demand.

Properties afford you the advantage of more elegant syntax along with the robustness and better encapsulation of accessor methods. The syntax for implementing a property in C#, along with a constructor and a destructor and using the property is shown in the Age property in Listing 5.74.

Listing 5.74: Constructor Destructor Example

// example property, ctor, dtor, exception

using System;

public class Individual
{
    Int32 age; // note that this is private
    // we could do this instead, more explicit
    // private Int32 age;
    // the default specifiers are all private!!!

    public Individual(Int32 age)
    { // constructor, ctor
        this.age = age; // this object, just for more clarity
    }

    ~Individual()
    { // destructor
        age = 0;
    }

    public Int32 Age
    { // public property
        get
        {
            return age;
        }

        set
        { // validating value
            if (value > 0 && value < 200)
            {
                age = value;
            }
            else
            { // throw exception if invalid value
                throw new ArgumentException("not between 1 and 150 ?");
            }
        }
    }
}

class TestIndividual
{
    public static void Main()
    {
        try
        {
            Individual Jabbar = new Individual(27);
            Console.WriteLine("This year, Jabbar was {0} years old", Jabbar.Age);
            Jabbar.Age++; // uses both get and set to do increment
            Console.WriteLine("Next year, Jabbar will be {0} years old", Jabbar.Age);
        }

        catch (ArgumentException e)
        {
            // catches this specific type and derived types
            // uses Exception.ToString()
            Console.WriteLine("{0} Caught exception #1.", e);
        }
        Console.ReadLine();
    }
}

The resulting output is shown in Figure 5.30.

Figure5.30.gif

Figure 5.30: Screen Output Generated from Listing 5.74

The pseudocode in Listing 5.75 presents a read-only property example that defers resource allocation with the help of properties.

// example property pseudocode, delayed resource allocation
// you allocate resources only when you really need them
// class 1

class MyReader
{
    // prop1 - property
}

// class 2
class MyWriter
{
    // prop2 - property
    // prop3 - property
}

public class ExamplePropertyImplementation
{
    private static MyReader reader;
    private static MyWriter writer;
    private static MyWriter error;

    // public property
    public static MyReader prop1
    {
        get
        {
            if (reader == null)
            {
                reader = new Reader();
            }

            return reader;
        }
    }

    // public property
    public static MyWriter prop2
    {
        get
        {
            if (writer == null)
            {
                writer = new MyWriter();
            }
            return writer;
        }
    }

    // public property
    public static MyWriter prop3
    {
        get
        {
            if (error == null)
            {
                error = new Writer();
            }
            return error;
        }
    }
}

By exposing these members as properties, the class can delay their initialization until they are actually used. Thus, if the application makes no reference to the prop2 and prop3 properties, no objects are created for those objects.

Conclusion

Hope this article would have helped you in understanding Fields and Properties in C#. See other articles on the website on .NET and C#.