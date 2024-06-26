﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDwithScaffoldTraining.Models;

namespace CRUDwithScaffoldTraining.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext (DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDwithScaffoldTraining.Models.Product> Product { get; set; } = default!;
        public DbSet<CRUDwithScaffoldTraining.Models.Address> Address { get; set; } = default!;
        public DbSet<CRUDwithScaffoldTraining.Models.PurchaseOrder> PurchaseOrder { get; set; } = default!;
    }
}
