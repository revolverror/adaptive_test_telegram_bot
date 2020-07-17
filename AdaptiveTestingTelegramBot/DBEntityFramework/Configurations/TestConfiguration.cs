using System;

using AdaptiveTestingTelegramBot.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdaptiveTestingTelegramBot.DBEntityFramework.Configurations
{
    public class TestConfiguration : IEntityTypeConfiguration<TestEntity>
    {
        public void Configure(EntityTypeBuilder<TestEntity> builder)
        {
            builder
                .ToTable("Tests")
                .HasKey(t => t.Id);
        }
    }
}
