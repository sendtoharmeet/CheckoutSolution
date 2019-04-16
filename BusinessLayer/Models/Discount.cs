using System;

namespace BusinessLayer.Models
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public int NumberOfItem { get; set; }       // 3    (Fixed price 200 for 3 items)
        public bool IsDiscountFixed { get; set; }   // Fixed price
        public decimal? DiscountRate { get; set; }  // 70% (Can be 70% off on 3rd item purchased)
        public decimal? FixedRate { get; set; }     // $200 (For 3 items)
        public DateTime? ValidFrom { get; set; }    // On new year discount valid for 1 day
        public DateTime? ValidTo { get; set; }      // 2nd Jan
        public bool Active { get; set; }            // Discount can deactive any time
    }
}
