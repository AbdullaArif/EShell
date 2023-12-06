using EShellAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShellAPI.Persistence
{
    public class DesignTimeDbContextFactory: IDesignTimeDbContextFactory<EShellAPIDbContext>
    {
        public EShellAPIDbContext CreateDbContext(string[] args)
        {
           
            DbContextOptionsBuilder<EShellAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(CustomConfiguration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
