using System;
using Microsoft.EntityFrameworkCore;
using WD.DailyNeeds.Core.Entities;
using WD.DailyNeeds.Infrastructure.Config;

namespace WD.DailyNeeds.Infrastructure.Data;

public class StoreContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
    }
}
