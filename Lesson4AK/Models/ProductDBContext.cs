using Lesson4AK.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lesson4AK.Models
{
    public class ProductDBContext:DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext>options)
            :base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
