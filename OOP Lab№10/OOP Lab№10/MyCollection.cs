using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_10
{
    class MyCollection : ISet<Image>
    {
        private int _count;
        public SortedSet<Image> images;

        public MyCollection()
        {
            _count = 0;
            images = new SortedSet<Image>(new Comparer());
        }

        public int Count => _count;

        public void Show()
        {
            Console.Write("Set:   ");
            foreach (var image in images)
            {
                Console.Write(image.Type + "   ");
            }
            Console.WriteLine();
        }

        public bool Add(Image item)
        {
           return images.Add(item);
        }

        public void Clear()
        {
            images.Clear();
        }

        public bool Contains(Image item)
        {
            return images.Contains(item);
        }

        public void CopyTo(Image[] array, int arrayIndex)
        {
            images.CopyTo(array, arrayIndex);
        }

        public void ExceptWith(IEnumerable<Image> other)
        {
            images.ExceptWith(other);
        }

        public IEnumerator<Image> GetEnumerator()
        {
            return images.GetEnumerator();
        }

        public void IntersectWith(IEnumerable<Image> other)
        {
            images.IntersectWith(other);
        }

        public bool IsProperSubsetOf(IEnumerable<Image> other)
        {
            return images.IsProperSubsetOf(other);
        }

        public bool IsProperSupersetOf(IEnumerable<Image> other)
        {
            return images.IsProperSupersetOf(other);
        }

        public bool IsSubsetOf(IEnumerable<Image> other)
        {
            return images.IsProperSupersetOf(other);
        }

        public bool IsSupersetOf(IEnumerable<Image> other)
        {
            return images.IsProperSupersetOf(other);
        }

        public bool Overlaps(IEnumerable<Image> other)
        {
            return images.IsProperSupersetOf(other);
        }

        public bool Remove(Image item)
        {
            return images.Remove(item);
        }

        public bool SetEquals(IEnumerable<Image> other)
        {
            return images.SetEquals(other);
        }

        public void SymmetricExceptWith(IEnumerable<Image> other)
        {
            images.SymmetricExceptWith(other);
        }

        public void UnionWith(IEnumerable<Image> other)
        {
            images.UnionWith(other);
        }
        public bool IsReadOnly => false;

        void ICollection<Image>.Add(Image item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
