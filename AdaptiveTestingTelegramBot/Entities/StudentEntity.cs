using System.Collections.Generic;
using AdaptiveTestingTelegramBot.Entities.Base;

namespace AdaptiveTestingTelegramBot.Entities
{
    public class StudentEntity : BaseEntity
    {
        public string TelegramUsername { get; set; }
        public List<ResultEntity> Results { get; set; }
    }
}
