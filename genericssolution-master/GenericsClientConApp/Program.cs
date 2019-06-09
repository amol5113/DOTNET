using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GenericsLibrary;
namespace GenericsClientConApp
{
  class Program
  {
    static void Main(string[] args)
    {
      #region SwapTool
      //SwapTool sTool = new SwapTool();

      //int num1 = 10, num2 = 90;
      //Console.WriteLine($"Before Swap values of Num1: {num1} and Num2: {num2}");

      //sTool.Swap<int>(ref num1, ref num2);
      //Console.WriteLine($"After Swap values of Num1: {num1} and Num2: {num2}");

      //Console.WriteLine("-----------String-----------");
      //string firstName = "Peter", lastName = "Parker";
      //Console.WriteLine($"Before Swap values of FirstName: {firstName} and LastName: {lastName}");

      //sTool.Swap(ref firstName, ref lastName);
      //Console.WriteLine($"After Swap values of FirstName: {firstName} and LastName: {lastName}"); 
      #endregion

      #region With Int
      //MyArrayList<int> list = new MyArrayList<int>();
      //list.Add(10);
      //list.Add(2);
      //list.Add(1);
      //Console.WriteLine($"List[1]: {list[1]}");
      //list.Add(6);
      #endregion

      #region With string
      //MyArrayList<string> list = new MyArrayList<string>();
      //list.Add("Tintin");
      //list.Add("Phantom");
      //list.Add("Mandrake");
      //Console.WriteLine($"List[1]: {list[1]}");
      //list.Add("Goffy"); 
      #endregion

      MyArrayList<Person> list = new MyArrayList<Person>();
      list.Add(new Person(10, "Tintin"));
      list.Add(new Person(2, "Snowy"));
      list.Add(new Person(1, "Mini"));
      Console.WriteLine($"List[1]: {list[1]}");
      list.Add(new Person(6, "Jughead"));


      for (int i = 0; i < list.Length; i++)
      {
        Console.WriteLine($"List[{i}]: {list[i]}");
      }
      Console.WriteLine("---------Calling Sort---------");
      list.Sort(Person.CompareByAge);

      foreach (Person p in list)
      {
        Console.WriteLine(p);
      }


      //for (int i = 0; i < list.Length; i++)
      //{
      //  Console.WriteLine($"List[{i}]: {list[i]}");
      //}

      //Console.ReadKey();
      //Console.WriteLine($"List[4]: {list[4]}");
    }
  }
}
