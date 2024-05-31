using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom
{
   public class CustomList<T> : IEnumerable<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public void Remove(T item)
    {
        items.Remove(item);
    }

    public bool Contains(T item)
    {
        return items.Contains(item);
    }

    public bool Any(Func<T, bool> predicate)
    {
        return items.Any(predicate);
    }

    public void Clear()
    {
        items.Clear();
    }

    public T FirstOrDefault()
    {
        return items.FirstOrDefault();
    }

    public T ElementAtOrDefault(int index)
    {
        if (index < 0 || index >= items.Count)
            return default(T);

        return items[index];
    }

    public T LastOrDefault()
    {
        return items.LastOrDefault();
    }

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
