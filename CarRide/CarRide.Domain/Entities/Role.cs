using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRide.Domain.Entities
{
    public class Role
    {
        public string Name { get; set; }
        public Guid RoleId { get; set; }
        public ICollection<User> Users { get; set; }
    }
}