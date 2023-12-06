using EShellAPI.Application.Repositories;
using EShellAPI.Domain.Entities.Common;
using EShellAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShellAPI.Persistence.Repositories
{
    internal class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly EShellAPIDbContext _context;

        public WriteRepository(EShellAPIDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
        EntityEntry<T> entityEntry =  await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }

      

        public async Task<bool> AddRangeAsync(List<T> model)
        {
          await  Table.AddRangeAsync(model);
            return true;
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(T model)
        {
            throw new NotImplementedException();
        }

        bool IWriteRepository<T>.Remove(T model)
        {
            EntityEntry<T> entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        bool IWriteRepository<T>.Remove(string id)
        {
            throw new NotImplementedException();
        }
    }
}
