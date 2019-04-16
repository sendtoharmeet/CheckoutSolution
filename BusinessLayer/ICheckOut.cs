using BusinessLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface ICheckOut
    {
        List<Discount> Discounts { get; set; }
        List<Order> Orders { get; set; }
        void ProcessDiscountRules();
        void CheckoutItem(int itemId);
    }
}
