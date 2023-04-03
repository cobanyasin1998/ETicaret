using ERicaretAPI.Domain.Entities;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Context;

namespace ETicaretAPI.Persistence.Repositories
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
