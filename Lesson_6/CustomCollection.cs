using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    internal class CustomCollection<T> : IEnumerable<T> where T : Person
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            item.Id = items.Count + 1;
            items.Add(item);
        }

        public T FindById(int id)
        {
            foreach (var item in items)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public void ShowAll()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public int Count => items.Count;

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
