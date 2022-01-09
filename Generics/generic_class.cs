namespace GENERIC_CLASS
{
    // DEFINING A GENERIC CLASS WITH ONE TYPE PARAMETER
    class DataStore<T>
    {
        public T Data { get; set; }
    }

    // DEFINING A GENERIC CLASS WITH MULTIPLE TYPE PARAMETERS
    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }



    class Demo
    {
        public void Test()
        {
            // Instantiating Generic Class
            // You can create an instance of generic classes by specifying an actual type in angle brackets.
            DataStore<string> stringStore = new DataStore<string>();
            DataStore<int> intStore = new DataStore<int>();

            KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
            kvp1.Key = 100;
            kvp1.Value = "Hundred";
        }
    }
}
