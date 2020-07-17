using AdaptiveTestingTelegramBot.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdaptiveTestingTelegramBot.DBEntityFramework.Configurations
{
    class TopicConfiguration : IEntityTypeConfiguration<TopicEntity>
    {
        public void Configure(EntityTypeBuilder<TopicEntity> builder)
        {
            builder
                .ToTable("Topics")
                .HasKey(t => t.Id);
        }
    }
}
