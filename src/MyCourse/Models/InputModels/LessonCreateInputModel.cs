using MyCourse.Models.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyCourse.Models.InputModels
{
    public class LessonCreateInputModel 
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public int courseId { get; set; }
    }
}
