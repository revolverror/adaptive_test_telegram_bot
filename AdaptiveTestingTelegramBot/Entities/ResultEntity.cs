using AdaptiveTestingTelegramBot.Entities.Base;

namespace AdaptiveTestingTelegramBot.Entities
{
    public class ResultEntity : BaseEntity
    {
        public int TestId { get; set; }
        public TestEntity Test { get; set; }
        public int StudentId { get; set; }
        public StudentEntity Student { get; set; }
        public double Mark { get; set; }
    }
}
