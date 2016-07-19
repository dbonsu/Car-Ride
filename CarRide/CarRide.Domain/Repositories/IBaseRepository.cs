using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarRide.Domain.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<bool> Add(TEntity entity);

        TEntity FindById(object id);

        Task<TEntity> FindByIdAsync(object id);

        List<TEntity> GetAll();

        Task<List<TEntity>> GetAllAsync();

        Task<bool> Remove(TEntity entity);

        Task<bool> Update(TEntity entity);
    }
}