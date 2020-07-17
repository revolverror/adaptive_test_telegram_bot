using System.Collections.Generic;

using AdaptiveTestingTelegramBot.Entities.Base;

namespace AdaptiveTestingTelegramBot.Entities
{
    public class TestEntity : BaseEntity
    {
        public string Title { get; set; }
        public int MaxAttempts { get; set; }
        public int StudentAttempts { get; set; }
        public double StudentMark { get; set; }
        public List<TaskEntity> Tasks {get;set;}
        public List<ResultEntity> Results { get; set; }
    }
}
