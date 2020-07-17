using AdaptiveTestingTelegramBot.Entities.Base;

namespace AdaptiveTestingTelegramBot.Entities
{
    public class OptionEntity : BaseEntity
    {
        public int TaskId { get; set; }
        public TaskEntity Task { get; set; }
        public string OptionText { get; set; }
        public bool IsCorrect { get; set; }
    }
}
