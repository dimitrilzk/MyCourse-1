using Microsoft.EntityFrameworkCore;
using MyCourse.Models.InputModels;
using MyCourse.Models.Services.Infrastructure;
using MyCourse.Models.ViewModels;
using System.Linq;

namespace MyCourse.Models.Services.Application.Lesson
{
    public class EfCoreLessonService : ILessonService
    {
        private readonly MyCourseDbContext dbContext;

        public EfCoreLessonService(MyCourseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public LessonDetailViewModel AddLesson(LessonCreateInputModel inputModel)
        {
            var lesson = new LessonDetailViewModel();
            lesson.Title = inputModel.Title;
            lesson.Description = inputModel.Description;
            lesson.Duration = inputModel.Duration;
            lesson.CourseId = inputModel.courseId;
            dbContext.Add(lesson);
            dbContext.SaveChanges();
            return lesson;
        }

        public LessonDetailViewModel GetLesson(int id)
        {
            LessonDetailViewModel viewModel = dbContext.Lessons
                .AsNoTracking()
                .Where(lesson => lesson.Id == id)
                .Select(lesson => new LessonDetailViewModel
                {
                    Id = lesson.Id,
                    CourseId = lesson.CourseId,
                    Title = lesson.Title,
                    Description = lesson.Description,
                    Duration = lesson.Duration,
                })
                .FirstOrDefault();
            return viewModel;
        }
    }
}
