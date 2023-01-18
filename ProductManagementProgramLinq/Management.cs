using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementProgramLinq
{
    public class Management
    {
        public void TopRecord(List<ProductReview> productReviews)
        {
            var top3Records = (from record in productReviews orderby record.Rating descending select record).Take(3);
            foreach (var item in top3Records)
            {
                Console.WriteLine($"Product Id = {item.ProductId} UserId = {item.UserId} Rating = {item.Rating} Review = {item.Review} isLike = {item.isLike}");
            }
        }
        public void CollectRecords(List<ProductReview> productReviews)
        {
            var records = from record in productReviews where (record.ProductId == 1 || record.ProductId == 4 || record.ProductId == 9) && record.Rating > 3 select record;
            foreach (var item in records)
            {
                Console.WriteLine($"Product Id = {item.ProductId} UserId = {item.UserId} Rating = {item.Rating} Review = {item.Review} isLike = {item.isLike}");
            }
        }
        public void CountProductID(List<ProductReview> productReviews)
        {
            var countRecord = productReviews.GroupBy(e => e.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            foreach (var item in countRecord)
            {
                Console.WriteLine($"Product Id = {item.ProductId} Count = {item.Count}");
            }
        }
        public void ProductIdAndReview(List<ProductReview> productReviews)
        {

            var countRecord = productReviews.Select(x => new { ProductId = x.ProductId, Review = x.Review });
            foreach (var item in countRecord)
            {
                Console.WriteLine($"Product Id = {item.ProductId} Review = {item.Review}");
            }
        }
        public void SkipTop5Record(List<ProductReview> productReviews)
        {
            var skipTop5 = (from record in productReviews select record).Skip(5);
            foreach (var item in skipTop5)
            {
                Console.WriteLine($"Product Id = {item.ProductId} UserId = {item.UserId} Rating = {item.Rating} Review = {item.Review} isLike = {item.isLike}");
            }
        }
        public void ProductIdReview(List<ProductReview> productReviews)
        {

            var countRecord = productReviews.Select(x => new { x.ProductId, x.Review });
            foreach (var item in countRecord)
            {
                Console.WriteLine($"Product Id = {item.ProductId} Review = {item.Review}");
            }
        }
        public void RetrieveReviewMessage(List<ProductReview> productlist)
        {
            var records = productlist.Where(x => x.Review.Contains("Nice")).ToList();
            Console.WriteLine("Review Message");
            foreach (var item in records)
            {
                Console.WriteLine($"Product Id : {item.ProductId}, " + $"User Id : {item.UserId}, " + $"Rating : {item.Rating}, " + $"Review : {item.Review}, " + $"isLike : {item.isLike}");
            }
        }
    }
}
