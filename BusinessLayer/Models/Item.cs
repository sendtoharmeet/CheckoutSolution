﻿namespace BusinessLayer.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal UnitPrice { get; set; }
        public string ItemDescription { get; set; }
        public Discount CustomDiscount { get; set; }
    }
}
