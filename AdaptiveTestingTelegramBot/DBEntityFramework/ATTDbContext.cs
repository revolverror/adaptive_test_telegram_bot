using AdaptiveTestingTelegramBot.DBEntityFramework.Configurations;
using AdaptiveTestingTelegramBot.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdaptiveTestingTelegramBot.DBEntityFramework
{
    class ATTDbContext : DbContext
    {
        public ATTDbContext(DbContextOptions<ATTDbContext> options) : base(options)
        {
            
        }

        public ATTDbContext() 
        {
            Database.EnsureCreated();
        }

        public DbSet<StudentEntity> Students { get; set; }

        public DbSet<TestEntity> Tests { get; set; }

        public DbSet<TaskEntity> Tasks { get; set; }

        public DbSet<OptionEntity> Options { get; set; }

        public DbSet<ResultEntity> Results { get; set; }

        public DbSet<TopicEntity> Topics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string     (localdb)\MSSQLLocalDB
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ATT;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new TestConfiguration());
            modelBuilder.ApplyConfiguration(new TaskConfiguration());
            modelBuilder.ApplyConfiguration(new OptionConfiguration());
            modelBuilder.ApplyConfiguration(new ResultConfiguration());
            modelBuilder.ApplyConfiguration(new TopicConfiguration());

            modelBuilder.Seed();
        }
    }
}
