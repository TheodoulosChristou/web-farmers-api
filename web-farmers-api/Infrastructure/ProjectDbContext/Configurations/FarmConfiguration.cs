using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using web_farmers_api.Domain.Entities;

namespace web_farmers_api.Infrastructure.ProjectDbContext.Configurations
{
    public class FarmConfiguration : IEntityTypeConfiguration<Farm>
    {
        public void Configure(EntityTypeBuilder<Farm> builder)
        {
            builder.ToTable("Farm");

            builder.HasKey(x => x.ID);

            builder.Property(x=>x.ID).ValueGeneratedOnAdd();

            builder.HasOne<Farmer>()
                .WithMany()
                .HasForeignKey(f => f.FARMER_ID).HasPrincipalKey(fa => fa.ID);
        }
    }
}
