C# operators are the symbols which are used for different operations like mathematical expressions, function call etc.

There are different kind of operators. They are:

Assignment operators
Arithmetic operators
Conditional operators
Unary operators
Increment & Decrement operators
Relational operators
Logical operators
Assignment operator:

“=” is called the assignment operator. “=” assigns the variable in the left of it with the value on the right of it. In other words, it provides the data on its R.H.S. to the variable in its L.H.S.

Example:

X=9;

Here, the operator”=” assigns value 9 to x.

Arithmetic operator:

Arithmetic operator is used for mathematical operations. There are 5 types of arithmetic operators. They are:

+ : This operator is called additional operator. It is used for the addition of two pieces of data.

Example: z=x+y;

Here z will result in addition of two variables x & y.

- : This operator is called subtraction operator. It is used for the difference of tw pieces of data.

Example: z=x-y;

Here z will result in difference of two variables x & y.
* : This operator is called multiplication operator. It is used for product of two data.

Example: z=x*y;

Here z will result in product of two variables x & y.

/ : This operator is called division operator. It is used for the division of two data.

Example: z=x/y;

Here z will result in a quotient for the division of two variables x & y.

% : This operator is called modulus operator. It is used for finding the remainder after dividing one data from another.

Example: z=x%y;

Here z will result inthe remainder after the division of two variables x & y.
Conditional operator:

Conditional operators are the operators used to check a condition. The types of conditional operators are:

“ ? : ” is called ternary operator. This is used instead of if else statement. It avoids long writing of code for if else statements if the if else is statement is of one statement only like:
If(something) {  
    Do something;  
}  
Else() {  
    Do something  
    else;  
}  
Then instead of writing this much longer code we can write:

Result= x?y:z;

This means that if the input is x then result in y else result in z.

“ &&” is also called logical AND. If the first operand is false, then C# does not evaluate the second operand. It will operate only when both the operands are true.

Example:

X&&y

Here, it is checked whether both the operands are true or not.

“||” is also called logical OR. If the first operand is true, then C# does not evaluate the second operand. It will operate if any of the operands is true.

Example:

X||y

Here, it is checked whether any of the operands are true or not.

“??“ is also called Null coalescing operator. This returns the value on its left if it is non-null; otherwise, returns the value on right of it.

Example:

X??y

Here, this returns x if it is non-null; otherwise, returns y.
Unary operator:

Unary operators work on a single operand. The types of unary operators are:

+x – It returns the positive value of x.
-x – It does the numeric negation of x.
!x – It does the logical negation of x.
~x – It is used for bitwise complement of x.
Increment & decrement operator:

Increment & decrement operators are used for incrementing & decrementing the count of data by:

++x : It is also called prefix increment. It returns the value of x after updating the storage location with the value of x that is one greater (typically adds the integer 1).

--x: It is also called prefix decrement. It returns the value of x after updating the storage location with the value of x that is one less (typically adds the integer 1).
Relational operator:

Relational operators are used for establishing relationship between two different data. The types of relational operators are:

> : This symbol is used when the data on the left of it is greater than the data on its right.

Example:

x>y;

Here, the relation says that the value of x is greater than the value of y.

< : This symbol is used when the data on the left of it is smaller than the data on its right.

Example:

X<y;

Here, the relation says that the value of x is smaller than the value of y.

>= : This symbol is used when the data on the left of it is greater or equal to than the data on its right.

Example:

x>=y;

Here, the relation says that the value of x is greater than or equal to the value of y.

<= : This symbol is used when the data on the left of it is smaller than or equal to the data on its right.

Example:

x<=y;

Here, the relation says that the value of x is smaller than or equal to the value of y.

== : This symbol is used when the data on the left of it is equal to the data on its right.

Example:

X==y;

Here, the relation says that the value of x is equal to the value of y.

!= : This symbol is used when the data on the left of it is not equal to the data on its right.

Example:

X!=y;

Here, the relation says that the value of x is not equal to the value of y.
Logical operator:

Logical operators are used to do logical operations. The types of logical operators are:

x & y : It is also called logical or bitwise AND. It is used with integer types and generally allowed with enum types for doing the logical & operations.

x ^ y : It is also called logical or bitwise XOR. We can generally use this with integer types and enum types for doing the logical XOR operations.

x | y : I*t is also called logical or bitwise OR. It is used with integer types and enum types for doing logical OR operations.