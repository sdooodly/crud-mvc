using Microsoft.EntityFrameworkCore;
using crud_mvc.Models; 

namespace crud_mvc.Data // to configure db
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}