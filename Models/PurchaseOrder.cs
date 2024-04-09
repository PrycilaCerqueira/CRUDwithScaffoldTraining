namespace CRUDwithScaffoldTraining.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public string Quote { get; set; }
        public string Invoice { get; set; }
        public string Supplier { get; set; }
        public List<Address> Supplier_Address {  get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string SalesRep_Name { get; set; }
    }
}
