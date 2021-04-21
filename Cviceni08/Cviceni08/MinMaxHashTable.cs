using System;
using System.Collections.Generic;
using System.Linq;

namespace Cviceni08
{
    public struct Element<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }

        public Element(K key, V value)
        {
            Key = key;
            Value = value;
        }
    }

    class MinMaxHashTable<K, V> where K : IComparable
    {
        public Element<K,V>[] hashTable;
        
        private K maximum;

        private K minimum;
        public int Count { get; set; }

        public K Maximum
        {
            get 
            { 
                if (Count != 0) 
                {
                    return maximum; 
                } 
                throw new InvalidOperationException(); 
            }
            set 
            { 
                maximum = value; 
            }
        }
        public K Minimum
        {
            get 
            { 
                if (Count != 0) 
                { 
                    return minimum; 
                } 
                throw new InvalidOperationException(); 
            }
            set 
            { 
                minimum = value; 
            }
        }

        public IEnumerable<KeyValuePair<K, V>> this[K min, K max]
        {
            get
            {
                List<KeyValuePair<K, V>> list = new List<KeyValuePair<K, V>>();

                foreach (var element in hashTable)
                {
                    if (element.Key.CompareTo(min) >= 0 && element.Key.CompareTo(max) <= 0)
                        list.Add(new KeyValuePair<K, V>(element.Key, element.Value));
                }
                return list;
            }
        }

        public MinMaxHashTable(int capacity)
        {
            this.hashTable = new Element<K,V>[capacity];
            maximum = default(K);
            minimum = default(K);
            Count = 0;
        }

        public MinMaxHashTable()
        {
            this.hashTable = new Element<K, V>[20];
            maximum = default(K);
            minimum = default(K);
            Count = 0;
        }


        public void Add(K key, V value) {
            int keyInt = Math.Abs(key.GetHashCode() % hashTable.Length);
            Element<K, V> item = new Element<K, V>() { Key = key, Value = value };           
            hashTable[keyInt] = item;
            Minimum = minimum.CompareTo(key) < 0 ? minimum : key;
            Maximum = maximum.CompareTo(key) > 0 ? maximum : key;
            Count++;
        }

        public bool Contains(K key) {

            if (Count == 0) {
                return false;
            }
            foreach (var item in hashTable)
            {
                if (key.Equals(item.Key)) {
                    return true;
                }
            }
            return false;
        }

        public V Get(K key) {
            int index = Math.Abs(key.GetHashCode() % hashTable.Length);
            if (hashTable[index].Value == null) {
                throw new KeyNotFoundException();
            }
            return hashTable[index].Value;
        }

        public V Remove(K key) {

            int index = 0;
            foreach (var item in hashTable)
            {
                if (key.Equals(item.Key))
                {
                    hashTable[index] = hashTable[Count];
                    Count--;
                    return item.Value;
                }
                index++;
            }
            throw new KeyNotFoundException();
        }

        public IEnumerable<KeyValuePair<K, V>> Range(K min, K max)
        {
            List<KeyValuePair<K, V>> list = new List<KeyValuePair<K, V>>();
            foreach (var item in hashTable)
            {
                if (item.Key.CompareTo(min) >= 0 && item.Key.CompareTo(max) <= 0)
                {
                    list.Add(new KeyValuePair<K, V>(item.Key, item.Value));
                }
            }
            return list;
        }

        public IEnumerable<KeyValuePair<K, V>> SortedRange(K min, K max)
        {
            return Range(min, max).OrderBy(x => x.Key);
        }
    }
}
