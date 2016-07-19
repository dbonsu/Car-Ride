using CarRide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRide.Domain.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User FindByEmail(string email);

        Task<User> FindByEmailAsync(string email);

        User FindByUserName(string username);

        Task<User> FindByUserNameAsync(string username);

        Task<T> GetProjectedUser<T>() where T : class;
    }
}