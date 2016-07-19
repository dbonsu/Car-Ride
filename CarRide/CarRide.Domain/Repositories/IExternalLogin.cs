using CarRide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRide.Domain.Repositories
{
    public interface IExternalLogin : IBaseRepository<ExternalLogin>
    {
        ExternalLogin GetByProviderAndKey(string loginProvider, string providerKey);

        Task<ExternalLogin> GetByProviderAndKeyAsync(string loginProvider, string providerKey);
    }
}