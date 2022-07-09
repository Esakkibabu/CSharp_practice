C# array a collection of objects or types. C# array elements can be of any type, including other array types. An array can be Single-Dimensional, Multidimensional, or Jagged. The Array class in C# represents an array. This tutorial is an introduction to array and how to use arrays in C#. The tutorial also discusses various methods and properties of C# Array class.

In C#, an array index starts at zero. That means the first item of an array starts at the 0th position. The position of the last item on an array will the total number of items - 1. So if an array has 10 items, the last 10th item is in 9th position.

In C#, arrays can be declared as fixed-length or dynamic. A fixed-length array can store a predefined number of items. A dynamic array does not have a predefined size. The size of a dynamic array increases as you add new items to the array. You can declare an array of fixed length or dynamic. You can even change a dynamic array to static after it is defined.

Let's take a look at simple declarations of arrays in C#. The following code snippet defines the simplest dynamic array of integer types that do not have a fixed size.

int[] intArray;
C#
As you can see from the above code snippet, the declaration of an array starts with a type of array followed by a square bracket ([]) and the name of the array.

The following code snippet declares an array that can store 5 items only starting from index 0 to 4. 

int[] intArray;
intArray = new int[5];
C#
The following code snippet declares an array that can store 100 items starting from index 0 to 99. 

int[] intArray;
intArray = new int[100];
C#
Arrays types in C#
In the previous code snippet, we saw how to define a simple array of integer type. Similarly, we can define arrays of any type such as double, character, and string.

In C#, arrays are objects. That means that declaring an array doesn't create an array. After declaring an array, you need to instantiate an array by using the "new" operator.

The following code snippet defines arrays of double, char, bool, and string data types. 

double[] doubleArray = new double[5];
char[] charArray = new char[5];
bool[] boolArray = new bool[2];
string[] stringArray = new string[10];
C#
Initializing Array in C#
Once an array is declared, the next step is to initialize an array. The initialization process of an array includes adding actual data to the array.

The following code snippet creates an array of 3 items and values of these items are added when the array is initialized. 

// Initialize a fixed array
int[] staticIntArray = new int[3] {1, 3, 5};
C#
Alternative, we can also add array items one at a time as listed in the following code snippet.

// Initialize a fixed array one item at a time
int[] staticIntArray = new int[3];
staticIntArray[0] = 1;
staticIntArray[1] = 3;
staticIntArray[2] = 5;
C#
The following code snippet declares a dynamic array with string values. 

// Initialize a dynamic array items during declaration
string[] strArray = new string[] { "Mahesh Chand", "Mike Gold", "Raj Beniwal", "Praveen Kumar", "Dinesh Beniwal" };
C#
Accessing Array in C#
We can access an array item by passing the item index in the array. The following code snippet creates an array of three items and displays those items on the console. 

// Initialize a fixed array one item at a time
int[] staticIntArray = new int[3];
staticIntArray[0] = 1;
staticIntArray[1] = 3;
staticIntArray[2] = 5;
// Read array items one by one
Console.WriteLine(staticIntArray[0]);
Console.WriteLine(staticIntArray[1]);
Console.WriteLine(staticIntArray[2]);
C#
This method is useful when you know what item you want to access from an array. If you try to pass an item index greater than the items in array, you will get an error.

Accessing a C# array using a foreach Loop
The foreach control statement (loop) is used to iterate through the items of an array. For example, the following code uses foreach loop to read all items of an array of strings. 

// Initialize a dynamic array items during declaration
string[] strArray = new string[] {
    "Mahesh Chand",
    "Mike Gold",
    "Raj Beniwal",
    "Praveen Kumar",
    "Dinesh Beniwal"
};
// Read array items using foreach loop
foreach(string str in strArray) {
    Console.WriteLine(str);
}
C#
This approach is used when you do not know the exact index of an item in an array and needs to loop through all the items.

Array Types in C#
Arrays can be divided into the following four categories.

Single-dimensional arrays
Multidimensional arrays or rectangular arrays
Jagged arrays
Mixed arrays.
Single Dimension Arrays
Single-dimensional arrays are the simplest form of arrays. These types of arrays are used to store the number of items of a predefined type. All items in a single dimension array are stored contiguously starting from 0 to the size of the array -1.

The following code declares an integer array that can store 3 items. As you can see from the code, first I declare the array using [] bracket and after that, I instantiate the array by calling the new operator.

int[] intArray;
intArray = new int[3];
C#
Array declarations in C# are pretty simple. You put array items in curly braces ({}). If an array is not initialized, its items are automatically initialized to the default initial value for the array type if the array is not initialized at the time it is declared.

The following code declares and initializes an array of three items of integer type.

int[] staticIntArray = new int[3] {1, 3, 5};
C#
The following code declares and initializes an array of 5 string items.

string[] strArray = new string[5] { "Mahesh", "Mike", "Raj", "Praveen", "Dinesh" };
C#
You can even directly assign these values without using the new operator.

string[] strArray = { "Mahesh", "Mike", "Raj", "Praveen", "Dinesh" };
C#
You can initialize a dynamic length array as follows.

string[] strArray = new string[] { "Mahesh", "Mike", "Raj", "Praveen", "Dinesh" };
C#
Multi-Dimensional Arrays in C#
A multi-dimensional array, also known as a rectangular array is an array with more than one dimension. The form of a multi-dimensional array is a matrix.

Declaring a multi-dimensional array

A multi-dimension array is declared as follows:

string[,] mutliDimStringArray;
C#
A multi-dimensional array can be fixed-sized or dynamic sized.

Initializing multi-dimensional arrays

The following code snippet is an example of fixed-sized multi-dimensional arrays that defines two multi dimension arrays with a matrix of 3x2 and 2x2. The first array can store 6 items and second array can store 4 items. Both of these arrays are initialized during the declaration. 

int[,] numbers = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
string[,] names = new string[2, 2] { { "Rosy", "Amy" }, { "Peter", "Albert" } };
C#
Now let's see examples of multi-dimensional dynamic arrays where you are not sure of the number of items of the array. The following code snippet creates two multi-dimensional arrays with no limit.

int[,] numbers = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
string[,] names = new string[,] { { "Rosy", "Amy" }, { "Peter", "Albert" } };
C#
You can also omit the new operator as we did in single dimension arrays. You can assign these values directly without using the new operator. For example:

int[, ] numbers = {
    {
        1,
        2
    },
    {
        3,
        4
    },
    {
        5,
        6
    }
};
string[, ] names = {
    {
        "Rosy",
        "Amy"
    },
    {
        "Peter",
        "Albert"
    }
};
C#
We can also initialize the array items one item at a time. The following code snippet is an example of initializing array items one at a time. 

int[, ] numbers = new int[3, 2];
numbers[0, 0] = 1;
numbers[1, 0] = 2;
numbers[2, 0] = 3;
numbers[0, 1] = 4;
numbers[1, 1] = 5;
numbers[2, 1] = 6;
C#
Accessing multi-dimensional arrays

Multi-dimensional array items are represented in a matrix format and to access its items, we need to specify the matrix dimension. For example, item(1,2) represents an array item in the matrix in the second row and third column.

The following code snippet shows how to access numbers array defined in the above code. 

Console.WriteLine(numbers[0, 0]);
Console.WriteLine(numbers[0, 1]);
Console.WriteLine(numbers[1, 0]);
Console.WriteLine(numbers[1, 1]);
Console.WriteLine(numbers[2, 0]);
Console.WriteLine(numbers[2, 2]);
C#
Jagged Arrays in C#
Jagged arrays are arrays of arrays. The elements of a jagged array are other arrays.

Declaring Jagged Arrays

Declaration of a jagged array involves two brackets. For example, the following code snippet declares a jagged array that has three items of an array.

int[][] intJaggedArray = new int[3][];
C#
The following code snippet declares a jagged array that has two items of an array.

string[][] stringJaggedArray = new string[2][];
C#
Initializing Jagged Arrays

Before a jagged array can be used, its items must be initialized. The following code snippet initializes a jagged array; the first item with an array of integers that has two integers, second item with an array of integers that has 4 integers, and the third item with an array of integers that has 6 integers.

// Initializing jagged arrays
intJaggedArray[0] = new int[2];
intJaggedArray[1] = new int[4];
intJaggedArray[2] = new int[6];
C#
We can also initialize a jagged array's items by providing the values of the array's items. The following code snippet initializes item an array's items directly during the declaration. 

// Initializing jagged arrays
intJaggedArray[0] = new int[2] {
    2,
    12
};
intJaggedArray[1] = new int[4] {
    4,
    14,
    24,
    34
};
intJaggedArray[2] = new int[6] {
    6,
    16,
    26,
    36,
    46,
    56
};
C#
Accessing Jagged Arrays

We can access a jagged array's items individually in the following way:

Console.Write(intJaggedArray3[0][0]);
Console.WriteLine(intJaggedArray3[2][5]);
C#
We can also loop through all of the items of a jagged array. The Length property of an array helps a lot; it gives us the number of items in an array. The following code snippet loops through all of the items of a jagged array and displays them on the screen. 

// Loop through all itesm of a jagged array
for (int i = 0; i < intJaggedArray3.Length; i++) {
    System.Console.Write("Element({0}): ", i);
    for (int j = 0; j < intJaggedArray3[i].Length; j++) {
        System.Console.Write("{0}{1}", intJaggedArray3[i][j], j == (intJaggedArray3[i].Length - 1) ? "" : " ");
    }
    System.Console.WriteLine();
}
C#
Mixed Arrays in C#
Mixed arrays are a combination of multi-dimension arrays and jagged arrays. The mixed arrays type is removed from .NET 4.0. I have not really seen any use of mixed arrays. You can do anything you want with the help of multi-dimensional and jagged arrays.

A Simple Example

Here is a complete example listed in Listing 1 that demonstrates how to declare all kinds of arrays then initialize them and access them.

To test this code, create a console application using Visual Studio 2010 or Visual C# Express and copy and paste this code. 

Console.WriteLine("Single Dimension Array Sample");
// Single dim array
string[] strArray = new string[] {
    "Mahesh Chand",
    "Mike Gold",
    "Raj Beniwal",
    "Praveen Kumar",
    "Dinesh Beniwal"
};
// Read array items using foreach loop
foreach(string str in strArray) {
    Console.WriteLine(str);
}
Console.WriteLine("-----------------------------");
Console.WriteLine("Multi-Dimension Array Sample");
string[, ] string2DArray = new string[2, 2] {
    {
        "Rosy",
        "Amy"
    }, {
        "Peter",
        "Albert"
    }
};
foreach(string str in string2DArray) {
    Console.WriteLine(str);
}
Console.WriteLine("-----------------------------");
Console.WriteLine("Jagged Array Sample");
int[][] intJaggedArray3 = {
    new int[] {
        2,
        12
    },
    new int[] {
        14,
        14,
        24,
        34
    },
    new int[] {
        6,
        16,
        26,
        36,
        46,
        56
    }
};
// Loop through all itesm of a jagged array
for (int i = 0; i < intJaggedArray3.Length; i++) {
    Console.Write($"Element({i}): ");
    for (int j = 0; j < intJaggedArray3[i].Length; j++) {
        Console.Write($"{intJaggedArray3[i][j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("-----------------------------");
C#
Listing 1

The output of Listing 1 looks like Figure 1. 

C# Array
Figure 1

C# Array Class
Array class in C# is the mother of all arrays and provides functionality for creating, manipulating, searching, and sorting arrays in .NET Framework.

Array class, defined in the System namespace, is the base class for arrays in C#. Array class is an abstract base class that means we cannot create an instance of the Array class.

Creating an Array

Array class provides the CreateInstance method to construct an array. The CreateInstance method takes the first parameter as the type of items and the second and third parameters are the dimension and their range. Once an array is created, we use the SetValue method to add items to an array.

The following code snippet creates an array and adds three items to the array. As you can see the type of the array items is a string and the range is 3. You will get an error message if you try to add 4th item to the array. 

Array stringArray = Array.CreateInstance(typeof(String), 3);
stringArray.SetValue("Mahesh Chand", 0);
stringArray.SetValue("Raj Kumar", 1);
stringArray.SetValue("Neel Beniwal", 2);
C#
Note: Calling SetValue on an existing item of an array overrides the previous item value with the new value.

The code snippet in Listing 2 creates a multi-dimensional array. 

Array intArray3D = Array.CreateInstance(typeof(Int32), 2, 3, 4);
for (int i = intArray3D.GetLowerBound(0); i <= intArray3D.GetUpperBound(0); i++)
    for (int j = intArray3D.GetLowerBound(1); j <= intArray3D.GetUpperBound(1); j++)
        for (int k = intArray3D.GetLowerBound(2); k <= intArray3D.GetUpperBound(2); k++) {
            intArray3D.SetValue((i * 100) + (j * 10) + k, i, j, k);
        }
foreach(int ival in intArray3D) {
    Console.WriteLine(ival);
}
C#
Listing 2

C# Array Properties

Table 1 describes Array class properties.

IsFixedSize	Return a value indicating if an array has a fixed size or not.
IsReadOnly	Returns a value indicating if an array is read-only or not.
LongLength	Returns a 64-bit integer that represents a total number of items in all the dimensions of an array.
Length	Returns a 32-bit integer that represents the total number of items in all the dimensions of an array.
Rank	Returns the number of dimensions of an array.
Table 1

The code snippet in Listing 3 creates an array and uses Array properties to display property values. 

int[] intArray = new int[3] {
    0,
    1,
    2
};
if (intArray.IsFixedSize) {
    Console.WriteLine("Array is fixed size");
    Console.WriteLine($"Size : {intArray.Length.ToString()}");
    Console.WriteLine($"Rank : {intArray.Rank.ToString()}");
}
C#
Listing 3

The output of Listing looks like Figure 2.

C# array properties
Figure 2

Searching for an Item in an Array in C#
The BinarySearch static method of the Array class can be used to search for an item in an array. This method uses the binary search algorithm to search for an item. The method takes at least two parameters. The first parameter is the array in which you would like to search and a second parameter is an object that is the item you are looking for. If an item is found in the array, the method returns the index of that item (based on the first item as 0th item). Otherwise, the method returns a negative value. 

Note
You must sort an array before searching. See the comments in this article.

Listing 4 uses the BinarySearch method to search an array for a string. 

// Create an array and add 5 items to it
Array stringArray = Array.CreateInstance(typeof(String), 5);
stringArray.SetValue("Mahesh", 0);
stringArray.SetValue("Raj", 1);
stringArray.SetValue("Neel", 2);
stringArray.SetValue("Beniwal", 3);
stringArray.SetValue("Chand", 4);
// Find an item
object name = "Neel";
int nameIndex = Array.BinarySearch(stringArray, name);
if (nameIndex >= 0) Console.WriteLine($"Item was at {nameIndex.ToString()}th position");
else Console.WriteLine("Item not found");
C#
Listing 4

Sorting Items in an Array in C#
The Sort static method of the Array class can be used to sort array items. This method has many overloaded forms. The simplest form takes as a parameter the array you want to sort. Listing 5 uses the Sort method to sort array items. Using the Sort method, you can also sort a partial list of items. 

// Create an array and add 5 items to it
Array stringArray = Array.CreateInstance(typeof(String), 5);
stringArray.SetValue("Mahesh", 0);
stringArray.SetValue("Raj", 1);
stringArray.SetValue("Neel", 2);
stringArray.SetValue("Beniwal", 3);
stringArray.SetValue("Chand", 4);
// Find an item
object name = "Neel";
int nameIndex = Array.BinarySearch(stringArray, name);
if (nameIndex >= 0) Console.WriteLine($"Item was at {nameIndex.ToString()}th position");
else Console.WriteLine("Item not found");
Console.WriteLine();
Console.WriteLine("Original Array");
Console.WriteLine("---------------------");
foreach (string str in stringArray)
{
    Console.WriteLine(str);
}
Console.WriteLine();
Console.WriteLine("Sorted Array");
Console.WriteLine("---------------------");
Array.Sort(stringArray);
foreach (string str in stringArray)
{
    Console.WriteLine(str);
}
C#
Listing 5

The output of Listing 5 looks like Figure 3.

sort array in C#
Figure 3

Alternatively, the Sort method takes the starting index and number of items after that index. The following code snippet sorts 3 items starting at 2nd position.

Array.Sort(stringArray, 2, 3);
C#
The new output looks like Figure 4.

sort array in C#
Figure 4

Getting and Setting Values

The GetValue and SetValue methods of the Array class can be used to get and set values of an array's items. The code listed in Listing 4 creates a 2-dimensional array instance using the CreateInstance method. After that, I use the SetValue method to add values to the array.

In the end, I find a number of items in both dimensions and use GetValue method to read values and display on the console. 

Array names = Array.CreateInstance(typeof(String), 2, 4);
names.SetValue("Rosy", 0, 0);
names.SetValue("Amy", 0, 1);
names.SetValue("Peter", 0, 2);
names.SetValue("Albert", 0, 3);
names.SetValue("Mel", 1, 0);
names.SetValue("Mongee", 1, 1);
names.SetValue("Luma", 1, 2);
names.SetValue("Lara", 1, 3);
int items1 = names.GetLength(0);
int items2 = names.GetLength(1);
for (int i = 0; i < items1; i++)
    for (int j = 0; j < items2; j++)
        Console.WriteLine($"{i.ToString()},{j.ToString()}: {names.GetValue(i, j)}");
C#
Listing 6

The output of Listing 6 generates Figure 5.

GetValue SetValue
Figure 5

Reverse an array items in C#
The Reverse static method of the Array class reverses the order of items in an array. Similar to the Sort method, you can just pass an array as a parameter of the Reverse method. 

Array stringArray = Array.CreateInstance(typeof(String), 5);
stringArray.SetValue("Mahesh", 0);
stringArray.SetValue("Raj", 1);
stringArray.SetValue("Neel", 2);
stringArray.SetValue("Beniwal", 3);
stringArray.SetValue("Chand", 4);
Console.WriteLine("Original Array");
Console.WriteLine("---------------------");
foreach(string str in stringArray) {
    Console.WriteLine(str);
}
Console.WriteLine();
Console.WriteLine("Reversed Array");
Console.WriteLine("---------------------");
Array.Reverse(stringArray);
// Array.Sort(stringArray, 2, 3);
foreach(string str in stringArray) {
    Console.WriteLine(str);
}
Console.WriteLine();
Console.WriteLine("Double Reversed Array");
Console.WriteLine("---------------------");
Array.Reverse(stringArray);
// Array.Sort(stringArray, 2, 3);
foreach(string str in stringArray) {
    Console.WriteLine(str);
}
C#
Listing 7

The output of Listing 7 generates Figure 6.

reverse array in c#
Figure 6

Clear an array items in C#
The Clear static method of the Array class removes all items of an array and sets its length to zero. This method takes three parameters - first an array object, second starting index of the array and third is the number of elements. The following code clears two elements from the array starting at index 1 (means the second element of the array).

Array.Clear(stringArray, 1, 2);
C#
Note
Keep in mind, the Clear method does not delete items. Just clear the values of the items.

The code listed in Listing 8 clears two items from the index 1. 

Array stringArray = Array.CreateInstance(typeof(String), 5);
stringArray.SetValue("Mahesh", 0);
stringArray.SetValue("Raj", 1);
stringArray.SetValue("Neel", 2);
stringArray.SetValue("Beniwal", 3);
stringArray.SetValue("Chand", 4);
Console.WriteLine("Original Array");
Console.WriteLine("---------------------");
foreach(string str in stringArray) {
    Console.WriteLine(str);
}
Console.WriteLine();
Console.WriteLine("Clear Items");
Console.WriteLine("---------------------");
Array.Clear(stringArray, 1, 2);
foreach(string str in stringArray) {
    Console.WriteLine(str);
}
C#
Listing 8

The output of Listing 8 generates Figure 7. As you can see from Figure 7, the values of two items from the output are missing but actual items are there.

Clear array in C#
Figure 7

Get the size of an array in C#
The GetLength method returns the number of items in an array. The GetLowerBound and GetUppperBound methods return the lower and upper bounds of an array respectively. All these three methods take at least a parameter, which is the index of the dimension of an array. The following code snippet uses all three methods. 

Console.WriteLine(stringArray.GetLength(0).ToString());
Console.WriteLine(stringArray.GetLowerBound(0).ToString());
Console.WriteLine(stringArray.GetUpperBound(0).ToString());
C#
Copy an array in C#
The Copy static method of the Array class copies a section of an array to another array. The CopyTo method copies all the elements of an array to another one-dimension array. The code listed in Listing 9 copies contents of an integer array to an array of object types. 

// Creates and initializes a new Array of type Int32.
Array oddArray = Array.CreateInstance(Type.GetType("System.Int32"), 5);
oddArray.SetValue(1, 0);
oddArray.SetValue(3, 1);
oddArray.SetValue(5, 2);
oddArray.SetValue(7, 3);
oddArray.SetValue(9, 4);
// Creates and initializes a new Array of type Object.
Array objArray = Array.CreateInstance(Type.GetType("System.Object"), 5);
Array.Copy(oddArray, oddArray.GetLowerBound(0), objArray, objArray.GetLowerBound(0), 4);
int items1 = objArray.GetUpperBound(0);
for (int i = 0; i < items1; i++) Console.WriteLine(objArray.GetValue(i).ToString());
C#
Listing 9

You can even copy a part of an array to another array bypassing the number of items and starting item in the Copy method. The following format copies a range of items from an Array starting at the specified source index and pastes them to another Array starting at the specified destination index.

public static void Copy(Array, int, Array, int, int);
C#
Clone an Array in C#
Clone method creates a shallow copy of an array. A shallow copy of an Array copies only the elements of the Array, whether they are reference types or value types, but it does not copy the objects that the references refer to. The references in the new Array point to the same objects that the references in the original Array point to.

The following code snippet creates a cloned copy of an array of strings.

string[] clonedArray = (string[])stringArray.Clone();
C#
Summary
In this article, you learned the basics of arrays and how to use them C#. At the beginning of this article, we discussed different types of arrays such as single dimension, multi-dimension, and jagged arrays. After that, we discussed the Array class. At the end of this article, we saw how to work with arrays using different methods and properties of the Array class.