using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni05
{
    public class SpojovySeznam : System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.IList
    {
        private Prvek prvni;
        private Prvek posledni;
        public int pocetPrvku;

        public class Prvek
        {
            public Prvek Dalsi;
            public Prvek Predchozi;
            public object Data;

            public Prvek(Prvek dalsi, Prvek predchozi, object data)
            {
                Dalsi = dalsi;
                Predchozi = predchozi;
                Data = data;
            }
            public Prvek(object data)
            {
                Data = data;
            }
        }

        public class SpojovySeznamEnumerator : System.Collections.IEnumerator
        {
            private Prvek aktualni;
            public object Current => aktualni.Data;

            public SpojovySeznamEnumerator(Prvek aktualni)
            {
                this.aktualni = aktualni;
            }

            public bool MoveNext()
            {
                if (aktualni.Dalsi != null)
                {
                    aktualni = aktualni.Dalsi;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void Reset()
            {
                throw new NotImplementedException();
            }
        }

        public object this[int index]
        {
            get => Return(index);
            set => Set(index, value);
        }

        public int Count => pocetPrvku;

        public object SyncRoot => this;

        public bool IsSynchronized => false;

        public bool IsReadOnly => false;

        public bool IsFixedSize => false;

        public int Add(object value)
        {
            Prvek vkladanyPrvek = new Prvek(value);
            if (pocetPrvku == 0)
            {
                prvni = vkladanyPrvek;
                posledni = vkladanyPrvek;
            }
            else
            {
                posledni.Dalsi = vkladanyPrvek;
                vkladanyPrvek.Predchozi = posledni;
                posledni = vkladanyPrvek;
            }
            pocetPrvku++;
            return pocetPrvku;
        }
        public void Clear()
        {
            prvni = null;
            posledni = null;
            pocetPrvku = 0;
        }
        public bool Contains(object value)
        {
            Prvek pomocnyPrvek = prvni;
            Prvek hledanyPrvek = new Prvek(value);
            while (pomocnyPrvek.Dalsi != null)
            {
                if (pomocnyPrvek.Data == hledanyPrvek.Data)
                {
                    return true;
                }
                pomocnyPrvek = pomocnyPrvek.Dalsi;
            }
            return false;
        }
        public void CopyTo(Array array, int index)
        {
            Prvek pomocnyPrvek = prvni;
            for (int i = 0; i < index; i++)
            {
                pomocnyPrvek = pomocnyPrvek.Dalsi;
            }
            foreach (var item in array)
            {
                pomocnyPrvek.Dalsi = new Prvek(item);
                pomocnyPrvek = pomocnyPrvek.Dalsi;
                pocetPrvku++;
            }
        }
        public IEnumerator GetEnumerator()
        {
            Prvek aktualniPrvek = prvni;
            for (int i = 0; i < pocetPrvku - 1; i++)
            {
                aktualniPrvek = aktualniPrvek.Dalsi;
            }
            return new SpojovySeznamEnumerator(aktualniPrvek);
        }
        public int IndexOf(object value)
        {
            Prvek pomocnyPrvek = prvni;
            Prvek hledanyPrvek = new Prvek(value);
            int index = 0;
            while (pomocnyPrvek.Dalsi != null)
            {
                if (pomocnyPrvek.Data == hledanyPrvek.Data)
                {
                    return index;
                }
                pomocnyPrvek = pomocnyPrvek.Dalsi;
                index++;
            }
            return -1;

        }
        public void Insert(int index, object value)
        {
            Prvek pomocnyPrvek = prvni;
            for (int i = 0; i < index; i++)
            {
                pomocnyPrvek = pomocnyPrvek.Dalsi;
            }
            pomocnyPrvek.Dalsi = new Prvek(value);
            pocetPrvku++;
        }
        public void Remove(object value)
        {
            Prvek pomocnyPrvek = prvni;
            Prvek hledanyPrvek = new Prvek(value);
            while (pomocnyPrvek.Dalsi != null)
            {
                if (pomocnyPrvek.Data == hledanyPrvek.Data)
                {
                    pomocnyPrvek.Dalsi = pomocnyPrvek.Dalsi.Dalsi;
                    break;
                }
                pomocnyPrvek = pomocnyPrvek.Dalsi;
            }
            pocetPrvku--;
        }
        public object Return(int index)
        {
            Prvek pomocnyPrvek = prvni;
            for (int i = 0; i < index; i++)
            {
                pomocnyPrvek = pomocnyPrvek.Dalsi;
            }
            return pomocnyPrvek.Data;
        }

        public void Set(int index, object value)
        {
            Prvek pomocnyPrvek = prvni;
            for (int i = 0; i < index; i++)
            {
                pomocnyPrvek = pomocnyPrvek.Dalsi;
            }
            pomocnyPrvek.Data = value;
        }

        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                prvni = prvni.Dalsi;
            }
            else
            {
                Prvek pomocnyPrvek = prvni;
                if (index + 1 == pocetPrvku)
                {
                    posledni.Predchozi.Dalsi = null;
                    posledni = null;
                }
                else
                {
                    for (int i = 0; i < index - 1; i++)
                    {
                        pomocnyPrvek = pomocnyPrvek.Dalsi;
                    }
                    if (pomocnyPrvek != posledni)
                    {
                        pomocnyPrvek.Dalsi = pomocnyPrvek.Dalsi.Dalsi;
                    }
                }
            }
            pocetPrvku--;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
