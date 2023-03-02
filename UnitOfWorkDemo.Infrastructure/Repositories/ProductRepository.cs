using Abstractions.Interfaces.Repositories;
using Models.Entities;

namespace Infrastructures.Repositories
{
    public class ProductRepository : GenericRepository<ProductDetails>, IProductRepository
    {
        public ProductRepository(DbContextClass dbContext) : base(dbContext)
        {

        }
    }
}
