using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Base
{
    public interface IBaseRepository<TEntity> where TEntity : AuditableBaseEntity
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(Guid Id);
        Task<bool> Insert(TEntity entity);
        Task<bool> InsertRange(List<TEntity> entities);
        Task<bool> Update(TEntity entity);
        Task<bool> Delete(Guid Id);
    }
}
