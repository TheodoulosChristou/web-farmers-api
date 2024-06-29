using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using web_farmers_api.Domain.Entities;

namespace web_farmers_api.Infrastructure.ProjectDbContext.Configurations
{
    public class FarmerConfiguration : IEntityTypeConfiguration<Farmer>
    {
        public void Configure(EntityTypeBuilder<Farmer> builder)
        {
            builder.ToTable("Farmer");

            builder.HasKey(x => x.ID);

            builder.Property(x=>x.ID).ValueGeneratedOnAdd();
        }
    }
}
