using System.Collections.Generic;
using AdaptiveTestingTelegramBot.Entities.Base;

namespace AdaptiveTestingTelegramBot.Entities
{
    public class TopicEntity : BaseEntity
    {
        public string Title { get; set; }

        public List<TaskEntity> Tasks { get; set; }
    }
}
