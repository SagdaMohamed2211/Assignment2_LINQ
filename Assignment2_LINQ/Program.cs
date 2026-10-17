using System;
using System.Collections.Concurrent;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static Assignment2_LINQ.ListGenerators;
using static System.Net.Mime.MediaTypeNames;
namespace Assignment2_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operators
            //1. Get first Product out of Stock 
            //var result = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(result);

            ////2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result1 = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(result1);

            ////3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result2 = Arr.Where(x => x > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(result2);
            #endregion

            #region Aggregate Operators
            ////1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(Arr => Arr % 2 != 0);
            //Console.WriteLine(result);

            ////2. Return a list of customers and how many orders each has.
            //var result1 = from Customer in CustomerList
            //              select new
            //              {
            //                  CustomerName = Customer.Name,
            //                  OrderCount = Customer.Orders.Count()
            //              };

            //foreach (var item in result1)
            //{
            //    Console.WriteLine($"Customer Name: {item.CustomerName}, Order Count: {item.OrderCount}");
            //}

            //3. Return a list of categories and how many products each has.
            //var result2 = from Product in ProductList
            //              select new
            //              {
            //                  CategoryName = Product.Category,
            //                  productCount = ProductList.Count(p => p.Category == Product.Category)
            //              };


            //foreach (var item in result2)
            //{
            //    Console.WriteLine($"Category: {item.CategoryName}, Count: {item.productCount}");
            //}

            ////4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result3 = Arr.Sum();
            //Console.WriteLine( result3);

            ////5. Get the total number of characters of all words in dictionary_english.txt 
            //var result = File.ReadAllLines("dictionary_english.txt").Sum(word => word.Length);
            //Console.WriteLine(result);

            //// 6.Get the length of the shortest word in dictionary_english.txt 
            //var result = File.ReadAllLines("dictionary_english.txt").Min(word => word.Length);
            //Console.WriteLine(result);

            ////7. Get the length of the longest word in dictionary_english.txt
            //var result6 = File.ReadAllLines("dictionary_english.txt").Max(word => word.Length);
            //Console.WriteLine(result6);

            ////8.Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result6 = File.ReadAllLines("dictionary_english.txt").Average(word => word.Length);
            //Console.WriteLine(result6);

            ////9. Get the total units in stock for each product category. (missed)
            //var result7 = from Product in ProductList
            //              select new
            //              {
            //                  CategoryName = Product.Category,
            //                  TotalUnitsInStock = ProductList.Sum(p => p.UnitsInStock)
            //              };
            //foreach (var item in result7)
            //{
            //    Console.WriteLine($"Category: {item.CategoryName}, Total Units In Stock: {item.TotalUnitsInStock}");
            //}

            ////10. Get the cheapest price among each category's products  (missed)
            //var result8 = from p in ProductList
            //              group p by p.Category into g
            //              select new
            //              {
            //                  CategoryName = g.Key,
            //                  CheapestPrice = g.Min(p => p.UnitPrice)
            //              };

            //foreach (var item in result8)
            //{
            //    Console.WriteLine($"Category: {item.CategoryName}, Cheapest Price: {item.CheapestPrice}");
            //}

            ////11. Get the products with the cheapest price in each category (Use Let)   (missed)
            //var result9 = from p in ProductList
            //              group p by p.Category into g
            //              let CheapestPrice = g.Min(p => p.UnitPrice)
            //              from p in g
            //              where p.UnitPrice == CheapestPrice
            //              select new
            //              {
            //                  ProductName = p.ProductName,
            //                  CategoryName = g.Key,
            //                  CheapestPrice = CheapestPrice
            //              };

            //foreach (var item in result9)
            //{
            //    Console.WriteLine($"Product Name: {item.ProductName}, Category: {item.CategoryName}, Cheapest Price: {item.CheapestPrice}");
            //}

            //12. Get the most expensive price among each category's products.    (missed)
            //var result10 = from p in ProductList
            //              group p by p.Category into g
            //              select new
            //              {
            //                  CategoryName = g.Key,
            //                  MostExpensivePrice = g.Max(p => p.UnitPrice)
            //              };

            //foreach (var item in result10)
            //{
            //    Console.WriteLine($"Category: {item.CategoryName}, Most Expensive Price: {item.MostExpensivePrice}");
            //}

            //13. Get the products with the most expensive price in each category.  (missed)
            //var result13 = from p in ProductList
            //              group p by p.Category into g
            //              let ExpPrice = g.Max(p => p.UnitPrice)
            //              from p in g
            //              where p.UnitPrice == ExpPrice
            //              select new
            //              {
            //                  ProductName = p.ProductName,
            //                  CategoryName = g.Key,
            //                  MostExpensivePrice = ExpPrice
            //              };

            //foreach (var item in result13)
            //{
            //    Console.WriteLine($"Product Name: {item.ProductName}, Category: {item.CategoryName}, Most Expensive Price: {item.MostExpensivePrice}");
            //}


            ////14.Get the average price of each category's products.  (missed)
            //var result14 = from p in ProductList
            //               group p by p.Category into g
            //               select new
            //               {
            //                   CategoryName = g.Key,
            //                   AveragePrice = g.Average(p => p.UnitPrice)
            //               };

            //foreach (var item in result14)
            //{
            //    Console.WriteLine($"Category: {item.CategoryName}, Average Price: {item.AveragePrice}");
            //}

            #endregion

            #region Set Operators

            ////1.Find the unique Category names from Product List
            //var result = ProductList.Select(p => p.Category)
            //    .Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////2. Produce a Sequence containing the unique first letter from both product and customer names.
            //    var result1 = ProductList.Select(p => p.ProductName[0])
            //    .Union(CustomerList.Select(c => c.Name[0]));

            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item);
            //}

            ////3. Create one sequence that contains the common first letter from both product and customer names.
            //var result2 = ProductList.Select(p => p.ProductName[0])
            //    .Intersect(CustomerList.Select(c => c.Name[0]));

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}   

            ////4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result3 = ProductList.Select(p => p.ProductName[0])
            //    .Except(CustomerList.Select(c => c.Name[0]));

            //foreach (var item in result3)
            //{
            //    Console.WriteLine(item);
            //}

            ////5. Create one sequence that contains the first letters of customer names that are not also first letters of product names.
            //var result4 = CustomerList.Select(c => c.Name[0])
            //    .Except(ProductList.Select(p => p.ProductName[0]));

            //foreach (var item in result4)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Partitioning Operators
            ////1. Get the first 3 orders from customers in Washington
            //var result = CustomerList.Where( c => c.Country == "Washington")
            //    .Take(3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Customer Name: {item.Name}, Country: {item.Country}");
            //}

            ////2. Get all but the first 2 orders from customers in Washington
            //var result1 = CustomerList.Where(c => c.Country == "Washington")
            //.Skip(2);

            //foreach (var item in result1)
            //{
            //    Console.WriteLine($"Customer Name: {item.Name}, Country: {item.Country}");
            //}

            ////3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // var result2 = numbers.TakeWhile((n, index) => n > index);
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            ////4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result3 = numbers.SkipWhile(n => n % 3 != 0);
            //foreach (var item in result3)
            //{
            //    Console.WriteLine(item);
            //}

            ////5. Get the elements of the array starting from the first element less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result4 = numbers.SkipWhile((n, index) => n > index);
            //foreach (var item in result4)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Quantifiers

            //1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //Console.WriteLine(File.ReadAllLines("dictionary_english.txt").Any());

            //2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //   var result2 = ProductList.GroupBy(p => p.Category)
            //    .Where(g => g.Any(p => p.UnitsInStock == 0));
            //foreach (var group in result2)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"Product Name: {product.ProductName}, Units In Stock: {product.UnitsInStock}");
            //    }
            //}

            ////3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var result2 = ProductList.GroupBy(p => p.Category)
            //.Where(g => g.All(p => p.UnitsInStock > 0));
            //foreach (var group in result2)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"Product Name: {product.ProductName}, Units In Stock: {product.UnitsInStock}");
            //    }
            //}

            #endregion

            #region Grouping Operators
            //// Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new list<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result = numbers.GroupBy(n => n % 5);
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Numbers with remainder {group.Key} when divided by 5:");
            //    foreach (var number in group)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //// 2.Uses group by to partition a list of words by their first letter.
            ////Use dictionary_english.txt for Input
            //var result2 = File.ReadAllLines("dictionary_english.txt").GroupBy(word => word[0]);
            //foreach (var group in result2)
            //{
            //    Console.WriteLine($"Words starting with '{group.Key}':");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}

            //3.Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            String[] Arr = { "from", "salt", "earn", "last", "near", "form" };
            var result3 = Arr.GroupBy(word => String.Concat(word.OrderBy(c => c)));

            foreach (var group in result3)
            {
                foreach (var word in group)
                {
                    Console.WriteLine(word);
                }

                Console.WriteLine(".....");
            }


            #endregion

        }
    }
}
