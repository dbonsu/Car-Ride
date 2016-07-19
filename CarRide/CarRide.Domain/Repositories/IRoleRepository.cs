using CarRide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRide.Domain.Repositories
{
    public interface IRoleRepository : IBaseRepository<Role>
    {
        Role FindByName(string roleName);

        Task<Role> FindByNameAsync(string roleName);
    }
}