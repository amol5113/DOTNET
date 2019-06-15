using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Linq.Mapping;
namespace LINQToSQLConApp
{
    [Table(Name = "Categoriess")]
    public class Category
    {
        [Column(IsPrimaryKey =true)]
        public int CategoryID { get; set; }
        [Column]
        public string CategoryName { get; set; }
        [Column]
        public string Description { get; set; }

    }
}
