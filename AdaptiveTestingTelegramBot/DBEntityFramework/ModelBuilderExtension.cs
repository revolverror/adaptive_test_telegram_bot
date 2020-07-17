using System;
using AdaptiveTestingTelegramBot.Entities;

using Microsoft.EntityFrameworkCore;

namespace AdaptiveTestingTelegramBot.DBEntityFramework
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            #region Students
            modelBuilder.Entity<StudentEntity>().HasData(
                new StudentEntity
                {
                    Id = 1,
                    TelegramUsername = "username"
                });
            #endregion

            #region Topics
            modelBuilder.Entity<TopicEntity>().HasData(
                new TopicEntity
                {
                    Id = 1,
                    Title = "Topic 1"
                });

            modelBuilder.Entity<TopicEntity>().HasData(
                new TopicEntity
                {
                    Id = 2,
                    Title = "Topic 2"
                });

            modelBuilder.Entity<TopicEntity>().HasData(
                new TopicEntity
                {
                    Id = 3,
                    Title = "Topic 3"
                });
            #endregion

            #region TestOn9Tasks
            #region Tests
            modelBuilder.Entity<TestEntity>().HasData(
                new TestEntity
                {
                    Id = 1,
                    Title = "MOC управління"
                });
            #endregion

            #region Tasks
            modelBuilder.Entity<TaskEntity>().HasData(
                new TaskEntity
                {
                    Id = 1,
                    TestId = 1,
                    TopicId = 1,
                    TaskText = "Мережною називається операційна система що забезпечує: " +
                    "А) Роботу ОП в енергозбер. режимі" +
                    " Б) Багатокор. режим роботи ОП;" +
                    " В) Багатозадачний режим роботи ОП;" +
                    " Г) Багатокор. режим роботи ОП;" +
                    " Д) Підтримку декількох процесорів або процесорних ядер ",
                    DifficultyPoints = 1,
                    Estimate = new TimeSpan(0, 1, 0)
                });

            modelBuilder.Entity<TaskEntity>().HasData(
                new TaskEntity
                {
                    Id = 2,
                    TestId = 1,
                    TopicId = 1,
                    TaskText = "Task 2  1",
                    DifficultyPoints = 1,
                    Estimate = new TimeSpan(0, 1, 0)
                });

           modelBuilder.Entity<TaskEntity>().HasData(
                new TaskEntity
                {
                    Id = 3,
                    TestId = 1,
                    TopicId = 1,
                    TaskText = "Task 3  1",
                    DifficultyPoints = 1,
                    Estimate = new TimeSpan(0, 1, 0)
                });

            modelBuilder.Entity<TaskEntity>().HasData(
                new TaskEntity
                {
                    Id = 4,
                    TestId = 1,
                    TopicId = 2,
                    TaskText = "Task 1  2",
                    DifficultyPoints = 2,
                    Estimate = new TimeSpan(0, 1, 0)
                });

            modelBuilder.Entity<TaskEntity>().HasData(
                new TaskEntity
                {
                    Id = 5,
                    TestId = 1,
                    TopicId = 2,
                    TaskText = "Task 2  2",
                    DifficultyPoints = 2,
                    Estimate = new TimeSpan(0, 1, 0)
                });

            modelBuilder.Entity<TaskEntity>().HasData(
                new TaskEntity
                {
                    Id = 6,
                    TestId = 1,
                    TopicId = 2,
                    TaskText = "Task 3  2",
                    DifficultyPoints = 2,
                    Estimate = new TimeSpan(0, 1, 0)
                });

            modelBuilder.Entity<TaskEntity>().HasData(
                new TaskEntity
                {
                    Id = 7,
                    TestId = 1,
                    TopicId = 3,
                    TaskText = "Task 1  3",
                    DifficultyPoints = 2,
                    Estimate = new TimeSpan(0, 1, 0)
                });

            modelBuilder.Entity<TaskEntity>().HasData(
                new TaskEntity
                {
                    Id = 8,
                    TestId = 1,
                    TopicId = 3,
                    TaskText = "Task 2 Di1fficulty 3",
                    DifficultyPoints = 3,
                    Estimate = new TimeSpan(0, 1, 0)
                });

            modelBuilder.Entity<TaskEntity>().HasData(
                new TaskEntity
                {
                    Id = 9,
                    TestId = 1,
                    TopicId = 3,
                    TaskText = "Task 3 1 3",
                    DifficultyPoints = 3,
                    Estimate = new TimeSpan(0, 1, 0)
                });
            #endregion

            #region Options

            #region Task1
            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 1,
                    TaskId = 1,
                    OptionText = "А",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 2,
                    TaskId = 1,
                    OptionText = "Б",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 3,
                    TaskId = 1,
                    OptionText = "В",
                    IsCorrect = true
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 4,
                    TaskId = 1,
                    OptionText = "Г",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 5,
                    TaskId = 1,
                    OptionText = "Д",
                    IsCorrect = false
                });
            #endregion

            #region Task2
            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 6,
                    TaskId = 2,
                    OptionText = "InCorr1ect1",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 7,
                    TaskId = 2,
                    OptionText = "In1Correct2",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 8,
                    TaskId = 2,
                    OptionText = "InCo1rrect3",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 9,
                    TaskId = 2,
                    OptionText = "InCor1rect4",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 10,
                    TaskId = 2,
                    OptionText = "Co1rrect5",
                    IsCorrect = true
                });
            #endregion

            #region Task3
            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 11,
                    TaskId = 3,
                    OptionText = "InCorrect1",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 12,
                    TaskId = 3,
                    OptionText = "InCorrect2",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 13,
                    TaskId = 3,
                    OptionText = "InCorrect3",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 14,
                    TaskId = 3,
                    OptionText = "InCorrect4",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 15,
                    TaskId = 3,
                    OptionText = "Correct5",
                    IsCorrect = true
                });
            #endregion

            #region Task4
            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 16,
                    TaskId = 4,
                    OptionText = "InCorrect1",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 17,
                    TaskId = 4,
                    OptionText = "InCorrect2",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 18,
                    TaskId = 4,
                    OptionText = "InCorrect3",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 19,
                    TaskId = 4,
                    OptionText = "InCorrect4",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 20,
                    TaskId = 4,
                    OptionText = "Correct5",
                    IsCorrect = true
                });
            #endregion

            #region Task5
            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 21,
                    TaskId = 5,
                    OptionText = "InCorrect1",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 22,
                    TaskId = 5,
                    OptionText = "InCorrect2",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 23,
                    TaskId = 5,
                    OptionText = "InCorrect3",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 24,
                    TaskId = 5,
                    OptionText = "InCorrect4",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 25,
                    TaskId = 5,
                    OptionText = "Correct5",
                    IsCorrect = true
                });
            #endregion

            #region Task6
            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 26,
                    TaskId = 6,
                    OptionText = "InCorrect1",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 27,
                    TaskId = 6,
                    OptionText = "InCorrect2",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 28,
                    TaskId = 6,
                    OptionText = "InCorrect3",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 29,
                    TaskId = 6,
                    OptionText = "InCorrect4",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 30,
                    TaskId = 6,
                    OptionText = "Correct5",
                    IsCorrect = true
                });
            #endregion

            #region Task7
            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 31,
                    TaskId = 7,
                    OptionText = "InCorrect1",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 32,
                    TaskId = 7,
                    OptionText = "InCorrect2",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 33,
                    TaskId = 7,
                    OptionText = "InCorrect3",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 34,
                    TaskId = 7,
                    OptionText = "InCorrect4",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 35,
                    TaskId = 7,
                    OptionText = "Correct5",
                    IsCorrect = true
                });
            #endregion

            #region Task8
            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 36,
                    TaskId = 8,
                    OptionText = "InCorrect1",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 37,
                    TaskId = 8,
                    OptionText = "InCorrect2",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 38,
                    TaskId = 8,
                    OptionText = "InCorrect3",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 39,
                    TaskId = 8,
                    OptionText = "InCorrect4",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 40,
                    TaskId = 8,
                    OptionText = "Correct5",
                    IsCorrect = true
                });
            #endregion

            #region Task9
            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 41,
                    TaskId = 9,
                    OptionText = "InCorrect1",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 42,
                    TaskId = 9,
                    OptionText = "InCorrect2",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 43,
                    TaskId = 9,
                    OptionText = "InCorrect3",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 44,
                    TaskId = 9,
                    OptionText = "InCorrect4",
                    IsCorrect = false
                });

            modelBuilder.Entity<OptionEntity>().HasData(
                new OptionEntity
                {
                    Id = 45,
                    TaskId = 9,
                    OptionText = "Correct5",
                    IsCorrect = true
                });
            #endregion

            #endregion
            #endregion

            #region TestOn30Tasks
            modelBuilder.Entity<TestEntity>().HasData(
                new TestEntity
                {
                    Id = 2,
                    Title = "МОС тест2"
                });

            var countTasks = 9;
            var countOptions = 45;
            var topicId = 1;
            //difficulty 1
            for (int i = 0; i < 12; i++)
            {
                var taskId = i + 1 + countTasks;
                if (( i+1 ) % 4 == 0 && i != 11)
                {
                    topicId++;
                }

                modelBuilder.Entity<TaskEntity>().HasData(
                new TaskEntity
                {
                    Id = taskId,
                    TestId = 2,
                    TopicId = topicId,
                    TaskText = $"Task { i + 1 } Difficulty 1 Topic{ topicId}",
                    DifficultyPoints = 1,
                    Estimate = new TimeSpan(0, 1, 0)
                });

                modelBuilder.Entity<OptionEntity>().HasData(
                    new OptionEntity
                    {
                        Id = 1 + countOptions,
                        TaskId = taskId,
                        OptionText = "А",
                        IsCorrect = false
                    });

                modelBuilder.Entity<OptionEntity>().HasData(
                    new OptionEntity
                    {
                        Id = 2 + countOptions,
                        TaskId = taskId,
                        OptionText = "Б",
                        IsCorrect = false
                    });

                modelBuilder.Entity<OptionEntity>().HasData(
                    new OptionEntity
                    {
                        Id = 3 + countOptions,
                        TaskId = taskId,
                        OptionText = "В",
                        IsCorrect = false
                    });

                modelBuilder.Entity<OptionEntity>().HasData(
                    new OptionEntity
                    {
                        Id = 4 + countOptions,
                        TaskId = taskId,
                        OptionText = "Г",
                        IsCorrect = false
                    });

                modelBuilder.Entity<OptionEntity>().HasData(
                    new OptionEntity
                    {
                        Id = 5 + countOptions,
                        TaskId = taskId,
                        OptionText = "Д",
                        IsCorrect = true
                    });

                countOptions += 5;
            }

            countTasks += 12;
            topicId = 1;

            //difficulty 2
            for (int i = 0; i < 12; i++)
            {
                var taskId = i + 1 + countTasks;
                if ((i + 1) % 4 == 0 && i != 11)
                {
                    topicId++;
                }
                modelBuilder.Entity<TaskEntity>().HasData(
                new TaskEntity
                {
                    Id = i + 1 + countTasks,
                    TestId = 2,
                    TopicId = topicId,
                    TaskText = $"Task {i + 1} Difficulty 2 Topic {topicId}",
                    DifficultyPoints = 2,
                    Estimate = new TimeSpan(0, 1, 0)
                });

                modelBuilder.Entity<OptionEntity>().HasData(
                    new OptionEntity
                    {
                        Id = 1 + countOptions,
                        TaskId = taskId,
                        OptionText = "InCorrect1",
                        IsCorrect = false
                    });

                modelBuilder.Entity<OptionEntity>().HasData(
                    new OptionEntity
                    {
                        Id = 2 + countOptions,
                        TaskId = taskId,
                        OptionText = "InCorrect2",
                        IsCorrect = false
                    });

                modelBuilder.Entity<OptionEntity>().HasData(
                    new OptionEntity
                    {
                        Id = 3 + countOptions,
                        TaskId = taskId,
                        OptionText = "InCorrect3",
                        IsCorrect = false
                    });

                modelBuilder.Entity<OptionEntity>().HasData(
                    new OptionEntity
                    {
                        Id = 4 + countOptions,
                        TaskId = taskId,
                        OptionText = "InCorrect4",
                        IsCorrect = false
                    });

                modelBuilder.Entity<OptionEntity>().HasData(
                    new OptionEntity
                    {
                        Id = 5 + countOptions,
                        TaskId = taskId,
                        OptionText = "Cor1rect5",
                        IsCorrect = true
                    });

                countOptions += 5;
            }

            countTasks += 12;
            topicId = 1;

            //difficulty 3
            for (int i = 0; i < 12; i++)
            {
                var taskId = i + 1 + countTasks;
                if ((i + 1) % 4 == 0 && i != 11)
                {
                    topicId++;
                }
                modelBuilder.Entity<TaskEntity>().HasData(
                new TaskEntity
                {
                    Id = i + 1 + countTasks,
                    TestId = 2,
                    TopicId = topicId,
                    TaskText = $"Task {i + 1} Difficulty 3 Topic {topicId}",
                    DifficultyPoints = 3,
                    Estimate = new TimeSpan(0, 1, 0)
                });

                modelBuilder.Entity<OptionEntity>().HasData(
                    new OptionEntity
                    {
                        Id = 1 + countOptions,
                        TaskId = taskId,
                        OptionText = "InCorrec1t1",
                        IsCorrect = false
                    });

                modelBuilder.Entity<OptionEntity>().HasData(
                    new OptionEntity
                    {
                        Id = 2 + countOptions,
                        TaskId = taskId,
                        OptionText = "InCorre1ct2",
                        IsCorrect = false
                    });

                modelBuilder.Entity<OptionEntity>().HasData(
                    new OptionEntity
                    {
                        Id = 3 + countOptions,
                        TaskId = taskId,
                        OptionText = "InCor1rect3",
                        IsCorrect = false
                    });

                modelBuilder.Entity<OptionEntity>().HasData(
                    new OptionEntity
                    {
                        Id = 4 + countOptions,
                        TaskId = taskId,
                        OptionText = "InCorre1ct4",
                        IsCorrect = false
                    });

                modelBuilder.Entity<OptionEntity>().HasData(
                    new OptionEntity
                    {
                        Id = 5 + countOptions,
                        TaskId = taskId,
                        OptionText = "Corr1ect5",
                        IsCorrect = true
                    });

                countOptions += 5;
            }
            #endregion
        }
    }
}
