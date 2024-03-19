using Keeper.Domen.ModelsPharmacy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeper.Domen;

public class PharmacyDbContext : DbContext
{
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<Medicines> Medicines { get; set; }
    public DbSet<Issue> Issues { get; set; }
    public DbSet<Invoice> Invoices { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Pharmacy;Trusted_Connection=True");
    }
}
