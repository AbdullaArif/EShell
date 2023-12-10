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
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(EShellAPIDbContext context) : base(context)
        {
        }
    }
}
