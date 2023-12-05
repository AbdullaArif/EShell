using EShellAPI.Application.Abstractions;
using EShellAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShellAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
       => new() {
       new(){ Id= Guid.NewGuid(), Name="Product1",Stock=10,Price=100},
       new(){ Id= Guid.NewGuid(), Name="Product2",Stock=10,Price=200},
       new(){ Id= Guid.NewGuid(), Name="Product3",Stock=10,Price=300},
       new(){ Id= Guid.NewGuid(), Name="Product4",Stock=10,Price=400},
       };
    }
}
