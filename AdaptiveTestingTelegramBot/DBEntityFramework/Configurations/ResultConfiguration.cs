using AdaptiveTestingTelegramBot.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdaptiveTestingTelegramBot.DBEntityFramework.Configurations
{
    public class ResultConfiguration : IEntityTypeConfiguration<ResultEntity>
    {
        public void Configure(EntityTypeBuilder<ResultEntity> builder)
        {
            builder
                .ToTable("Results")
                .HasKey(r => r.Id);

            builder
                .HasOne(t => t.Test)
                .WithMany(t => t.Results)
                .HasForeignKey(t => t.TestId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(t => t.Student)
                .WithMany(t => t.Results)
                .HasForeignKey(t => t.StudentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
