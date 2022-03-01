using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PriceQuotation.Models
{
    public class PriceQuotationModel
    {
        [Required(ErrorMessage = "Please enter a subtotal.")]
        [Range(1, 5000, ErrorMessage = "Subtotal amount must be between 1 and 5000.")]
        public decimal? Subtotal { get; set; }

        [Required(ErrorMessage = "Please enter a discount percent.")]
        [Range(0, 100, ErrorMessage = "Discount percent must be between 0  and 100")]
        public decimal? DiscountPercent { get; set; }


        public decimal? CalculateDiscountAmount()
        {
            decimal? DiscountAmount = (DiscountPercent / 100) * Subtotal;
            for (int i = 0; i < Subtotal; i++)
            {
                DiscountAmount = (DiscountPercent / 100) * Subtotal;
            }
            return DiscountAmount;
        }

        public decimal? CalculatePriceQuotation()
        {
            decimal? DiscountAmount = (DiscountPercent / 100) * Subtotal;
            decimal? PriceQuotation = 0;
            for (int i = 0; i < Subtotal; i++)
            {
                PriceQuotation = (Subtotal - DiscountAmount);
            }
            return PriceQuotation;
        }
    }
}
