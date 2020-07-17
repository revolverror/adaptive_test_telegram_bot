using System;
using System.Collections.Generic;
using AdaptiveTestingTelegramBot.Entities.Base;

namespace AdaptiveTestingTelegramBot.Entities
{
    public class TaskEntity : BaseEntity
    {
        public int TestId { get; set; }
        public TestEntity Test { get; set; }
        public int TopicId { get; set; }
        public TopicEntity Topic { get; set; }
        public string TaskText { get; set; }
        public int DifficultyPoints { get; set; }
        public TimeSpan Estimate { get; set; }
        public List<OptionEntity> Options { get; set; }
    }
}
