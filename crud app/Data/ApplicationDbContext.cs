using crud_app.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_app.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Fruit> Fruits { get; set; }
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base(options) 
        {
            
        }
    }
}
