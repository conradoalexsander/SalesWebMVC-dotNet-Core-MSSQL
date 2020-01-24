using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;

namespace SalesWebMVC.Data
{
    public class SalesWebMVCContext : DbContext
    {
        public SalesWebMVCContext (DbContextOptions<SalesWebMVCContext> options)
            : base(options)
        {
        }

        //preparando o dbContext com as entidades do projeto
        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller  { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
