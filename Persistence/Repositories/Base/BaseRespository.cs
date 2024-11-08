using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : AuditableBaseEntity
    {
        private readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Guid Id)
        {
            TEntity entity = await _context.Set<TEntity>().FindAsync(Id);
            if (entity != null)
            {
                entity.IsActive = false;
                _context.Update(entity);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
        }

        public async Task<TEntity> GetById(Guid Id)
        {
            return await _context.Set<TEntity>().FindAsync(Id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().Where(x => x.IsActive == true).ToListAsync();
        }

        public async Task<bool> Insert(TEntity entity)
        {
            entity.IsActive = true;
            await _context.AddAsync(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(TEntity entity)
        {
            entity.IsActive = true;
            _context.Update(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> InsertRange(List<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                entity.IsActive = true;
            }
            await _context.AddRangeAsync(entities);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
