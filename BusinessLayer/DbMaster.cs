using BusinessLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
    public static class DbMaster
    {
        //This class is mainly used for getting values from database Master tables, Here I am getting dicounts and Items list.
        public static List<Item> StoreCollections;
        public static List<Discount> DiscountCollections;

        static DbMaster()
        {
            var DiscountMaster1 = new Discount() { Active = true, DiscountId = 1, FixedRate = 130, IsDiscountFixed = true, NumberOfItem = 3 };
            var DiscountMaster2 = new Discount() { Active = true, DiscountId = 2, FixedRate = 45, IsDiscountFixed = true, NumberOfItem = 2 };

            StoreCollections = new List<Item>();
            StoreCollections.Add(new Item() { ItemId = 1, ItemName = "A", UnitPrice = 50, CustomDiscount = DiscountMaster1 });
            StoreCollections.Add(new Item() { ItemId = 2, ItemName = "B", UnitPrice = 30, CustomDiscount = DiscountMaster2 });
            StoreCollections.Add(new Item() { ItemId = 3, ItemName = "C", UnitPrice = 20, CustomDiscount = null });
            StoreCollections.Add(new Item() { ItemId = 4, ItemName = "D", UnitPrice = 15, CustomDiscount = null });

            DiscountCollections = new List<Discount>();
            DiscountCollections.Add(DiscountMaster1);
            DiscountCollections.Add(DiscountMaster2);
        }
    }
}
