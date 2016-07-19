using CarRide.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRide.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        IExternalLogin ExternalLogin { get; }
        IRoleRepository RoleRepository { get; }
        IUserRepository UserRepository { get; }
        IVehicleRepository VehicleRepository { get; }

        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}