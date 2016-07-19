using CarRide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRide.Data.TableConfiguration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("CarRideUser");

            HasKey(u => u.UserId)
                .Property(u => u.UserId).HasColumnType("uniqueidentifier")
                .IsRequired();

            Property(u => u.PasswordHash).HasColumnType("varchar").IsOptional();
            Property(u => u.SecurityStamp).HasColumnType("varchar").IsOptional();

            HasMany(u => u.Roles)
                .WithMany(r => r.Users)
                .Map(x =>
               {
                   x.ToTable("UserRole");
                   x.MapLeftKey("UserId");
                   x.MapRightKey("RoleId");
               });

            HasMany(u => u.Claims)
                .WithRequired(c => c.User)
                .HasForeignKey(c => c.UserId);
            HasMany(u => u.ExternalLogins)
                .WithRequired(l => l.User)
                .HasForeignKey(l => l.UserId);
        }
    }
}