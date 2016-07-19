using CarRide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRide.Domain.Repositories
{
    public interface IVehicleRepository : IBaseRepository<Vehicle>
    {
        Vehicle GetById(int vehicleId);

        Task<Vehicle> GetByIdAsync(int vehicleId);

        Vehicle GetByOwnerId(Guid ownerId);

        Task<Vehicle> GetByOwnerIdAsync(Guid ownerId);
    }
}