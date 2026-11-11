using System;
using System.Collections;
using System.Collections.Generic;

public class MyList<T> : IList<T>
{
    private const int DefaultCapacity = 4;
    private T[] array;
    private int count;
    public MyList()
    {
        array = new T[DefaultCapacity];
        count = 0;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return array[index];
        }
        set
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException();
            }
            array[index] = value;
        }
    }

    public int Count => count;

    public bool IsReadOnly => false;

    public void Add(T item)
    {
        if (count >= array.Length)
        {
            Capacity();
        }
        array[count] = item;
        count++;
    }

    public void Clear()
    {
        count = 0;
    }

    public bool Contains(T item)
    {
        return IndexOf(item) != -1 ? true : false;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        // Array.Copy(this.array,0,array,arrayIndex,count);
        if (array == null)
        {
            throw new ArgumentOutOfRangeException();
        }
        if (arrayIndex < 0 || arrayIndex > array.Length)
        {
            throw new ArgumentOutOfRangeException();
        }
        if (array.Length - arrayIndex < count)
        {
            throw new ArgumentOutOfRangeException();
        }
        for (int i = 0; i < count; i++)
        {
            array[arrayIndex + i] = this.array[i];
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
        {
            yield return array[i];
        }
    }

    public int IndexOf(T item)
    {
        // return Array.IndexOf(array, item);
        for (int i = 0; i < Count; i++)
        {
            if (Equals(item, array[i]))
            {
                return i;
            }
        }
        return -1;
    }

    public void Insert(int index, T item)
    {
        if (index < 0 || index > count)
        {
            throw new ArgumentOutOfRangeException();
        }
        if (count >= array.Length)
        {
            Capacity();
        }
        if (index < count)
        {
            Array.Copy(array, index, array, index + 1, count - index);
        }
        array[index] = item;
        count++;
    }

    public bool Remove(T item)
    {
        int index = IndexOf(item);
        if (index >= 0)
        {
            RemoveAt(index);
            return true;
        }
        return false;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException();
        }
        Array.Copy(array, index + 1, array, index, count - index - 1);
        count--;
        array[count] = default;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private void Capacity()
    {
        if (count == array.Length)
        {
            int newCapacity = array.Length * 2;
            T[] newArray = new T[newCapacity];
            Array.Copy(array, newArray, count);
            array = newArray;
        }
    }
}