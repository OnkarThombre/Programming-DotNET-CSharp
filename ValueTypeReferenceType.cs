//Program to Demonstrate the Difference between Value Type Parameter and Reference Type Parameter

using System;

namespace ValueTypeReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("Initial value of a: " + a);
            valueType(a);
            Console.WriteLine("After ChangeValue(a): " + a); // Still 10

            // Pass by reference
            referenceType(ref a);
            Console.WriteLine("After ChangeReference(ref a): " + a); // Now 100
        }
        static void valueType(int a)
        {
            a = 10000;
        }

        static void referenceType(ref int a)
        {
            a = 500; 
        }
    }
}

// value type parameter
//Console.WriteLine(a);
/*
 * value type
 * Int16
 * Int32
 * Int64
 * Single
 * Double
 * Boolean
 * char
 * /


/*Reference type
 * class
 * interface
 * Array
 * delegate
 * Object
 */
