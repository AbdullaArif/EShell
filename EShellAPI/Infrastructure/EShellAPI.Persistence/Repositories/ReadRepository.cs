using EShellAPI.Application.Repositories;
using EShellAPI.Domain.Entities.Common;
using EShellAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EShellAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly EShellAPIDbContext  _context;

        public ReadRepository(EShellAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll() => Table;
       

        public async Task<T> GetByIdAsync(string id) => await Table.FirstOrDefaultAsync(p=>p.Id== Guid.Parse(id));
        

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> metod) => await Table.FirstOrDefaultAsync(metod);
       

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> metod) =>Table.Where(metod);
        
    }
}
