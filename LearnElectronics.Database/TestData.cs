using LearnElectronics.CommonData;
using System;

namespace LearnElectronics.Database
{
    public class TestData
    {

        public Theme[] Themes { get; set; }
        public Lecture[] Lectures { get; set; } 
        public Comment[] Comments { get; set; }
        public Test[] Tests { get; set; }
        public Question[] Questions { get; set; }
        public QuestionVariant[] QuestionVariants { get; set; }
        public Like[] Likes { get; set; }
        public Dislike[] Dislikes { get; set; }
        public User[] Users { get; set; }


        public static TestData GetTestData()
        {

            var themes = new Theme[]
            {
                new Theme
                {
                    Id = 1,
                    Title = "Реальный мир и в электричество",
                    Description = "В данном разделе даются базовые понятия о том, что такое реальный мир, его важнейших понятиях." +
                    "Изучив данный раздел, можно получить целостную базовую модель, от которой можно опираться, изучая дальнейшие темы курса." +
                    "Давайте же погрузимся в удивительный мир электроники!"
                },
            };

            var lectures = new Lecture[]
{
                new Lecture
                {
                    Id = 1,
                    Title = Recources.LearnElectronics_Database_ru_Article1.Title,
                    Description = Recources.LearnElectronics_Database_ru_Article1.Description,
                    Content = Recources.LearnElectronics_Database_ru_Article1.Content,
                    ThemeId = Convert.ToInt32(Recources.LearnElectronics_Database_ru_Article1.ThemeId)
                },

                new Lecture
                {
                    Id = 2,
                    Title = Recources.LearnElectronics_Database_ru_Article2.Title,
                    Description = Recources.LearnElectronics_Database_ru_Article2.Description,
                    Content = Recources.LearnElectronics_Database_ru_Article2.Content,
                    ThemeId = Convert.ToInt32(Recources.LearnElectronics_Database_ru_Article2.ThemeId)
                },

                new Lecture
                {
                    Id = 3,
                    Title = Recources.LearnElectronics_Database_ru_Article3.Title,
                    Description = Recources.LearnElectronics_Database_ru_Article3.Description,
                    Content = Recources.LearnElectronics_Database_ru_Article3.Content,
                    ThemeId = Convert.ToInt32(Recources.LearnElectronics_Database_ru_Article3.ThemeId)
                },

                new Lecture
                {
                    Id = 4,
                    Title = Recources.LearnElectronics_Database_ru_Article4.Title,
                    Description = Recources.LearnElectronics_Database_ru_Article4.Description,
                    Content = Recources.LearnElectronics_Database_ru_Article4.Content,
                    ThemeId = Convert.ToInt32(Recources.LearnElectronics_Database_ru_Article4.ThemeId)
                },

                new Lecture
                {
                    Id = 5,
                    Title = Recources.LearnElectronics_Database_ru_Article5.Title,
                    Description = Recources.LearnElectronics_Database_ru_Article5.Description,
                    Content = Recources.LearnElectronics_Database_ru_Article5.Content,
                    ThemeId = Convert.ToInt32(Recources.LearnElectronics_Database_ru_Article5.ThemeId)
                }

};

            var comments = new Comment[]
            {
                new Comment
                {
                    Id = 1,
                    DateTime = DateTime.Now,
                    Text = "О удивительная электроника!",
                    LectureId = 1,
                    UserId = 1
                },
            };

            var tests = new Test[]
            {
                new Test
                {
                    Id = 1,
                    Title = "Пространство и материя",
                    Description = "Пройдите тест, чтобы узнать, насколько хорошо Вы усвоили устройство пространства и материи",
                    LectureId = 1
                },

                new Test
                {
                    Id = 2,
                    Title = "Строение атома",
                    Description = "Пройдите тест, чтобы узнать, насколько хорошо Вы усвоили строение атома",
                    LectureId = 2
                },

                new Test
                {
                    Id = 3,
                    Title = "Откуда берется электичество",
                    Description = "Пройдите тест, чтобы узнать, насколько хорошо Вы усвоили откуда берется электричество",
                    LectureId = 3
                },

                new Test
                {
                    Id = 4,
                    Title = "Электрическое сопротивление",
                    Description = "Пройдите тест, чтобы узнать, насколько хорошо Вы усвоили устройство электрического сопротивления",
                    LectureId = 4
                },

                new Test
                {
                    Id = 5,
                    Title = "Электрическое поле",
                    Description = "Пройдите тест, чтобы узнать, насколько хорошо Вы усвоили устройство электрического поля",
                    LectureId = 5
                },

            };

            var questions = new Question[]
            {
                new Question
                {
                    Id = 1,
                    Description = Recources.LearnElectronics_Database_ru_Test1_Questions.Question1,
                    Component = TestComponent.Checkbox,
                    TestId = 1
                },

                 new Question
                {
                    Id = 2,
                    Description = Recources.LearnElectronics_Database_ru_Test1_Questions.Question2,
                    Component = TestComponent.Checkbox,
                    TestId = 1
                },

                new Question
                {
                    Id = 3,
                    Description = Recources.LearnElectronics_Database_ru_Test1_Questions.Question3,
                    Component = TestComponent.Checkbox,
                    TestId = 1
                },

                new Question
                {
                    Id = 4,
                    Description = Recources.LearnElectronics_Database_ru_Test1_Questions.Question4,
                    Component = TestComponent.Checkbox,
                    TestId = 1
                },

                new Question
                {
                    Id = 5,
                    Description = Recources.LearnElectronics_Database_ru_Test1_Questions.Question5,
                    Component = TestComponent.Checkbox,
                    TestId = 1
                },

                new Question
                {
                    Id = 6,
                    Description = Recources.LearnElectronics_Database_ru_Test1_Questions.Question6,
                    Component = TestComponent.Checkbox,
                    TestId = 1
                },

                new Question
                {
                    Id = 7,
                    Description = Recources.LearnElectronics_Database_ru_Test2_Questions.Question1,
                    Component = TestComponent.Checkbox,
                    TestId = 2
                },

                new Question
                {
                    Id = 8,
                    Description = Recources.LearnElectronics_Database_ru_Test2_Questions.Question2,
                    Component = TestComponent.Checkbox,
                    TestId = 2
                },

                new Question
                {
                    Id = 9,
                    Description = Recources.LearnElectronics_Database_ru_Test2_Questions.Question3,
                    Component = TestComponent.Checkbox,
                    TestId = 2
                },

                new Question
                {
                    Id = 10,
                    Description = Recources.LearnElectronics_Database_ru_Test3_Questions.Question1,
                    Component = TestComponent.Checkbox,
                    TestId = 3
                },

                new Question
                {
                    Id = 11,
                    Description = Recources.LearnElectronics_Database_ru_Test3_Questions.Question2,
                    Component = TestComponent.Checkbox,
                    TestId = 3
                },

                new Question
                {
                    Id = 12,
                    Description = Recources.LearnElectronics_Database_ru_Test3_Questions.Question3,
                    Component = TestComponent.Checkbox,
                    TestId = 3
                },

                new Question
                {
                    Id = 13,
                    Description = Recources.LearnElectronics_Database_ru_Test4_Questions.Question1,
                    Component = TestComponent.Checkbox,
                    TestId = 4
                },

                new Question
                {
                    Id = 14,
                    Description = Recources.LearnElectronics_Database_ru_Test4_Questions.Question2,
                    Component = TestComponent.Checkbox,
                    TestId = 4
                },

                new Question
                {
                    Id = 15,
                    Description = Recources.LearnElectronics_Database_ru_Test4_Questions.Question3,
                    Component = TestComponent.Checkbox,
                    TestId = 4
                },

                new Question
                {
                    Id = 16,
                    Description = Recources.LearnElectronics_Database_ru_Test4_Questions.Question4,
                    Component = TestComponent.Checkbox,
                    TestId = 4
                },

                new Question
                {
                    Id = 17,
                    Description = Recources.LearnElectronics_Database_ru_Test4_Questions.Question5,
                    Component = TestComponent.Checkbox,
                    TestId = 4
                },

                new Question
                {
                    Id = 18,
                    Description = Recources.LearnElectronics_Database_ru_Test5_Questions.Question1,
                    Component = TestComponent.Checkbox,
                    TestId = 5
                },
            };

            var questionVariants = new QuestionVariant[]
            {
                new QuestionVariant
                {
                    Id = 1,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question1Variant1,
                    IsCorrect = true,
                    QuestionId = 1,
                },

                new QuestionVariant
                {
                    Id = 2,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question1Variant2,
                    IsCorrect = true,
                    QuestionId = 1,
                },

                new QuestionVariant
                {
                    Id = 3,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question1Variant3,
                    IsCorrect = false,
                    QuestionId = 1,
                },

                new QuestionVariant
                {
                    Id = 4,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question1Variant4,
                    IsCorrect = false,
                    QuestionId = 1,
                },

                new QuestionVariant
                {
                    Id = 5,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question2Variant1,
                    IsCorrect = true,
                    QuestionId = 2,
                },

                new QuestionVariant
                {
                    Id = 6,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question2Variant2,
                    IsCorrect = false,
                    QuestionId = 2,
                },

                new QuestionVariant
                {
                    Id = 7,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question2Variant3,
                    IsCorrect = false,
                    QuestionId = 2,
                },

                new QuestionVariant
                {
                    Id = 8,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question3Variant1,
                    IsCorrect = true,
                    QuestionId = 3,
                },

                new QuestionVariant
                {
                    Id = 9,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question3Variant2,
                    IsCorrect = false,
                    QuestionId = 3,
                },

                new QuestionVariant
                {
                    Id = 10,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question3Variant3,
                    IsCorrect = false,
                    QuestionId = 3,
                },

                new QuestionVariant
                {
                    Id = 11,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question3Variant4,
                    IsCorrect = false,
                    QuestionId = 3,
                },

                new QuestionVariant
                {
                    Id = 12,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question4Variant1,
                    IsCorrect = true,
                    QuestionId = 4,
                },

                new QuestionVariant
                {
                    Id = 13,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question4Variant2,
                    IsCorrect = false,
                    QuestionId = 4,
                },

                new QuestionVariant
                {
                    Id = 14,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question4Variant3,
                    IsCorrect = false,
                    QuestionId = 4,
                },

                new QuestionVariant
                {
                    Id = 15,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question5Variant1,
                    IsCorrect = true,
                    QuestionId = 5,
                },

                new QuestionVariant
                {
                    Id = 16,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question5Variant2,
                    IsCorrect = false,
                    QuestionId = 5,
                },

                new QuestionVariant
                {
                    Id = 17,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question5Variant3,
                    IsCorrect = false,
                    QuestionId = 5,
                },

                new QuestionVariant
                {
                    Id = 18,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question6Variant1,
                    IsCorrect = true,
                    QuestionId = 6,
                },

                new QuestionVariant
                {
                    Id = 19,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question6Variant2,
                    IsCorrect = false,
                    QuestionId = 6,
                },

                new QuestionVariant
                {
                    Id = 20,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question6Variant3,
                    IsCorrect = false,
                    QuestionId = 6,
                },

                new QuestionVariant
                {
                    Id = 21,
                    Description = Recources.LearnElectronics_Database_ru_Test1_QuestionVariants.Question6Variant4,
                    IsCorrect = false,
                    QuestionId = 6,
                },


                new QuestionVariant
                {
                    Id = 22,
                    Description = Recources.LearnElectronics_Database_ru_Test2_QuestionVariants.Question1Variant1,
                    IsCorrect = true,
                    QuestionId = 7,
                },

                new QuestionVariant
                {
                    Id = 23,
                    Description = Recources.LearnElectronics_Database_ru_Test2_QuestionVariants.Question1Variant2,
                    IsCorrect = true,
                    QuestionId = 7,
                },

                new QuestionVariant
                {
                    Id = 24,
                    Description = Recources.LearnElectronics_Database_ru_Test2_QuestionVariants.Question1Variant3,
                    IsCorrect = true,
                    QuestionId = 7,
                },

                new QuestionVariant
                {
                    Id = 25,
                    Description = Recources.LearnElectronics_Database_ru_Test2_QuestionVariants.Question1Variant4,
                    IsCorrect = false,
                    QuestionId = 7,
                },

                new QuestionVariant
                {
                    Id = 26,
                    Description = Recources.LearnElectronics_Database_ru_Test2_QuestionVariants.Question2Variant1,
                    IsCorrect = true,
                    QuestionId = 8,
                },

                new QuestionVariant
                {
                    Id = 27,
                    Description = Recources.LearnElectronics_Database_ru_Test2_QuestionVariants.Question2Variant2,
                    IsCorrect = false,
                    QuestionId = 8,
                },

                new QuestionVariant
                {
                    Id = 28,
                    Description = Recources.LearnElectronics_Database_ru_Test2_QuestionVariants.Question2Variant3,
                    IsCorrect = false,
                    QuestionId = 8,
                },

                new QuestionVariant
                {
                    Id = 29,
                    Description = Recources.LearnElectronics_Database_ru_Test2_QuestionVariants.Question3Variant1,
                    IsCorrect = true,
                    QuestionId = 9,
                },

                new QuestionVariant
                {
                    Id = 30,
                    Description = Recources.LearnElectronics_Database_ru_Test2_QuestionVariants.Question3Variant2,
                    IsCorrect = false,
                    QuestionId = 9,
                },

                new QuestionVariant
                {
                    Id = 31,
                    Description = Recources.LearnElectronics_Database_ru_Test2_QuestionVariants.Question3Variant3,
                    IsCorrect = false,
                    QuestionId = 9,
                },

                new QuestionVariant
                {
                    Id = 32,
                    Description = Recources.LearnElectronics_Database_ru_Test3_QuestionVariants.Question1Variant1,
                    IsCorrect = true,
                    QuestionId = 10,
                },

                new QuestionVariant
                {
                    Id = 33,
                    Description = Recources.LearnElectronics_Database_ru_Test3_QuestionVariants.Question1Variant2,
                    IsCorrect = false,
                    QuestionId = 10,
                },

                new QuestionVariant
                {
                    Id = 34,
                    Description = Recources.LearnElectronics_Database_ru_Test3_QuestionVariants.Question1Variant3,
                    IsCorrect = false,
                    QuestionId = 10,
                },

                new QuestionVariant
                {
                    Id = 35,
                    Description = Recources.LearnElectronics_Database_ru_Test3_QuestionVariants.Question2Variant1,
                    IsCorrect = true,
                    QuestionId = 11,
                },

                new QuestionVariant
                {
                    Id = 36,
                    Description = Recources.LearnElectronics_Database_ru_Test3_QuestionVariants.Question2Variant2,
                    IsCorrect = false,
                    QuestionId = 11,
                },

                new QuestionVariant
                {
                    Id = 37,
                    Description = Recources.LearnElectronics_Database_ru_Test3_QuestionVariants.Question2Variant3,
                    IsCorrect = false,
                    QuestionId = 11,
                },

                new QuestionVariant
                {
                    Id = 38,
                    Description = Recources.LearnElectronics_Database_ru_Test3_QuestionVariants.Question3Variant1,
                    IsCorrect = true,
                    QuestionId = 12,
                },

                new QuestionVariant
                {
                    Id = 39,
                    Description = Recources.LearnElectronics_Database_ru_Test3_QuestionVariants.Question3Variant2,
                    IsCorrect = false,
                    QuestionId = 12,
                },

                new QuestionVariant
                {
                    Id = 40,
                    Description = Recources.LearnElectronics_Database_ru_Test3_QuestionVariants.Question3Variant3,
                    IsCorrect = false,
                    QuestionId = 12,
                },

                new QuestionVariant
                {
                    Id = 41,
                    Description = Recources.LearnElectronics_Database_ru_Test4_QuestionVariants.Question1Variant1,
                    IsCorrect = true,
                    QuestionId = 13,
                },

                new QuestionVariant
                {
                    Id = 42,
                    Description = Recources.LearnElectronics_Database_ru_Test4_QuestionVariants.Question1Variant2,
                    IsCorrect = false,
                    QuestionId = 13,
                },

                new QuestionVariant
                {
                    Id = 43,
                    Description = Recources.LearnElectronics_Database_ru_Test4_QuestionVariants.Question1Variant3,
                    IsCorrect = false,
                    QuestionId = 13,
                },

                new QuestionVariant
                {
                    Id = 44,
                    Description = Recources.LearnElectronics_Database_ru_Test4_QuestionVariants.Question2Variant1,
                    IsCorrect = true,
                    QuestionId = 14,
                },

                new QuestionVariant
                {
                    Id = 45,
                    Description = Recources.LearnElectronics_Database_ru_Test4_QuestionVariants.Question2Variant2,
                    IsCorrect = false,
                    QuestionId = 14,
                },

                new QuestionVariant
                {
                    Id = 46,
                    Description = Recources.LearnElectronics_Database_ru_Test4_QuestionVariants.Question2Variant3,
                    IsCorrect = false,
                    QuestionId = 14,
                },

                new QuestionVariant
                {
                    Id = 47,
                    Description = Recources.LearnElectronics_Database_ru_Test4_QuestionVariants.Question3Variant1,
                    IsCorrect = true,
                    QuestionId = 15,
                },

                new QuestionVariant
                {
                    Id = 48,
                    Description = Recources.LearnElectronics_Database_ru_Test4_QuestionVariants.Question3Variant2,
                    IsCorrect = true,
                    QuestionId = 15,
                },

                new QuestionVariant
                {
                    Id = 49,
                    Description = Recources.LearnElectronics_Database_ru_Test4_QuestionVariants.Question3Variant3,
                    IsCorrect = true,
                    QuestionId = 15,
                },

                new QuestionVariant
                {
                    Id = 50,
                    Description = Recources.LearnElectronics_Database_ru_Test4_QuestionVariants.Question4Variant1,
                    IsCorrect = true,
                    QuestionId = 16,
                },

                new QuestionVariant
                {
                    Id = 51,
                    Description = Recources.LearnElectronics_Database_ru_Test4_QuestionVariants.Question4Variant2,
                    IsCorrect = false,
                    QuestionId = 16,
                },

                new QuestionVariant
                {
                    Id = 52,
                    Description = Recources.LearnElectronics_Database_ru_Test4_QuestionVariants.Question4Variant3,
                    IsCorrect = false,
                    QuestionId = 16,
                },

                new QuestionVariant
                {
                    Id = 53,
                    Description = Recources.LearnElectronics_Database_ru_Test4_QuestionVariants.Question5Variant1,
                    IsCorrect = true,
                    QuestionId = 17,
                },

                new QuestionVariant
                {
                    Id = 54,
                    Description = Recources.LearnElectronics_Database_ru_Test4_QuestionVariants.Question5Variant2,
                    IsCorrect = false,
                    QuestionId = 17,
                },

                new QuestionVariant
                {
                    Id = 55,
                    Description = Recources.LearnElectronics_Database_ru_Test4_QuestionVariants.Question5Variant3,
                    IsCorrect = false,
                    QuestionId = 17,
                },

                new QuestionVariant
                {
                    Id = 56,
                    Description = Recources.LearnElectronics_Database_ru_Test5_QuestionVariants.Question1Variant1,
                    IsCorrect = true,
                    QuestionId = 18,
                },

                new QuestionVariant
                {
                    Id = 57,
                    Description = Recources.LearnElectronics_Database_ru_Test5_QuestionVariants.Question1Variant2,
                    IsCorrect = false,
                    QuestionId = 18,
                },

                new QuestionVariant
                {
                    Id = 58,
                    Description = Recources.LearnElectronics_Database_ru_Test5_QuestionVariants.Question1Variant3,
                    IsCorrect = false,
                    QuestionId = 18,
                },

            };

            var likes = new Like[]{};

            var dislikes = new Dislike[]{};

            var users = new User[]
            {
                new User
                {
                    Id = 1,
                    UserName = "Roman Pushtuk",
                    Login = "medok@mail.com",
                    Password = Hashing.HashValue("lovejslang"),
                    RegistrationData = DateTime.Now
                },

                new User
                {
                    Id = 3,
                    UserName = "Egor Borisenko",
                    Login = "agron.354@gmail.com",
                    Password = Hashing.HashValue("loveclang"),
                    RegistrationData = DateTime.Now
                },
            };

            var testData = new TestData
            {
                Themes = themes,
                Lectures = lectures,
                Comments = comments,
                Tests = tests,
                Questions = questions,
                QuestionVariants = questionVariants,
                Likes = likes,
                Dislikes = dislikes,
                Users = users
            };

            return testData;
        }
    }
}
