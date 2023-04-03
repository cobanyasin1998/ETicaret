using ERicaretAPI.Domain.Entities;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Context;

namespace ETicaretAPI.Persistence.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
