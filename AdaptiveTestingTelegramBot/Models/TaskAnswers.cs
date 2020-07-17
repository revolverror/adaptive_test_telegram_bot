using System;

namespace AdaptiveTestingTelegramBot.Models
{
    public class TaskAnswers
    {
        public int TaskId { get; set; }
        public int TopicId { get; set; }
        public int DifficultyPoints { get; set; }
        public bool IsCorrect { get; set; }
        public bool IsInTime { get; set; }
    }
}
