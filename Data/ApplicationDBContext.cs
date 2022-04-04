using FirstWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApplication.Data
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {

        }
    }
}
