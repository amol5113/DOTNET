using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLibrary
{

  public delegate bool CompareFN<S>(S value1, S value2);

  public class MyArrayList<T>: IEnumerable<T> where T: IComparable<T>
  {
    T[] _array;
    int _arraySize, _position;
    public MyArrayList()
    {
      _arraySize = 3;
      _position = 0;
      _array = new T[_arraySize];
    }

    public int Length
    {
      get { return _position; }
    }

    public T this[int position]
    {
      get {
        if (position >= _position)
        {
          throw new ArgumentOutOfRangeException($"No Data found at '{position}' position");
        }
        return _array[position];
      }
    }

    public void Add(T value)
    {
      _array[_position++] = value;
      if (_position == _arraySize)
      {
        _arraySize += 3;
        T[] temp = new T[_arraySize];
        for (int i = 0; i < _position; i++)
        {
          temp[i] = _array[i];
        }
        _array = temp;
      }
    }

    public void Sort()
    {
      for (int i = 0; i < _position; i++)
      {
        for (int x = i+1; x < _position; x++)
        {
          if (_array[i].CompareTo(_array[x]) > 0)
          {
            T temp = _array[i];
            _array[i] = _array[x];
            _array[x] = temp;
          }
        }
      }
    }

    public void Sort(CompareFN<T> del)
    {
      for (int i = 0; i < _position; i++)
      {
        for (int x = i + 1; x < _position; x++)
        {
          if (del(_array[i], _array[x]))
          {
            T temp = _array[i];
            _array[i] = _array[x];
            _array[x] = temp;
          }
        }
      }
    }

    public IEnumerator<T> GetEnumerator()
    {
      for (int i = 0; i < _position; i++)
      {
        yield return _array[i];
      }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      for (int i = 0; i < _position; i++)
      {
        yield return _array[i];
      }
    }
  }
}
