
namespace ListsDataStructure
{ 
    public class MyArrayList
    {
        int[] _list;
        int _size = 0;
        public int Size { get { return _size; } }
        public int[] List { get { return _list; } }

        public MyArrayList()
        {
            _list = new int[10];
        }

        public MyArrayList(int size)
        {
            _list = new int[size];
        }

        /// <summary>
        /// Will add the incoming value to the end of the list
        /// </summary>
        public void Append(int value)
        {
             IncreaseCapacity();
             _list[_size++] = value;
        }
        /// <summary>
        /// shifts all values to right 1 position
        /// adds the incoming value to the start of the list
        /// </summary>
        /// <param name="value">the value that should be added</param>
        public void AddStart(int value)
        {
            IncreaseCapacity();
            for (int i = _size; i >= 0; i--)
            {
                _list[i + i] = _list[i];
            }
            _list[0] = value;
            ++_size;

        }

        public void Insert(int value, int indexToInsert)
        {
            if (indexToInsert < 0 || indexToInsert > _size)
                throw new IndexOutOfRangeException($"Index {indexToInsert} is invalid");
            IncreaseCapacity();
            for (int i = _size - 1; i >= indexToInsert; i--)
            {
                _list[i + 1] = _list[i];
            }
            _list[indexToInsert] = value;
        }
        public void DeleteStart()
        {
            DeleteFromIndex(0);
        }
        public void DeleteEnd()
        {
            if (_size <= 0) return;
            _list[--_size] = 0;
            
        }
        public void DeleteFromIndex(int index)
        {
            if (_size <= 0 || index < 0 || index >= _size) return;

            for (int i = index; i < _size - 1; i++)
            {
                _list[i] = _list[i + 1];
            }

            _list[_size - 1] = 0; // Optional: Reset the last element to 0
            --_size;
        }

        private void IncreaseCapacity()
        {
            if (_size != _list.Length) return;
            int[] newArray = new int[_size * 2];

            for(int i =0; i < _size; i++)
            {
                newArray[i] = _list[i];
            }

            _list = newArray;
        }
    }
}