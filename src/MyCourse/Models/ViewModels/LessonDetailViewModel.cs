using System;
using System.Collections.Generic;

namespace MyCourse.Models.ViewModels
{
    public class LessonDetailViewModel : LessonViewModel
    {
        public int Ordinamento { get; set; }
        public int CourseId { get; set; }
    }
}
