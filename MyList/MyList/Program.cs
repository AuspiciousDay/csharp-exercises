using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
            if(index < 0 || index >= count)
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
        }
    }

    public int Count => count;

    public bool IsReadOnly => false;

    public void Add(T item)
    {
        count++;
        if(count > array.Length)
        {
            T[] values = new T[array.Length * 2];
            for(int i = 0; i < array.Length; i++)
            {
                values[i] = array[i];
            }
            array = new T[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                array[i] = values[i];
            }
            array[count] = item;
        }
        else
        {
            array[count] = item;
        }
    }

    public void Clear()
    {
        for(int i = 0; i < Count; i++)
        {
            array[i] = default;
        }
        count = 0;
    }

    public bool Contains(T item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex) 
    {
        for(int i = arrayIndex; i < array.Length; i++)
        {
            Add(array[i]);
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public int IndexOf(T item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, T item)
    {
        throw new NotImplementedException();
    }

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}