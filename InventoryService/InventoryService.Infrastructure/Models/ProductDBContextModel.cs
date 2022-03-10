using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace InventoryService.Infrastructure.Models
{
    public class ProductDBContextModel
    {
        public List<ProductTypeModel> ProductTypeMaster { get; set; }
        public List<SizeModel> SizeMaster { get; set; }
        public List<ToppingModel> ToppingsMaster { get; set; }
        public List<CrustModel> CrustMaster { get; set; }
        public List<ExtraCheeseModel> ExtraCheesePrice { get; set; }
        public List<ToppingPriceModel> ToppingsPrice { get; set; }
        public List<ProductSubTypesModel> ProductSubTypeMaster { get; set; }       

        public List<ProductModel> ProductMaster { get; set; }
        public List<ProductPriceModel> ProductPriceMaster { get; set; }
        public List<OfferModel> OfferMaster { get; set; }
        public List<OfferDetailModel> OfferDetailMaster { get; set; }
    }
}
