using AdaptiveTestingTelegramBot.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdaptiveTestingTelegramBot.DBEntityFramework.Configurations
{
    public class OptionConfiguration : IEntityTypeConfiguration<OptionEntity>
    {
        public void Configure(EntityTypeBuilder<OptionEntity> builder)
        {
            builder
                .ToTable("Options")
                .HasKey(e => e.Id);

            builder
                .HasOne(e => e.Task)
                .WithMany(task => task.Options)
                .HasForeignKey(e => e.TaskId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
