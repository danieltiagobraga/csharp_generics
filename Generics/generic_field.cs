namespace GENERIC_FIELD
{
    // A generic class can include generic fields
    class DataStore<T>
    {
        public T[] data = new T[10];
    }
}