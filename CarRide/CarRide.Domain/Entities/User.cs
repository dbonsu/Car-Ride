using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRide.Domain.Entities
{
    public class User
    {
        public User()
        {
            ExternalLogins = new HashSet<ExternalLogin>();
            Claims = new HashSet<Claim>();
            Roles = new HashSet<Role>();
            Vehicles = new HashSet<Vehicle>();
        }

        public virtual ICollection<Claim> Claims { get; set; }
        public virtual ICollection<ExternalLogin> ExternalLogins { get; set; }
        public virtual string PasswordHash { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual string SecurityStamp { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public UserType UserType { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}