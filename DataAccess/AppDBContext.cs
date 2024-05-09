using BussinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class AppDBContext : DbContext
    {
        private static AppDBContext instance = null;
        private static readonly object instanceLock = new object();
        public AppDBContext() { }

        public static AppDBContext Instance
        {
            get
            {
                lock(instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AppDBContext();
                    }
                    return instance;
                }
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",true,true).Build();

            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(builder.GetConnectionString("FStoreAssignment"));

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<MemberObject> Members { get; set; }
        public DbSet<CategoryObject> Categories { get; set; }
        public DbSet<ProductObject> Products { get; set; }
        public DbSet<OrderObject> Orders { get; set; }
        public DbSet<OrderDetailsObject> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetailsObject>()
                .HasKey(x => new
                                {
                                    x.OrderId,
                                    x.ProductId
                                });

            modelBuilder.Entity<OrderDetailsObject>()
                .HasOne(e => e.OrderObject)
                .WithMany(e => e.Details)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderDetailsObject>()
                .HasOne(e => e.ProductObject)
                .WithMany(e => e.Details)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<OrderObject>()
                .HasOne(e => e.Member)
                .WithMany(e => e.Orders)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }
    }
}
