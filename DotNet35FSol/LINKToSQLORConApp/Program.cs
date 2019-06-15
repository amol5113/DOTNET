using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINKToSQLORConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthD   ataContext context = new NorthDataContext();

            context.Log = Console.Out;


            #region Get all customers from London
            //var result = (from c in context.Customers
            //             where c.City == "London"
            //             select new { c.CustomerID, c.CompanyName, c.ContactName, c.City, c.Country }).ToList(); 
            #endregion

            #region Get all orders by customers from London
            //var result = (from c in context.Customers
            //              join o in context.Orders
            //              on c.CustomerID equals o.CustomerID
            //              where c.City == "London"
            //              select new {c.CustomerID, c.CompanyName, o.OrderID, o.ShipName }
            //              ).ToList();


            //int ctr = 1;
            //foreach (var item in result)
            //{
            //  Console.WriteLine($"{ctr++} -> {item}");
            //} 
            #endregion

            #region Get all London customers order list
            //var result = (from c in context.Customers
            //              join o in context.Orders
            //              on c.CustomerID equals o.CustomerID
            //              where c.City == "London"
            //              group o by o.CustomerID
            //              ).ToList();


            //int ctr = 1;
            //foreach (var item in result)
            //{
            //  Console.WriteLine($"{ctr++} -> CustomerID: {item.Key} ---- Order Count: {item.Count()}");
            //  foreach (var oo in item)
            //  {
            //    Console.WriteLine($"\t{oo.ShipName}");
            //  }
            //} 
            #endregion


            #region Insert
            //Customer cust = new Customer { CustomerID = "AA123", CompanyName = "CDAC", ContactName = "MN", City = "Mumbai", Country = "India" };

            //context.Customers.InsertOnSubmit(cust);
            //try
            //{
            //  context.SubmitChanges();
            //  Console.WriteLine("Rec Added....");
            //}
            //catch (Exception ex)
            //{
            //  Console.WriteLine(ex.ToString());
            //}

            #endregion

            #region Edit
            //Customer cust = context.Customers.FirstOrDefault(c => c.CustomerID == "AA123");
            //Console.WriteLine($"Customer- City: {cust.City}");
            //cust.City = "Bombay";
            //Console.ReadKey(true);
            //try
            //{
            //  context.SubmitChanges();
            //  Console.WriteLine("Rec Update....");
            //}
            //catch (System.Data.Linq.ChangeConflictException ex)
            //{
            //  Console.WriteLine(ex.Message);

            //  context.ChangeConflicts.ResolveAll(System.Data.Linq.RefreshMode.KeepChanges);
            //  context.SubmitChanges();
            //  Console.WriteLine("Rec Update after Conflict");
            //}

            #endregion

            #region Delete
            //Customer cust = context.Customers.FirstOrDefault(c => c.CustomerID == "AA123");
            //Console.WriteLine($"Customer- City: {cust.City}");
            //Console.ReadKey(true);
            //context.Customers.DeleteOnSubmit(cust);
            //try
            //{
            //  context.SubmitChanges();
            //  Console.WriteLine("Rec Deleted....");
            //}
            //catch (Exception ex)
            //{
            //  Console.WriteLine(ex.Message);
            //}

            #endregion

            #region Calling SP

            //var result = context.CustOrderHist("ALFKI");

            //foreach (var item in result)
            //{
            //  Console.WriteLine($"ProdName: {item.ProductName} and Total: {item.Total}");
            //}

            #endregion
        


    }
}
}
