using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            List<product> shoppingCartList = new List<product>();
            shoppingCartList.Add(new product() { ID = 1, Name = "pants", Cost = 20, Qualntity = 1 });
            shoppingCartList.Add(new product() { ID = 2, Name = "shirt", Cost = 10, Qualntity = 1 });
            shoppingCartList.Add(new product() { ID = 3, Name = "perfume", Cost = 5, Qualntity = 1 });

            List<product> recommendedList = new List<product>();
            recommendedList.Add(new product() { ID = 1, Name = "pants", Cost = 20, Qualntity = 1 });
            recommendedList.Add(new product() { ID = 2, Name = "shirt", Cost = 10, Qualntity = 1 });
            recommendedList.Add(new product() { ID = 3, Name = "perfume", Cost = 5, Qualntity = 1 });
            recommendedList.Add(new product() { ID = 4, Name = "tie", Cost = 4, Qualntity = 1 });
            recommendedList.Add(new product() { ID = 5, Name = "lunch box", Cost = 2, Qualntity = 1 });

            product RecommendedProductsPurchased = new product();
            RecommendedProductsPurchased.RecommendedProductsPurchased(recommendedList, shoppingCartList);
        }

    }
    class product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Decimal  Cost { get; set; }

        public int Qualntity { get; set; }

        public List<product> RecommendedProductsPurchased(List<product> recommendedList, List<product> shoppingCartList)
        {
            var result = recommendedList.Where(p => shoppingCartList.Any(p2 => p2.ID == p.ID)).ToList();

            return result;
        }
    }
   
}
