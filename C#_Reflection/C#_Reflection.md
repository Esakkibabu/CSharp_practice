C# Reflection
In C#, reflection is a process to get metadata of a type at runtime. The System.Reflection namespace contains required classes for reflection such as:

Type
MemberInfo
ConstructorInfo
MethodInfo
FieldInfo
PropertyInfo
TypeInfo
EventInfo
Module
Assembly
AssemblyName
Pointer etc.
The System.Reflection.Emit namespace contains classes to emit metadata.

C# Type class
C# Type class represents type declarations for class types, interface types, enumeration types, array types, value types etc. It is found in System namespace. It inherits System.Reflection.MemberInfo class.

C# Type Properties
A list of important properties of Type class are given below:



Property	Description
Assembly	Gets the Assembly for this type.
AssemblyQualifiedName	Gets the Assembly qualified name for this type.
Attributes	Gets the Attributes associated with the type.
BaseType	Gets the base or parent type.
FullName	Gets the fully qualified name of the type.
IsAbstract	is used to check if the type is Abstract.
IsArray	is used to check if the type is Array.
IsClass	is used to check if the type is Class.
IsEnum	is used to check if the type is Enum.
IsInterface	is used to check if the type is Interface.
IsNested	is used to check if the type is Nested.
IsPrimitive	is used to check if the type is Primitive.
IsPointer	is used to check if the type is Pointer.
IsNotPublic	is used to check if the type is not Public.
IsPublic	is used to check if the type is Public.
IsSealed	is used to check if the type is Sealed.
IsSerializable	is used to check if the type is Serializable.
MemberType	is used to check if the type is Member type of Nested type.
Module	Gets the module of the type.
Name	Gets the name of the type.
Namespace	Gets the namespace of the type.
C# Type Methods
A list of important methods of Type class are given below:

Method	Description
GetConstructors()	Returns all the public constructors for the Type.
GetConstructors(BindingFlags)	Returns all the constructors for the Type with specified BindingFlags.
GetFields()	Returns all the public fields for the Type.
GetFields(BindingFlags)	Returns all the public constructors for the Type with specified BindingFlags.
GetMembers()	Returns all the public members for the Type.
GetMembers(BindingFlags)	Returns all the members for the Type with specified BindingFlags.
GetMethods()	Returns all the public methods for the Type.
GetMethods(BindingFlags)	Returns all the methods for the Type with specified BindingFlags.
GetProperties()	Returns all the public properties for the Type.
GetProperties(BindingFlags)	Returns all the properties for the Type with specified BindingFlags.
GetType()	Gets the current Type.
GetType(String)	Gets the Type for the given name.