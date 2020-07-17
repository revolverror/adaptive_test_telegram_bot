using AdaptiveTestingTelegramBot.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdaptiveTestingTelegramBot.DBEntityFramework.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<TaskEntity>
    {
        public void Configure(EntityTypeBuilder<TaskEntity> builder)
        {
            builder
                .ToTable("Tasks")
                .HasKey(t => t.Id);

            builder
                .HasOne(t => t.Test)
                .WithMany(test => test.Tasks)
                .HasForeignKey(t => t.TestId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(t => t.Topic)
                .WithMany(test => test.Tasks)
                .HasForeignKey(t => t.TopicId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
