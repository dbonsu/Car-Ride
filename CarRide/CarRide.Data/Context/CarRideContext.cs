using CarRide.Data.TableConfiguration;
using CarRide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRide.Data.Context
{
    public class CarRideContext : DbContext

    {
        public CarRideContext()
            : base("CarRideContext")
        {
        }

        private IDbSet<ExternalLogin> ExternalLogins { get; set; }
        private IDbSet<Role> Roles { get; set; }
        private IDbSet<User> Users { get; set; }
        private IDbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Created config for more complex/specific needs
            modelBuilder.Configurations.Add(new UserConfiguration());

            modelBuilder.Entity<Claim>()
                 .ToTable("Claim")
                 .HasKey(c => c.ClaimId)
                 .HasRequired(c => c.User).WithMany(c => c.Claims).HasForeignKey(c => c.UserId);

            modelBuilder.Entity<ExternalLogin>()
                .HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                .HasRequired(e => e.User)
                .WithMany(e => e.ExternalLogins)
                .HasForeignKey(e => e.UserId);
        }
    }
}