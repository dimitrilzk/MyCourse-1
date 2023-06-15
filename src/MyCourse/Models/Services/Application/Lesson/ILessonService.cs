using MyCourse.Models.InputModels;
using MyCourse.Models.ViewModels;
using System.Data;

namespace MyCourse.Models.Services.Application.Lesson
{
    public interface ILessonService
    {
        LessonDetailViewModel GetLesson(int id);
        LessonDetailViewModel AddLesson(LessonCreateInputModel inputModel);
        //LessonEditViewModel
    }
}
