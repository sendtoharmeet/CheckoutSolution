using BusinessLayer;
using System;
using System.Linq;

namespace CheckoutSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var checkoutCart = new CheckOut();
            checkoutCart.ProcessDiscountRules();
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(2); //B

            var finalPrice = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();

            Console.WriteLine(finalPrice);
            Console.ReadLine();
        }
    }
}
