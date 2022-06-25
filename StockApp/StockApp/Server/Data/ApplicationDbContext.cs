using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StockApp.Server.Data.Models;
using StockApp.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockApp.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<TickerDet1> MyList { get; set; }
        public DbSet<TickerDet2> WatchedList { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<TickerDet1>(p =>
            {
                p.HasKey(e => e.name);

                p.Property(e => e.name).IsRequired();
                p.Property(e => e.market).IsRequired();

                p.HasOne(e => e.ApplicationUser).WithMany(e => e.MyList).HasForeignKey(e => e.ID);

            });

            modelBuilder.Entity<TickerDet2>(p =>
            {
                p.HasKey(e => e.name);

                p.Property(e => e.name).IsRequired();
                p.Property(e => e.market).IsRequired();

                p.HasOne(e => e.ApplicationUser).WithMany(e => e.WatchedList).HasForeignKey(e => e.ID);

            });
        }
    }
}
