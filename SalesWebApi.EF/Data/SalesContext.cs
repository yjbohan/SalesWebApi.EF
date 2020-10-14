using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebApi.EF.Models;

namespace SalesWebApi.EF.Data
{
    public class SalesContext : DbContext
    {
        public SalesContext(DbContextOptions<SalesContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebApi.EF.Models.Customer> Customer { get; set; }
        public DbSet<SalesWebApi.EF.Models.Order> Order { get; set; }
        public DbSet<SalesWebApi.EF.Models.Orderline> Orderline { get; set; }
        public DbSet<SalesWebApi.EF.Models.Product>  Prodcut {get; set;}
    }
}
