using EShellAPI.Application.Repositories;
using EShellAPI.Domain.Entities;
using EShellAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShellAPI.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(EShellAPIDbContext context) : base(context)
        {
        }
    }
}
