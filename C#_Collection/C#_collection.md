# C# Collection

Collection classes are specialized classes for data storage and retrieval. 

These classes provide support for stacks, queues, lists, and hash tables.

Most collection classes implement the same interfaces.

Collection classes serve various purposes, such as allocating memory dynamically to elements and accessing a list of items on the basis of an index etc. 

These classes create collections of objects of the Object class, which is the base class for all data types in C#.

various commonly used classes of the System.Collection namespace.


# ArrayList

It represents ordered collection of an object that can be indexed individually.
It is basically an alternative to an array.
However, unlike array you can add and remove items from a list at a specified position using an index and the array resizes itself automatically. 
It also allows dynamic memory allocation, adding, searching and sorting items in the list.

# Hashtable
It uses a key to access the elements in the collection.
A hash table is used when you need to access elements by using key, and you can identify a useful key value.
Each item in the hash table has a key/value pair. 
The key is used to access the items in the collection.

# SortedList
It uses a key as well as an index to access the items in a list.
A sorted list is a combination of an array and a hash table. 
It contains a list of items that can be accessed using a key or an index. 
If you access items using an index, it is an ArrayList, and if you access items using a key , it is a Hashtable.
The collection of items is always sorted by the key value.

C# SortedSet<T>

C# SortedSet class can be used to store, remove or view elements.
It maintains ascending order and does not store duplicate elements. 
It is suggested to use SortedSet class if you have to store unique elements and maintain ascending order. 
It is found in System.Collections.Generic namespace.

# Stack
It represents a last-in, first out collection of object.
It is used when you need a last-in, first-out access of items. 
When you add an item in the list, it is called pushing the item and when you remove it, it is called popping the item.

C# Stack<T>
C# Stack<T> class is used to push and pop elements.
 It uses the concept of Stack that arranges elements in LIFO (Last In First Out) order.
 It can have duplicate elements. It is found in System.Collections.Generic namespace.
# Queue
It represents a first-in, first out collection of object.
It is used when you need a first-in, first-out access of items. 
When you add an item in the list, it is called enqueue and when you remove an item, it is called deque.


C# Queue<T>
C# Queue<T> class is used to Enqueue and Dequeue elements. 
It uses the concept of Queue that arranges elements in FIFO (First In First Out) order.
It can have duplicate elements.
It is found in System.Collections.Generic namespace
 
#LinkedList 
C# LinkedList<T>
C# LinkedList<T> class uses the concept of linked list. It allows us to insert and delete elements fastly. It can have duplicate elements. It is found in System.Collections.Generic namespace.

It allows us to add and remove element at before or last index. 
# BitArray
It represents an array of the binary representation using the values 1 and 0.
It is used when you need to store the bits but do not know the number of bits in advance. 
You can access items from the BitArray collection by using an integer index, which starts from zero.

# C# Dictionary<TKey, TValue>
C# Dictionary<TKey, TValue> class uses the concept of hashtable.
It stores values on the basis of key. 
It contains unique keys only. By the help of key, we can easily search or remove elements. 
It is found in System.Collections.Generic namespace.
# C# SortedDictionary<TKey, TValue>
C# SortedDictionary<TKey, TValue> class uses the concept of hashtable. 
It stores values on the basis of key. 
It contains unique keys and maintains ascending order on the basis of key. 
By the help of key, we can easily search or remove elements. 
It is found in System.Collections.Generic namespace.

# C# SortedList<TKey, TValue>
C# SortedList<TKey, TValue> is an array of key/value pairs. 
It stores values on the basis of key. 
The SortedList<TKey, TValue> class contains unique keys and maintains ascending order on the basis of key. 
By the help of key, we can easily search or remove elements.
It is found in System.Collections.Generic namespace.

It is like SortedDictionary<TKey, TValue> class.
In C#, collection represents group of objects.
By the help of collections, we can perform various operations on objects such as

store object
update object
delete object
retrieve object
search object, and
sort object
In sort, all the data structure work can be performed by C# collections.

We can store objects in array or collection. Collection has advantage over array. 
Array has size limit but objects stored in collection can grow or shrink dynamically.

# Types of Collections in C#
There are 3 ways to work with collections. The three namespaces are given below:
System.Collections.Generic classes
System.Collections classes (Now deprecated)
System.Collections.Concurrent classes


1) System.Collections.Generic classes
The System.Collections.Generic namespace has following classes:

List
Stack
Queue
LinkedList
HashSet
SortedSet
Dictionary
SortedDictionary
SortedList

2) System.Collections classes
These classes are legacy. It is suggested now to use System.Collections.Generic classes. 
The System.Collections namespace has following classes:

ArrayList
Stack
Queue
Hashtable
3) System.Collections.Concurrent classes
The System.Collections.Concurrent namespace provides classes for thread-safe operations.
 Now multiple threads will not create problem for accessing the collection items.

C# HashSet<T>
C# HashSet class can be used to store, remove or view elements.
It does not store duplicate elements. 
It is suggested to use HashSet class if you have to store only unique elements.
It is found in System.Collections.Generic namespace.

The System.Collections.Concurrent namespace has following classes:

BlockingCollection
ConcurrentBag
ConcurrentStack
ConcurrentQueue
ConcurrentDictionary
Partitioner
Partitioner
OrderablePartitioner