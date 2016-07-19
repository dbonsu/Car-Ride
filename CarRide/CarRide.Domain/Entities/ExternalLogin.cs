using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRide.Domain.Entities
{
    public class ExternalLogin
    {
        public virtual string LoginProvider { get; set; }
        public virtual string ProviderKey { get; set; }
        public virtual User User { get; set; }
        public virtual Guid UserId { get; set; }
    }
}