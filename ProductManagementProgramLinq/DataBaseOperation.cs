using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementProgramLinq
{
    public class DataBaseOperation
    {
        DataTable dataTable;
        public static void CreateDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductID");
            dt.Columns.Add("UserID");
            dt.Columns.Add("Rating");
            dt.Columns.Add("Review");
            dt.Columns.Add("isLike");
            dt.Rows.Add(1, 1, 2, "Good", true);
            dt.Rows.Add(1, 2, 2, "Good", true);
            dt.Rows.Add(1, 3, 2, "Good", true);
            dt.Rows.Add(1, 2, 2, "Good", true);
            dt.Rows.Add(1, 2, 2, "Good", true);
            Console.WriteLine("data table created");
        }
        //public void RetrieveIsLikeValueWithTrue()
        //{
        //    var records = from row in dataTable.AsEnumerable() where row.Field<bool>("IsLike") == true select row;
        //    foreach (DataRow row in records)
        //    {
        //        Console.WriteLine("ProductID: " + row["ProductID"]);
        //        Console.WriteLine("UserID: " + row["UserID"]);
        //        Console.WriteLine("Rating: " + row["Rating"]);
        //        Console.WriteLine("Review: " + row["Review"]);
        //        Console.WriteLine("IsLike: " + row["IsLike"]);
        //        Console.WriteLine("---");
        //    }
        //}
        //public void AvgRatingOfProductId()
        //{
        //    var records = from row in dataTable.AsEnumerable() group row by row.Field<int>("ProductID") into grp select new { ProductID = grp.Key };
        //    foreach (var item in records)
        //    {
        //        Console.WriteLine("ProductID: " + item.ProductID);
        //        Console.WriteLine("---");
        //    }
        //}
        //public void OrderByRating()
        //{
        //    var records = dataTable.Select("UserID = 10").OrderBy(r => r["Rating"]);
        //    Console.WriteLine("Order By Rating");
        //    foreach (DataRow row in records)
        //    {
        //        Console.WriteLine("ProductID: " + row["ProductID"]);
        //        Console.WriteLine("UserID: " + row["UserID"]);
        //        Console.WriteLine("Rating: " + row["Rating"]);
        //        Console.WriteLine("Review: " + row["Review"]);
        //        Console.WriteLine("IsLike: " + row["IsLike"]);
        //        Console.WriteLine("---");
        //    }
        //}
    }
}
