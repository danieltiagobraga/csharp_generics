
using System.Collections;

namespace GENERIC_CONSTRAINTS
{
    /*
        Class contraint

        It means the type argument must be any class, interface, delegate, or array type.

        Examples:
        DataStore1<string> store = new DataStore1<string>();              // valid
        DataStore1<MyClass> store = new DataStore1<MyClass>();            // valid
        DataStore1<IMyInterface> store = new DataStore1<IMyInterface>();  // valid
        DataStore1<IEnumerable> store = new DataStore1<IMyInterface>();   // valid
        DataStore1<ArrayList> store = new DataStore1<ArrayList>();        // valid
        //DataStore1<int> store = new DataStore1<int>();                  // compile-time error 
    */ 
    class DataStore1<T> where T : class
    {
        public T Data { get; set; }
    }

    /*
        Struct Constraint

        It means the type argument must be non-nullable value types such as primitive data types int, char, bool, float, etc.

        Examples:
        DataStore2<int> store = new DataStore2<int>();                        // valid
        DataStore2<char> store = new DataStore2<char>();                      // valid
        DataStore2<MyStruct> store = new DataStore2<MyStruct>();              // valid
        //DataStore2<string> store = new DataStore2<string>();                // compile-time error 
        //DataStore2<IMyInterface> store = new DataStore2<IMyInterface>();    // compile-time error 
        //DataStore2<ArrayList> store = new DataStore2<ArrayList>();          // compile-time error 
    */
    class DataStore2<T> where T : struct
    {
        public T Data { get; set; }
    }

    /*
        new Constraint

        It means the type argument must be a reference type which has a public parameterless constructor. It cannot be combined with struct and unmanaged constraints.

        Examples:
        DataStore3<MyClass> store = new DataStore3<MyClass>();              // valid
        DataStore3<ArrayList> store = new DataStore3<ArrayList>();          // valid
        //DataStore3<string> store = new DataStore3<string>();              // compile-time error 
        //DataStore3<int> store = new DataStore3<int>();                    // compile-time error 
        //DataStore3<IMyInterface> store = new DataStore3<IMyInterface>();  // compile-time error 
    */
    class DataStore3<T> where T : class, new()
    {
        public T Data { get; set; }
    }


    /*
        base class Constraint

        The type argument must be or derive from the specified nullable or non-nullable base class

        Examples:
        DataStore4<ArrayList> store = new DataStore4<ArrayList>();            // valid
        DataStore4<List> store = new DataStore4<List>();                      // valid
        //DataStore4<string> store = new DataStore4<string>();                // compile-time error 
        //DataStore4<int> store = new DataStore4<int>();                      // compile-time error 
        //DataStore4<IMyInterface> store = new DataStore4<IMyInterface>();    // compile-time error 
        //DataStore4<MyClass> store = new DataStore4<MyClass>();              // compile-time error 
    */
    class DataStore4<T> where T : IEnumerable
    {
        public T Data { get; set; }
    }
}