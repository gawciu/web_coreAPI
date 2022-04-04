﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeMug.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace CoffeeMug.Data.ModelDbContext
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options):base(options){}

        public DbSet<Product> Products { get; set; }
    }
}
