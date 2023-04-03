using ERicaretAPI.Domain.Entities;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Context;

namespace ETicaretAPI.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
