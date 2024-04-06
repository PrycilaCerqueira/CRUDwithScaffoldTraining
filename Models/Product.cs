using System.Transactions;

namespace CRUDwithScaffoldTraining.Models
{
    public class Product
    {
        public int Prod_Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Maker { get; set; }
        public string? SKU { get; set; }

        public int? Qty_InStock { get; set; }
        public double? UnitPrice { get; set; }
        public double? UnitPrice_Total {  get; set; }
        
        public int?  Qty_Purchased { get; set; }
        public double? CostPrice { get; set; }
        public double? CostPrice_Total { get; set; }

    }
}
