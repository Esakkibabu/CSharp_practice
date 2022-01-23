// C# preprocessor
#define PI 
using System;
namespace PreprocessorDAppl {
   class Program {
      static void Main(string[] args) {
          Console.WriteLine("OUTPUT:");
         #if (PI)
            Console.WriteLine("PI is defined");
         #else
            Console.WriteLine("PI is not defined");
         #endif
         Console.ReadKey();
      }
   }
}
/*
OUTPUT:
PI is defined
*/