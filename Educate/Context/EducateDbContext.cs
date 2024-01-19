using Educate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Educate.Context
{
    public class EducateDbContext : DbContext
    {
        public EducateDbContext(DbContextOptions<EducateDbContext> options) : base(options)
        {
        }

        public DbSet<Instructor> Instructors { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
