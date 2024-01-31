using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnStack
{
    public class OwnStack<T>
    {
        private T[] _items;
        
        public int Count {  get; private set; } // К-сть дійсно зберігаємих елементів в _items (по замовчувані = 0)
        public int Capacity // К-сть максимально можливих  елементів в _items (по замовчувані = defaultCapacity)
        {
            get
            {
                return _items.Length;
            }
        }

        public OwnStack() 
        { 
            const int defaultCapacity = 4;
            _items = new T[defaultCapacity];
        }

        public OwnStack(int capacity)
        {
            _items = new T[capacity];
        }

        public void Push(T item)
        {
            if(Capacity == Count)
            {
                T[] doubleItems = new T[Count * 2];
                Array.Copy(_items, doubleItems, Count);

                _items = doubleItems;
            }

            _items[Count++] = item;
        }

        public void Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            _items[--Count] = default;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            return _items[Count - 1];
        }

        public void Print ()
        {
            for(int i = 0; i < Count; i++)
            {
                Console.WriteLine($"items[{i}] = {_items[i]}");
            }
        }
    }
}
