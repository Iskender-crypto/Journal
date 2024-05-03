using Journal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Journal.Infrastructure.Ef.Configurations;

public class JournalConfiguration : IEntityTypeConfiguration<Domain.Entities.Journal>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Journal> builder)
    {
        builder.ToTable("Journal");
    }
}