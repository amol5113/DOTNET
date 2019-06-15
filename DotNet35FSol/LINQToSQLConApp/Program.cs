using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Linq;
using System.Configuration;
namespace LINQToSQLConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["NorthConnection"].ConnectionString);
            var categoryTable = dataContext.GetTable<Category>();

            Table<Product> productTable = dataContext.GetTable<Product>();

            dataContext.Log = Console.Out;


            #region Get all the Category Data
            var result = from c in categoryTable
                         select new { c.CategoryID, c.CategoryName, c.Description };




            #endregion

            #region Get the category with CategoryID as 1
            //var result = from c in categoryTable
            //             where c.CategoryID == 1
            //             select new { c.CategoryID, c.CategoryName, c.Description }; 
            #endregion

            #region Get all products
            //var result = productTable.Select(p => new { p.ProductID, p.ProductName, p.UnitPrice, p.CategoryID });
            //var result = (from p in productTable
            //             select new { p.ProductID, p.ProductName, p.UnitPrice, p.CategoryID }).ToList(); 
            #endregion

            #region Get all products along with its categoryname
            //var result = (from p in productTable
            //              join c in categoryTable
            //              on p.CategoryID equals c.CategoryID
            //              select new { p.ProductID, p.ProductName, c.CategoryID, c.CategoryName }).ToList(); 
            #endregion

            #region Group

            #region Group I
            //var result = (from p in productTable
            //              group p by p.CategoryID).ToList();

            //foreach (var item in result)
            //{
            //  Console.WriteLine($"CatID: {item.Key} --- No Of Prod: {item.Count()}");
            //}

            #endregion

            #region With alias
            //var result = (from p in productTable
            //              group p by p.CategoryID into grp
            //              select new { Cat = grp.Key, NOOfProd = grp.Count() }).ToList(); 
            #endregion

            #region display the categoryid and all the products in that categoryid
            //var result = (from p in productTable
            //              group p by p.CategoryID).ToList();

            //foreach (var item in result)
            //{
            //  Console.WriteLine($"CatID: {item.Key} --- No Of Prod: {item.Count()}");
            //  int ctr = 1;
            //  foreach (var pp in item)
            //  {
            //    Console.WriteLine($"\t{ctr++} - {pp.ProductName}");
            //  }
            //} 
            #endregion


            #region Display the CategoryName and all the Products in that CategoryName
            //var result = (from p in productTable
            //              join c in categoryTable
            //              on p.CategoryID equals c.CategoryID
            //              group p by c.CategoryName).ToList();

            //foreach (var item in result)
            //{
            //  Console.WriteLine($"CategoryName: {item.Key}");
            //  foreach (var pp in item)
            //  {
            //    Console.WriteLine($"\t{pp.ProductName}");
            //  }
            //}

            #endregion


            #endregion

            #region Max UnitPrice in ProductTable
            //var result = (from p in productTable
            //              select p.UnitPrice).Max();
            //Console.WriteLine($"Max UnitPrice: {result}");

            //var result = (from p in productTable
            //              where p.UnitPrice == (from pp in productTable
            //                                    select pp.UnitPrice).Max()
            //              select new { p.ProductName, p.UnitPrice });

            //foreach (var item in result)
            //{
            //  Console.WriteLine(item);
            //}
            #endregion

            #region after Association
            //var result = (from p in productTable
            //              select new { p.ProductName, p.Cat.CategoryName }).ToList();

            //foreach (var item in result)
            //{
            //  Console.WriteLine(item);
            //}

            #endregion

        }

    }
}
