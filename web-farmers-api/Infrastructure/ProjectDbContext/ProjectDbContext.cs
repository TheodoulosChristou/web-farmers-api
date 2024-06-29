using Microsoft.EntityFrameworkCore;
using web_farmers_api.Domain.Entities;
using web_farmers_api.Infrastructure.ProjectDbContext.Configurations;

namespace web_farmers_api.Infrastructure.Data
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {

        }

        public DbSet<Farmer> Farmer {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FarmerConfiguration());
        }
    }
}
