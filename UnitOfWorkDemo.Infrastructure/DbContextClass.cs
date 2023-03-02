using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Infrastructures
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<ProductDetails> Products { get; set; }
    }
}
