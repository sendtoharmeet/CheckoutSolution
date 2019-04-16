using BusinessLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class CheckOut : ICheckOut
    {
        public List<Discount> Discounts { get; set; }
        public List<Order> Orders { get; set; }

        public CheckOut()
        {
            Discounts = new List<Discount>();
            Orders = new List<Order>();
        }

        public void ProcessDiscountRules()
        {
            Discounts = DbMaster.DiscountCollections.Where(x => x.Active).ToList();
        }

        public void CheckoutItem(int itemId)
        {
            Item item = DbMaster.StoreCollections.Where(x => x.ItemId == itemId).FirstOrDefault();
            Orders.Add(new Order()
            {
                OrderId = 1,
                CustomerId = 1,
                CreatedByUserId = 1,
                DiscountId = GetActiveDiscount(item)?.DiscountId,
                ItemId = item.ItemId,
                UnitPrice = item.UnitPrice,
                PriceApplied = GetFinalPrice(item)
            });
        }

        private Discount GetActiveDiscount(Item item)
        {
            return Discounts.Where(x => x.DiscountId == item.CustomDiscount?.DiscountId).FirstOrDefault();
        }

        private decimal GetFinalPrice(Item item)
        {
            var activeDiscountOnItem = GetActiveDiscount(item);
            if (activeDiscountOnItem == null)
                return item.UnitPrice;

            var dicountOnItems = activeDiscountOnItem.NumberOfItem;

            if (Orders.Where(x => x.ItemId == item.ItemId).Count() + 1 < dicountOnItems)
            {
                return item.UnitPrice;
            }
            else if (activeDiscountOnItem.IsDiscountFixed && (Orders.Where(x => x.ItemId == item.ItemId).Count() + 1) % dicountOnItems == 0)
            {
                foreach (var selectedItem in Orders.Where(x => x.ItemId == item.ItemId && item.UnitPrice == x.PriceApplied))
                {
                    selectedItem.PriceApplied = 0;
                }

                return activeDiscountOnItem.FixedRate.Value;
            }
            else if (!activeDiscountOnItem.IsDiscountFixed && Orders.Where(x => x.ItemId == item.ItemId).Count() % dicountOnItems == 0)
            {
                return activeDiscountOnItem.DiscountRate.Value * item.UnitPrice / 100; // Can be 50% off on 2nd item
            }

            return item.UnitPrice;
        }
    }
}
