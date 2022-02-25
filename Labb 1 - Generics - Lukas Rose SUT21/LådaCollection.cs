using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb_1___Generics___Lukas_Rose_SUT21
{
    class LådaCollection : ICollection<Låda>
    {
        List<Låda> innerCol;
        public int Count { get { return innerCol.Count; } }

        public Låda this[int index]
        {
            get { return (Låda)innerCol[index]; }
            set { innerCol[index] = value; }
        }

        public LådaCollection()
        {
            innerCol = new List<Låda>();
        }
        
        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Låda item)
        {
            if (!Contains(item))
            {
                innerCol.Add(item);
            }
            else
            {
                Console.WriteLine($"En låda med höjd {item.höjd}, längd {item.längd} och bredd {item.bredd} finns redan i samlingen.");
            }
        }     

        public bool Contains(Låda x)
        {
            foreach (Låda y in innerCol)
            {
                if (x.Equals(y))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Contains(Låda x, EqualityComparer<Låda> comparer)
        {
            foreach (Låda y in innerCol)
            {
                if (comparer.Equals(x, y))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Låda[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("The array cannot be null.");
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            }
            if (Count > array.Length - arrayIndex + 1)
            {
                throw new ArgumentException("The destination array has fewer elements than the collection.");
            }
            for (int i = 0; i < innerCol.Count; i++)
            {
                array[i + arrayIndex] = innerCol[i];
            }
        }

        public IEnumerator<Låda> GetEnumerator()
        {
            return new LådaEnumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LådaEnumerator(this);
        }

        public bool Remove(Låda item)
        {
            if (innerCol.Contains(item))
            {
                innerCol.Remove(item);
                return true;
            }
            return false;
        }

        public void Clear()
        {
            innerCol.Clear();
        }
    }
}
