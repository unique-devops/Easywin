using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyWin.FormData
{
    public class ProductItem
    {
        // Basic
        public string ItemName { get; set; }
        public string Barcode { get; set; }
        public string ItemCode { get; set; }
        public string Category { get; set; }
        public decimal MRP { get; set; }
        public decimal SalePrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal TaxRate { get; set; }
        public string Unit { get; set; }
        public string HSNCode { get; set; }
        public int StockQty { get; set; }
        public string RackNo { get; set; }

        // Pharma
        public string BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string SaltComposition { get; set; }
        public string ScheduleType { get; set; }
        public string Packing { get; set; }
        public decimal PTR { get; set; }
        public decimal PTS { get; set; }
        public int ReorderLevel { get; set; }

        // Manufacturer
        public string CompanyName { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public string CountryOfOrigin { get; set; }
        public string BrandName { get; set; }

        // Other
        public string Description { get; set; }
        public string Remarks { get; set; }
        public decimal DiscountPercent { get; set; }
        public string OfferDetails { get; set; }
        public string WarrantyPeriod { get; set; }
        public bool Returnable { get; set; }
        public byte[] ProductImage { get; set; } // if you want to save images
    }
}
