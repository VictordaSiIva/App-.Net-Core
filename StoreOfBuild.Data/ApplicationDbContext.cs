using Microsoft.EntityFrameworkCore;
using StoreOfBuild.Domain.Products;

namespace StoredOfBuild.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories {get; set;}
    }
}