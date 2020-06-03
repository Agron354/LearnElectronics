using LearnElectronics.CommonData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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
        public CompletedLecture[] CompletedUserLectures { get; set; }
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
                    Title = "Electric Weapon",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages," +
                    " and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },

                new Theme
                {
                    Id = 2,
                    Title = "Electric Weapon 453564",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages," +
                    " and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },

                new Theme
                {
                    Id = 3,
                    Title = "Electric",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages," +
                    " and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
            };

            var lectures = new Lecture[]
            {
                new Lecture
                {
                    Id = 1,
                    Title = "Electric Weapon",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages," +
                    " and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages," +
                    " and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    ThemeId = 1
                },

                new Lecture
                {
                    Id = 2,
                    Title = "Electric Weapon",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages," +
                    " and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages," +
                    " and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    ThemeId = 2
                },

                new Lecture
                {
                    Id = 3,
                    Title = "Electric Weapon",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages," +
                    " and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages," +
                    " and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    ThemeId = 3
                },
            };

            var comments = new Comment[]
            {
                new Comment
                {
                    Id = 1,
                    DateTime = DateTime.Now,
                    Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages," +
                    " and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    LectureId = 1,
                    UserId = 1
                },

                new Comment
                {
                    Id = 2,
                    DateTime = DateTime.Now,
                    Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages," +
                    " and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    LectureId = 2,
                    UserId = 2
                },

                new Comment
                {
                    Id = 3,
                    DateTime = DateTime.Now,
                    Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages," +
                    " and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    LectureId = 3,
                    UserId = 3
                },
            };

            var tests = new Test[]
            {
                new Test
                {
                    Id = 1,
                    Title = "dfgfd",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages," +
                    " and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    LectureId = 1
                },

                new Test
                {
                    Id = 2,
                    Title = "dfgfd",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages," +
                    " and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    LectureId = 2
                },

                new Test
                {
                    Id = 3,
                    Title = "dfgfd",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages," +
                    " and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    LectureId = 3
                },
            };

            var questions = new Question[]
            {
                new Question
                {
                    Id = 1,
                    Description = "dfgfd",
                    Component = TestComponent.Checkbox,
                    TestId = 1
                },

                 new Question
                {
                    Id = 4,
                    Description = "dfgfd",
                    Component = TestComponent.Checkbox,
                    TestId = 1
                },

                new Question
                {
                    Id = 2,
                    Description = "dfgfd",
                    Component = TestComponent.Checkbox,
                    TestId = 2
                },

                new Question
                {
                    Id = 3,
                    Description = "dfgfd",
                    Component = TestComponent.Checkbox,
                    TestId = 3
                },
            };

            var questionVariants = new QuestionVariant[]
            {
                new QuestionVariant
                {
                    Id = 1,
                    Description = "dfgfd",
                    IsCorrect = false,
                    QuestionId = 1,
                },
                new QuestionVariant
                {
                    Id = 4,
                    Description = "fdgd",
                    IsCorrect = true,
                    QuestionId = 1,
                },
                new QuestionVariant
                {
                    Id = 5,
                    Description = "hgdgh",
                    IsCorrect = true,
                    QuestionId = 1,
                },

                new QuestionVariant
                {
                    Id = 2,
                    Description = "dfgfd",
                    IsCorrect = false,
                    QuestionId = 2,
                },

                new QuestionVariant
                {
                    Id = 3,
                    Description = "dfgfd",
                    IsCorrect = true,
                    QuestionId = 3,
                },

                new QuestionVariant
                {
                    Id = 6,
                    Description = "hjhkhuj",
                    IsCorrect = false,
                    QuestionId = 4,
                },

                new QuestionVariant
                {
                    Id = 7,
                    Description = "adadf",
                    IsCorrect = true,
                    QuestionId = 4,
                },
            };

            var completedUserLectures = new CompletedLecture[]
            {
                new CompletedLecture
                {
                    Id = 1,
                    LectureId = 1,
                    UserId = 1,
                },

                new CompletedLecture
                {
                    Id = 2,
                    LectureId = 2,
                    UserId = 2,
                },

                new CompletedLecture
                {
                    Id = 3,
                    LectureId = 3,
                    UserId = 3,
                },

            };

            var likes = new Like[]
            {
                new Like
                {
                    Id = 1, 
                    UserId = 1,
                    CommentId = 1,
                },

                new Like
                {
                    Id = 2,
                    UserId = 2,
                    CommentId = 2,
                },

                new Like
                {
                    Id = 3,
                    UserId = 3,
                    CommentId = 3,
                },
            };

            var dislikes = new Dislike[]
            {
                new Dislike
                {
                    Id = 1,
                    UserId = 1,
                    CommentId = 1,
                },

                new Dislike
                {
                    Id = 2,
                    UserId = 2,
                    CommentId = 2,
                },

                new Dislike
                {
                    Id = 3,
                    UserId = 3,
                    CommentId = 3,
                },
            };

            var users = new User[]
            {
                new User
                {
                    Id = 1,
                    UserName = "Roman Pushtuk",
                    Login = "World Destroyer",
                    Password = Hashing.HashValue("123"),
                    RegistrationData = DateTime.Now
                },

                new User
                {
                    Id = 2,
                    UserName = "Someone",
                    Login = "world",
                    Password = Hashing.HashValue("1234"),
                    RegistrationData = DateTime.Now
                },

                new User
                {
                    Id = 3,
                    UserName = "Egor Borisenko",
                    Login = "World Keeper",
                    Password = Hashing.HashValue("12345"),
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
                CompletedUserLectures = completedUserLectures,
                Likes = likes,
                Dislikes = dislikes,
                Users = users
            };

            return testData;
        }
    }
}
