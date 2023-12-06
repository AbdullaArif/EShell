using EShellAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EShellAPI.Application.Repositories
{
    public interface IReadRepository<T>: IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T,bool>> metod);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> metod);
        Task<T> GetByIdAsync(string id);

    }
}
