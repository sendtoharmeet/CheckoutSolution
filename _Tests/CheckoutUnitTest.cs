using System.Linq;
using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _Tests
{
    [TestClass]
    public class CheckoutUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var checkoutCart = new CheckOut();
            checkoutCart.ProcessDiscountRules();
            var finalPrice1 = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();

            checkoutCart = new CheckOut();
            checkoutCart.ProcessDiscountRules();
            checkoutCart.CheckoutItem(1); //A
            var finalPrice2 = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();

            checkoutCart = new CheckOut();
            checkoutCart.ProcessDiscountRules();
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(2); //B
            var finalPrice3 = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();

            checkoutCart = new CheckOut();
            checkoutCart.ProcessDiscountRules();
            checkoutCart.CheckoutItem(3); //C
            checkoutCart.CheckoutItem(4); //D
            checkoutCart.CheckoutItem(2); //B
            checkoutCart.CheckoutItem(1); //A
            var finalPrice4 = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();

            checkoutCart = new CheckOut();
            checkoutCart.ProcessDiscountRules();
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            var finalPrice5 = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();

            checkoutCart = new CheckOut();
            checkoutCart.ProcessDiscountRules();
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            var finalPrice6 = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();

            checkoutCart = new CheckOut();
            checkoutCart.ProcessDiscountRules();
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            var finalPrice7 = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();

            checkoutCart = new CheckOut();
            checkoutCart.ProcessDiscountRules();
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            var finalPrice8 = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();

            checkoutCart = new CheckOut();
            checkoutCart.ProcessDiscountRules();
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            var finalPrice9 = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();
            
            checkoutCart = new CheckOut();
            checkoutCart.ProcessDiscountRules();
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(2); //B
            var finalPrice10 = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();

            checkoutCart = new CheckOut();
            checkoutCart.ProcessDiscountRules();
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(2); //B
            checkoutCart.CheckoutItem(2); //B
            var finalPrice11 = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();

            checkoutCart = new CheckOut();
            checkoutCart.ProcessDiscountRules();
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(2); //B
            checkoutCart.CheckoutItem(2); //B
            checkoutCart.CheckoutItem(4); //D
            var finalPrice12 = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();

            checkoutCart = new CheckOut();
            checkoutCart.ProcessDiscountRules();
            checkoutCart.CheckoutItem(4); //D
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(2); //B
            checkoutCart.CheckoutItem(1); //A
            checkoutCart.CheckoutItem(2); //B
            checkoutCart.CheckoutItem(1); //A
            var finalPrice13 = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();

            Assert.AreEqual(finalPrice1, 0);    //""
            Assert.AreEqual(finalPrice2, 50);   //"A"
            Assert.AreEqual(finalPrice3, 80);   //"AB"
            Assert.AreEqual(finalPrice4, 115);  //"CDBA"
            Assert.AreEqual(finalPrice5, 100);  //"AA"
            Assert.AreEqual(finalPrice6, 130);  //"AAA"
            Assert.AreEqual(finalPrice7, 180);  //"AAAA"
            Assert.AreEqual(finalPrice8, 230);  //"AAAAA"
            Assert.AreEqual(finalPrice9, 260);  //"AAAAAA"
            Assert.AreEqual(finalPrice10, 160); //"AAAB"
            Assert.AreEqual(finalPrice11, 175); //"AAABB"
            Assert.AreEqual(finalPrice12, 190); //"AAABBD"
            Assert.AreEqual(finalPrice13, 190); //"DABABA"

            checkoutCart = new CheckOut();
            checkoutCart.ProcessDiscountRules();
            checkoutCart.CheckoutItem(1); //A
            var finalPrice = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();
            Assert.AreEqual(finalPrice, 50);
            checkoutCart.CheckoutItem(2); //B
            finalPrice = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();
            Assert.AreEqual(finalPrice, 80);
            checkoutCart.CheckoutItem(1); //A
            finalPrice = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();
            Assert.AreEqual(finalPrice, 130);
            checkoutCart.CheckoutItem(1); //A
            finalPrice = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();
            Assert.AreEqual(finalPrice, 160);
            checkoutCart.CheckoutItem(2); //B
            finalPrice = checkoutCart.Orders.Select(x => x.PriceApplied).Sum();
            Assert.AreEqual(finalPrice, 175);

        }
    }
}
