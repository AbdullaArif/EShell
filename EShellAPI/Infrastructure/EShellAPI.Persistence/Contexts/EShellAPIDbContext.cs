using EShellAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShellAPI.Persistence.Contexts
{
    public class EShellAPIDbContext:DbContext
    {
        public EShellAPIDbContext(DbContextOptions<EShellAPIDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }   
        public DbSet<Order> Orders { get; set; }   
        public DbSet<Customer> Costumers { get; set; }
    }
}
