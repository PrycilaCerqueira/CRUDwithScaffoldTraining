namespace CRUDwithScaffoldTraining.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int Street_Number { get; set; }
        public string Unit { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
    }
}
