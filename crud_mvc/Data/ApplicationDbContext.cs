using Microsoft.EntityFrameworkCore;
using crud_mvc.Models; // Make sure this namespace matches your Person model

namespace crud_mvc.Data
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