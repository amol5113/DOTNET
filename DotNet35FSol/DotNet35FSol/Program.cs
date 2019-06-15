using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet35FSol
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Old Object Initialization
            //Employee emp = new Employee();
            //emp.EmpNo = 10;
            //emp.EmpName = "Donald";
            //emp.Age = 21;
            //emp.Salary = 2000;
            #endregion

            #region New Object Initialization
            //Employee emp = new Employee() { EmpNo = 10, EmpName = "Donald", Salary = 2000, Age = 21 };

            //Console.WriteLine(emp); 
            #endregion

            #region region Collection Initialization

            //int[] intArray = new int[3];
            //intArray[0] = 10;
            //int[] intArray = new int[] { 10, 20, 04};

            //List<Employee> empList = new List<Employee>();
            //empList.Add(new Employee { EmpNo = 10, EmpName = "Donald", Salary = 2000, Age = 21 });

            List<Employee> empList = new List<Employee> {
            new Employee {EmpNo = 10, EmpName = "Donald", Salary = 2000, Age = 21 },
            new Employee {EmpNo = 20, EmpName = "Mini", Salary = 3500, Age = 38 } ,
            new Employee {EmpNo = 20, EmpName = "Mini", Salary = 1500, Age = 48 } ,
            new Employee {EmpNo = 20, EmpName = "Mini", Salary = 4500, Age = 28 }
            };

            /*foreach (var item in empList)
            {
                Console.WriteLine($"{item}");
            }*/
            #endregion

            #region Extension method

            /*string name = "Amol";
            Console.WriteLine($"{name}");
            Console.WriteLine($"Name Upper ={name.ToUpper()}");
            Console.WriteLine($"Name Lower ={name.ToLower()}");
            Console.WriteLine($"{name}");

            Console.WriteLine($"{StringFunctions.Reverse(name)}");
            //how this method called 
            Console.WriteLine($"{name.Reverse()}");
*/
            #endregion

            #region when Criteria Given (> 2500)
            /*int ctr = 1;
            foreach (Employee emp in empList.Filter())
            {
                Console.WriteLine($"{ctr++}=={emp}");

            }
*/
            #endregion

            #region criteria given By client(Old way of calling delegate method) 
            /* int ctr = 1;
             foreach (Employee item in empList.Filter(GetBySal))
             {
                 Console.WriteLine($"{ctr++}=={item}");
             }*/
            #endregion

            #region With Anonymous Method
            /*int ctr = 1;
            foreach (Employee emp in empList.Filter( 
              delegate (Employee e)
              {
                if (e.Age > 30)
                {
                  return true;
                }
                return false;
              }))
            {
              Console.WriteLine($"{ctr++} -> {emp}");
            }*/
            #endregion

            #region Lambda with single line
            /*int ctr = 1;
            foreach (Employee emp in empList.Filter(
              (Employee e) => e.Age > 30 ))
            {
              Console.WriteLine($"{ctr++} -> {emp}");
            }*/
            #endregion

            #region Lambda with return -> multi lines
            /*int ctr = 1;
            foreach (Employee emp in empList.Filter(
              (Employee e) => {
                return e.Age > 30 && e.Salary > 2000;
              }))
            {
              Console.WriteLine($"{ctr++} -> {emp}");
            }*/
            #endregion

            #region With one criteria
            /*int ctr = 1;
            foreach (Employee emp in empList.Filter((Employee e) => e.EmpName.StartsWith("D")))
            {
              Console.WriteLine($"{ctr++} -> {emp}");
            }*/
            #endregion

            #region using var keyword
            /*int ctr = 1;
            foreach (var item in empList.Filter((Employee e) => e.EmpName.StartsWith("D")))
            {
              Console.WriteLine($"{ctr++} -> {item}");
            }*/
            #endregion


            #region Using Query Expression
            /*int ctr = 1;
            var result = (from e in empList
                          where e.EmpName.StartsWith("D")
                          select e).ToList();
                
            foreach (var item in result)
            {
                Console.WriteLine($"{ctr++} -> {item}");
            }
*/
            #endregion

            #region With Anonymous Type
            int ctr = 1;
            var result = from e in empList
                         where e.EmpName.StartsWith("M")
                         select new { Name = e.EmpName, Age = e.Age };
            foreach (var item in result)
            {
              Console.WriteLine($"{ctr++} -> {item}");
            } 
            #endregion


        }
        static bool GetBySal(Employee emp)
        {
            if (emp.Salary > 2000)
            {
                return true;
            }
            return false;
        }

        static bool GetByAge(Employee emp)
        {
            if (emp.Age > 30)
            {
                return true;
            }
            return false;
        }
    }
}
