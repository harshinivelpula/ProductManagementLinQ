namespace ProductManagementProgramLinq
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review managament program ");
            bool flag = true;
            List<ProductReview> Product;
            Product = new List<ProductReview>
            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 3, UserId = 3, Rating = 1, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 4, UserId = 4, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 5, UserId = 5, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 6, UserId = 6, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 7, UserId = 7, Rating = 1, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 8, UserId = 8, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 9, UserId = 9, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 10, UserId = 10, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 11, UserId = 11, Rating = 1, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 12, UserId = 12, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 13, UserId = 13, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 14, UserId = 14, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 15, UserId = 15, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 16, UserId = 16, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 17, UserId = 17, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 18, UserId = 18, Rating = 1, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 19, UserId = 19, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 20, UserId = 20, Rating = 1, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 21, UserId = 21, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 22, UserId = 22, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 23, UserId = 23, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 24, UserId = 24, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 25, UserId = 25, Rating = 1, Review = "bad", isLike = false }
            };
            Management management = new Management();
            DataBaseOperation dataBaseOperation = new DataBaseOperation();
            while (flag)
            {
                Console.WriteLine("Choose 1-12");
                Console.WriteLine("1.view All Row");
                Console.WriteLine("2.retrive top 3 records");
                Console.WriteLine("3.retrive records");
                Console.WriteLine("4.count of Product Id");
                Console.WriteLine("5.retrive Only product Id And Review");
                Console.WriteLine("6.skip Top 5 Records");
                Console.WriteLine("7.retrive Product Id");
                Console.WriteLine("8.retrive isLike Data From DataTable");
                Console.WriteLine("9.retrive Record where review contain nice");
                Console.WriteLine("10.retrive record which user id is 10 in Datatable");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Product Review");
                        foreach (var item in Product)
                        {
                            Console.WriteLine($"Product ID : {item.ProductId}, " + $"User Id : {item.UserId}, " + $"Rating : {item.Rating}, " + $"Review : {item.Review}, " + $"isLike : {item.isLike}");
                        }
                        break;
                    case 2:
                        management.TopRecord(Product);
                        break;
                    case 3:
                        management.CollectRecords(Product);
                        break;
                    case 4:
                        management.CountProductID(Product);
                        break;
                    case 5:
                        management.ProductIdAndReview(Product);
                        break;
                    case 6:
                        management.SkipTop5Record(Product);
                        break;
                    case 7:
                        management.ProductIdReview(Product);
                        break;
                    //case 8:
                    //    dataBaseOperation.RetrieveIsLikeValueWithTrue();
                    //    break;
                    case 9:
                        management.RetrieveReviewMessage(Product);
                        break;
                    //case 10:
                    //    dataBaseOperation.OrderByRating();
                    //    break;
                    default:
                        flag = false;
                        break;
                }
            }


        }
    }
}