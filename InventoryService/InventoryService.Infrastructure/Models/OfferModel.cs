using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryService.Infrastructure.Models
{
    public class OfferModel
    {
        public int Id { get; set; }
        public string OfferName { get; set; }
        public string Description { get; set; }
        public DateTime OfferStartDate { get; set; }
        public DateTime OfferEndDate { get; set; }
        public int DiscountInPercentage { get; set; }
    }
}
