using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClientConApp
{
  public class Person: IComparable<Person>
  {
    string _name;
    int _age;

    public Person(int age, string name)
    {
      _age = age;
      _name = name;
    }

    public int Age
    {
      get { return _age; }
    }
    public string Name
    {
      get { return _name; }
    }

    public int CompareTo(Person other)
    {
      //return _name.CompareTo(other._name);
      return _age.CompareTo(other._age);
    }

    public override string ToString()
    {
      return $"Name: {_name} and Age: {_age}";
    }

    public static bool CompareByName(Person p1, Person p2)
    {
      if (p1._name.CompareTo(p2._name) > 0)
        return true;
      return false;
    }

    public static bool CompareByAge(Person p1, Person p2)
    {
      if (p1._age > p2._age)
        return true;
      return false;
    }

  }
}
