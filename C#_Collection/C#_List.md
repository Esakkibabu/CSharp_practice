#C# List
C# List class represents a collection of strongly typed objects that can be accessed by index.
In this tutorial, we learn how to work with lists in C# using C# List class to add, find, sort, reverse, and search items in a collection of objects using List class methods and properties.

# What is C# List?
List<T> class in C# represents a strongly typed list of objects.
 List<T> provides functionality to create a list of objects, find list items, sort list, search list, and manipulate list items. 
In List<T>, T is the type of objects.

# What is the ‘T’ in List<T>? 
List<T> class in represents a strongly typed list of objects.
List<T> provides functionality to create a list of objects, find list items, sort list, search list, and manipulate list items. 
In List<T>, T is the type of objects. 

# How to create List in C#?
List is a generic class and is defined in the System.Collections.Generic namespace. 
You must import this namespace in your project to access the List<T> class.
using System.Collections.Generic;
C#
Copy
List<T> class constructor is used to create a List object of type T. 

It can either be empty or take an Integer value as an argument that defines the initial size of the list, also known as capacity.
If there is no integer passed in the constructor, the size of the list is dynamic and grows every time an item is added to the array. 
You can also pass an initial collection of elements when initialize an object. 
The code snippet in Listing 1 creates a List of Int16 and a list of string types. 
The last part of the code creates a List<T> object with an existing collection.

// List with default capacity
List<Int16> list = new List<Int16>();
// List with capacity = 5
List<string> authors = new List<string>(5);
string[] animals = { "Cow", "Camel", "Elephant" };
List<string> animalsList = new List<string>(animals);

C#
Copy
Listing 1.
As you can see from Listing 1, the List<string> has an initial capacity set to 5 only. 
However, when more than 5 elements are added to the list, it automatically expands. 

# How to add items to a C# List?
The Add method adds an element to a List. 
The code snippet in Listing 2 creates two List<T> objects and adds integer and string items to them respectively.
// Dynamic ArrayList with no size limit
List<int> numberList = new List<int>();
numberList.Add(32);
numberList.Add(21);
numberList.Add(45);
numberList.Add(11);
numberList.Add(89);

// List of string
List<string> authors = new List<string>(5);
authors.Add("Mahesh Chand");
authors.Add("Chris Love");
authors.Add("Allen O'neill");
authors.Add("Naveen Sharma");
authors.Add("Monica Rathbun");
authors.Add("David McCarter");

C#
Copy
Listing 2.
We can also add a collection to a List.
The AddRange method is used to add a collection to a List. 
The code snippet in Listing 3 adds an array of strings to a List.
// Collection of string
string[] animals = { "Cow", "Camel", "Elephant" };
// Create a List and add a collection
List<string> animalsList = new List<string>();
animalsList.AddRange(animals);
foreach (string a in animalsList)
Console.WriteLine(a);

C#
Copy
Listing 3.

# How to read a C# List items?
List is a collection of items. We can use a foreach loop to loop through its items. The code snippet in Listing 6 reads all items of a List and displays on the console.
foreach (string a in authors)
Console.WriteLine(a);
C#
Copy
Listing 4. 
The output of Listing 4 looks like Figure 1. 
 
Figure 1. 
To retrieve an item at a specific position in the List, we can use the collection’s index. 
The following code snippet reads the 3rd items in the List.
Console.WriteLine(authors[2]);
C#
Copy

# How to use C# List properties 
List class properties include the following:
•	Capacity – Number of elements List<T> can contain. The default capacity of a List<T> is 0.
•	Count – Number of elements in List<T>.
Code snippet in Listing 5 gets the value of these properties.
ArrayList authorsArray = new ArrayList();
authorsArray.Add("Mahesh Chand");
authorsArray.Add("Praveen Kumar");
authorsArray.Add("Raj Kumar");
authorsArray.Add("Dinesh Beniwal");
authorsArray.Add("David McCarter");
Console.WriteLine("Count: " + authors.Count);
Console.WriteLine("Capacity: " + authors.Capacity);
C#
Copy
Listing 5.
How to insert elements at a position in a C# List? 
The Insert method of List class inserts an object at a given position.
 The first parameter of the method is the 0th based index in the List.
The InsertRange method can insert a collection at the given position. 
The code snippet in Listing 6 inserts a string at the 3rd position and an array at the 2nd position of the List<T>.
authors.Insert(3, "Bill Author");
// Collection of new authors
string[] newAuthors = { "New Author1", "New Author2", "New Author3" };
// Insert array at position 2
authors.InsertRange(2, newAuthors);
C#
Copy
Listing 6.
How to remove items from a C# List?
The List class provides Remove methods that can be used to remove an item or a range of items. 
The Remove method removes the first occurrence of the given item in the List. 
The following code snippet removes the first occurrence of ‘New Author1’.
// Remove an item
authors.Remove("New Author1");
C#
Copy
The RemoveAt method removes an item at the given position. 
The following code snippet removes the item at the 3rd position.
// Remove 3rd item
authors.RemoveAt(3);
C#
Copy
The RemoveRange method removes a list of items from the starting index to the number of items. The following code snippet removes two items starting at 3rd position.
// Remove a range
authors.RemoveRange(3, 2);
C#
Copy
The Clear method removes all items from a List<T>. The following code snippet removes all items from a List.
// Remove all items
authors.Clear();
C#
Copy
How to find an element in a C# List?
The IndexOf method finds an item in a List. The IndexOf method returns -1 if there are no items found in the List. 
The following code snippet finds a string and returns the matched position of the item.
int idx = authors.IndexOf("Naveen Sharma");
if (idx > 0)
Console.WriteLine($"Item index in List is: {idx}");
else
Console.WriteLine("Item not found");
C#
Copy
We can also specify the position in a List where IndexOf method can start searching from. 
For example, the following code snippet finds a string starting at the 3rd position in a String.
Console.WriteLine(authors.IndexOf("Naveen Sharma", 2));
C#
Copy
The LastIndexOf method finds an item from the end of List. 
The following code snippet looks for a string in the backward direction and returns the index of the item if found.
Console.WriteLine(authors.LastIndexOf("Mahesh Chand"));
C#
Copy
The complete example is listed in Listing 7.
// List of string
List<string> authors = new List<string>(5);
authors.Add("Mahesh Chand");
authors.Add("Chris Love");
authors.Add("Allen O'neill");
authors.Add("Naveen Sharma");
authors.Add("Mahesh Chand");
authors.Add("Monica Rathbun");
authors.Add("David McCarter");
int idx = authors.IndexOf("Naveen Sharma");
if (idx > 0)
Console.WriteLine($"Item index in List is: {idx}");
else
Console.WriteLine("Item not found");
Console.WriteLine(authors.IndexOf("Naveen Sharma", 2));
Console.WriteLine(authors.LastIndexOf("Mahesh Chand"));
C#
Copy
Listing 7.  
How to sort a C# List elements? 
The Sort method of List<T> sorts all items of the List using the QuickSort algorithm. 
The following code example in Listing 8 sorts a List items and displays both original order and sorted order of the List items.
// List of string
List<string> authors = new List<string>(5);
authors.Add("Mahesh Chand");
authors.Add("Chris Love");
authors.Add("Allen O'neill");
authors.Add("Naveen Sharma");
authors.Add("Mahesh Chand");
authors.Add("Monica Rathbun");
authors.Add("David McCarter");
Console.WriteLine("Original List items");
Console.WriteLine("===============");
// Print original order
foreach (string a in authors)
Console.WriteLine(a);
// Sort list items
authors.Sort();
Console.WriteLine();
Console.WriteLine("Sorted List items");
Console.WriteLine("===============");
// Print sorted items
foreach (string a in authors)
Console.WriteLine(a);
C#
Copy
Listing 8. 
The output of Listing 8 looks like Figure 2. 
  
Figure 2. 
How to reverse a C# List elements? 
The Reverse method of List<T> reverses the order all items in in the List. 
The following code snippet reverses a List. 
// List of string
List<string> authors = new List<string>(5);
authors.Add("Mahesh Chand");
authors.Add("Chris Love");
authors.Add("Allen O'neill");
authors.Add("Naveen Sharma");
authors.Add("Mahesh Chand");
authors.Add("Monica Rathbun");
authors.Add("David McCarter");
Console.WriteLine("Original List items");
Console.WriteLine("===============");
// Print original order
foreach (string a in authors)
Console.WriteLine(a);
// Reverse list items
authors.Reverse();
Console.WriteLine();
Console.WriteLine("Sorted List items");
Console.WriteLine("===============");
// Print reversed items
foreach (string a in authors)
Console.WriteLine(a);
C#
Copy
Listing 9. 
The output of Listing 9 looks like Figure 3. 
  
Figure 3. 
How to search a C# List elements?
The BinarySearch method of List<T> searches a sorted list and returns the zero-based index of the found item. The List<T> must be sorted before this method can be used. 
The following code snippet returns an index of a string in a List.
int bs = authors.BinarySearch("Mahesh Chand");
C#
Copy
How to import add element in a List from another List? 
You can use the AddRange method of List to import items of one list into another list. 

But make sure the item types are same in both lists. 
The following code snippet creates two List objects and copies all items of listTwo into listOne.
// Program: Copy items from one list to another list
Console.WriteLine("Import one list to another!");

// Create List1
List<string> listOne = new();
listOne.Add("One");
listOne.Add("Two");
listOne.Add("Three");
listOne.Add("Four");
listOne.Add("Five");

// Create List2
List<string> listTwo = new();
listTwo.Add("A");
listTwo.Add("B");
listTwo.Add("C");

// Add List2 to List1
listOne.AddRange(listTwo);

// Display
foreach(string item in listOne)
    Console.WriteLine(item);

Console.ReadKey();
C#
Copy
Summary 
This article demonstrated how to use a List<T> class to work with a collection of objects. 
The article also demonstrated how to add, find, search, sort, and reverse items in a List. 

