
using System.Linq.Expressions;
using static LINQ_01.ListGenerator;


namespace LINQ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators
            ////////(1)
            //var result=ProductList.Where(p=>p.UnitsInStock==0).ToList();
            //foreach(var item in result) { Console.WriteLine(item); }

            ////////(2)
            //var result = ProductList.Where(p => p.UnitsInStock == 0 && p.UnitPrice > 3m).ToList();
            //foreach (var item in result) { Console.WriteLine(item); }



            //////(3)
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr
            //    .Select((word, index) => new { Word = word, Value = index }) 
            //    .Where(x => x.Word.Length < x.Value) 
            //    .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Value} → {item.Word}");
            //}

            #endregion
            #region  Element Operators
            //////(1)
            //var result=ProductList.Where(x=>x.UnitsInStock==0).ToList().First();
            // Console.WriteLine(result);

            //////(2)
            //var result =ProductList?.Where(x=>x.UnitPrice>1000).ToList().FirstOrDefault();
            // Console.WriteLine(result);


            //////(3)
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondNumber = Arr
            //.Where(x => x > 5)   
            //.ElementAt(1);

            #endregion
            #region  Aggregate Operators
            /////(1)
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(x=>x%2!=0);
            //Console.WriteLine(result);

            /////(2)
            //var result = CustomerList
            // .Select(c => new
            // {
            //     c.CustomerID,
            //     OrdersCount = c.Orders.Count()
            // });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}




            ////////(3)
            //var result = ProductList
            //  .GroupBy(p => p.Category)
            //   .Select(g => new
            //   {
            //   Category = g.Key,
            //   ProductsCount = g.Count()
            //  });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            ////////////(4)
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // var result =Arr.Sum(x => x);
            // Console.WriteLine(result);


            /////////////(5)
            //////read the txt file 
            //string[] words = File.ReadAllLines("C:\\Users\\Compu Me\\Downloads\\dictionary_english.txt");


            //int totalCharacters = words.Sum(word => word.Length);
            //Console.WriteLine($"Total characters: {totalCharacters}");

            /////////////(6)
            //int shortest = words.Min(word => word.Length);
            //Console.WriteLine($"Shortest word length: {shortest}");

            /////////////(7)
            //int longest = words.Max(word => word.Length);
            //Console.WriteLine($"Longest word length: {longest}");



            /////////////(8)
            //double average = words.Average(word => word.Length);
            //Console.WriteLine($"Average word length: {average:F2}");

            #endregion
            #region Ordering Operators

            ////////////(1)
            //var sortedProducts = ProductList.OrderBy(p => p.ProductName);



            ////////////(2)
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sorted = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);


            ////////////(3)
            //var sorted =ProductList.OrderByDescending(p => p.UnitsInStock);

            ////////////(4)
            ///

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var sorted = Arr
            //    .OrderBy(word => word.Length)
            //    .ThenBy(word => word);




            ////////////(5)


            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sorted = Arr
            //    .OrderBy(word => word.Length)
            //    .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);




            ////////////(6)


            //var sorted =ProductList
            //.OrderBy(p => p.Category)
            //.ThenByDescending(p => p.UnitPrice);




            ////////////(7)


            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sorted = Arr
            //    .OrderBy(word => word.Length)
            //    .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);




            ////////////(8)


            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr
            //    .Where(word => word.Length > 1 && word[1] == 'i')
            //    .Reverse();





            #endregion
            #region Transformation Operators

            ///////////(1)
            //var result = ProductList.Select(p => p.ProductName);

            ///////////(2)


            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select(w => new
            //{
            //    Upper = w.ToUpper(),
            //    Lower = w.ToLower()
            //});





            ///////////(3)


            //var result = ProductList.Select(p => new
            //{
            //    p.ProductName,
            //    Price = p.UnitPrice,
            //    p.Category
            //});




            ///////////(4)



            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Select((value, index) => new
            //{
            //    Value = value,
            //    Index = index,
            //    Match = (value == index)
            //});

            //foreach (var item in result)
            //    Console.WriteLine($"Value: {item.Value}, Index: {item.Index}, Match: {item.Match}");

            ///////////(5)



            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { A = a, B = b };

            //foreach (var pair in result)
            //{
            //    Console.WriteLine($"{pair.A} < {pair.B}");
            //}





            ///////////(6)




            //        var result = CustomerList
            //.SelectMany(c => c.Orders)
            //.Where(o => o.Total < 500.00m);





            ///////////(7)

    //        var result = CustomerList
    //.SelectMany(c => c.Orders)
    //.Where(o => o.OrderDate.Year >= 1998);

    //        foreach (var order in result)
    //            Console.WriteLine($"OrderID={order.OrderID}, Date={order.OrderDate:d}");



            #endregion
        }
    }
}
