﻿using EShellAPI.Application.Repositories;
using EShellAPI.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EshellAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;

        
        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository; 
        }
        [HttpGet]
        public async void Get() 
        {
           await _productWriteRepository.AddRangeAsync(new()
            {
                new(){Id=Guid.NewGuid(), Name="Product 1",Price =100, CreateDate=DateTime.UtcNow, Stock=10},
                new(){Id=Guid.NewGuid(), Name="Product 2",Price =200, CreateDate=DateTime.UtcNow, Stock=20},
                new(){Id=Guid.NewGuid(), Name="Product 3",Price =300, CreateDate=DateTime.UtcNow, Stock=30}
            });
        await _productWriteRepository.SaveAsync();
        
        }

        

       

        
    }
}
