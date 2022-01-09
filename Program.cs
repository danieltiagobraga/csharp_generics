using System;
/*
    In C#, generic means not specific to a particular data type.

    C# allows you to define the following generics: 
        classes 
        interfaces 
        abstract classes
        fields
        methods
        static methods
        properties
        events
        delegates
        operators 
        
    To do so, we need to use the type parameter without specific any data type. 
    
    A type parameter is a placeholder for a particular type specified when creating an instance of the generic type.

    A generic type is declared by specifying a type parameter in an angle brackets after a type name, e.g. TypeName<T> where T is a type parameter.



    Advantages of Generics:

        1. Generics increase the reusability of the code. You don't need to write code to handle different data types.

        2. Generics are type-safe. You get compile-time errors if you try to use a different data type than the one specified in the definition.

        3. Generic has a performance advantage because it removes the possibilities of boxing and unboxing.

    

    C# Generic Constraints

    C# allows you to use constraints to restrict client code to specify certain types while instantiating generic types. 
    
    It will give a compile-time error if you try to instantiate a generic type using a type that is not allowed by the specified constraints.

    You can specify one or more constraints on the generic type using the where clause after the generic type name.

    Ex: GenericTypeName<T> where T  : contraint1, constraint2
*/
namespace csharp_generics
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
