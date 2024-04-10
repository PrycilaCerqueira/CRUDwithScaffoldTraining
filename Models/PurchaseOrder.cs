﻿namespace CRUDwithScaffoldTraining.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public string Quote { get; set; }
        public string Invoice { get; set; }
        public string Supplier { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string SalesRep_Name { get; set; }

        public DateOnly eTA { get; set; }
        public Address AddressId { get; set; }
        public Address Delivery_Address { get; set; }

    }

    //TODO: Fix error Microsoft.Data.Sqlite.SqliteException (0x80004005): SQLite Error 1: 'no such column: p.AddressIdId'.
}
