using MyCourse.Models.Entities;
using MyCourse.Models.InputModels;
using MyCourse.Models.ViewModels;
using System;

namespace MyCourse.Models.Services.Application.Lesson
{
    public class LessonService : ILessonService
    {
        public LessonService()
        {
        }

        public LessonDetailViewModel AddLesson(LessonCreateInputModel inputModel)
        {            
            throw new NotImplementedException();
        }

        public LessonDetailViewModel GetLesson(int id)
        {
            var lessonDetail = new LessonDetailViewModel();
            lessonDetail.Id = id;
            lessonDetail.Title = $"Lezione {id}!";
            return lessonDetail;
        }

    }
}
