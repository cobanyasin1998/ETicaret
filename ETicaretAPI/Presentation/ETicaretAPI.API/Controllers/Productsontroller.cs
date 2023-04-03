using ETicaretAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Productsontroller : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public Productsontroller(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        public async void Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), Name = "Product 1", Price = 200, CreatedDate = DateTime.UtcNow, Stock = 10 },
                new() { Id = Guid.NewGuid(), Name = "Product 2", Price = 400, CreatedDate = DateTime.UtcNow, Stock = 20 },
                new() { Id = Guid.NewGuid(), Name = "Product 3", Price = 600, CreatedDate = DateTime.UtcNow, Stock = 30 },
                new() { Id = Guid.NewGuid(), Name = "Product 4", Price = 800, CreatedDate = DateTime.UtcNow, Stock = 40 },
                new() { Id = Guid.NewGuid(), Name = "Product 5", Price = 1000, CreatedDate = DateTime.UtcNow, Stock = 50 },
                new() { Id = Guid.NewGuid(), Name = "Product 6", Price = 1200, CreatedDate = DateTime.UtcNow, Stock = 60 }
            });
            await _productWriteRepository.SaveAsync();
        }
    }
}
