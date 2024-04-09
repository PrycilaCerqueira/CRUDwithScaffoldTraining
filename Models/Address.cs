namespace CRUDwithScaffoldTraining.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string street { get; set; }
        public int street_number { get; set; }
        public string unit { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string country { get; set; }
    }
}
