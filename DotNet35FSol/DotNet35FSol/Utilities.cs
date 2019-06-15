using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet35FSol
{
    public delegate bool FilterFN<S>(S value);
    public static class Utilities
    {
        public static List<Employee> Filter(this List<Employee> sourceList)
        {
            List<Employee> itemList = new List<Employee>();

            foreach (Employee emp in sourceList)
            {
                if (emp.Salary > 2000)
                {
                    itemList.Add(emp);
                }
            }
            return itemList; 
        }

        public static List<T> Filter<T>(this List<T> sourceList,FilterFN<T> del)
        {
            List<T> itemList = new List<T>();

            foreach (T emp in sourceList)
            {
                if (del(emp))
                {
                    itemList.Add(emp);
                }

            }
            return itemList;
        }
    }
}
