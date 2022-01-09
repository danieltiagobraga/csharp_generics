/*
    A generic class can include one or more generic methods

    A method declared with the type parameters for its return type or parameters is called a generic method.
*/
namespace GENERIC_METHOD
{
    // The class below contains 2 generic methods
    class DataStore<T>
    {
        private T[] _data = new T[10];
        
        public void AddOrUpdate(int index, T item)
        {
            if(index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if(index >= 0 && index < 10)
                return _data[index];
            else 
                return default(T);
        }
    }

    // A non-generic class can include generic methods by specifying a type parameter in angle brackets with the method name, as shown below.
    class Printer
    {
        public void Print<T>(T data)
        {
            System.Console.WriteLine(data);
        }
    }



    class Demo 
    {
        public void Test() 
        {
            DataStore<string> cities = new DataStore<string>();
            cities.AddOrUpdate(0, "Mumbai");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, "London");
        }
    }
}