namespace List
{
    public class List<T>
    {
        private T[] _items;

        public int Lenght => _items.Length;

        public List()
        {
            _items = new T[2];
        }

        public void Add(T item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i] is null)
                {
                    _items[i] = item;
                    return;
                }
            }
            Array newArray = Array.CreateInstance(typeof(T), _items.Length + 1);
            Array.Copy(_items, newArray, _items.Length);
            _items = (T[])newArray;
            Add(item);
        }

        public T this[int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }
    }
}
