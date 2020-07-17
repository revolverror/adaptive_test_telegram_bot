using AdaptiveTestingTelegramBot.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdaptiveTestingTelegramBot.DBEntityFramework.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<StudentEntity>
    {
        public void Configure(EntityTypeBuilder<StudentEntity> builder)
        {
            builder
                .ToTable("Students")
                .HasKey(p => p.Id);
        }
    }
}
