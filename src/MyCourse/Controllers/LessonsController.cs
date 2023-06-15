using Microsoft.AspNetCore.Mvc;
using MyCourse.Models.Entities;
using MyCourse.Models.InputModels;
using MyCourse.Models.Services.Application.Lesson;
using MyCourse.Models.ViewModels;
using System.Reflection;
using System.Threading.Tasks;

namespace MyCourse.Controllers
{
    public class LessonsController : Controller
    {
        private readonly ILessonService lessonService;

        public LessonsController(ILessonService lessonService)
        {
            this.lessonService = lessonService;
        }

        //[HttpGet("{controller}/{action}/{id:int}/{lId:int?}")]
        //public IActionResult Create(int id,[FromQuery] int lId)
        // {
        //    //int courseId = lesson.CourseId;
        //    ViewData["Title"] = "Aggiungi lezione";
        //    var title = "Corso...";
        //    var inputModel = new LessonCreateInputModel(title);
        //    return View(inputModel);
        //}
        public  IActionResult Create(int id)
        {
            ViewData["Title"] = "Nuova lezione";
            var inputModel = new LessonCreateInputModel();   
            inputModel.courseId = id;
            return View(inputModel);
        }
        [HttpPost]
        public IActionResult Create(LessonCreateInputModel inputModel)
        {
            if (ModelState.IsValid)
            {
                var lesson = lessonService.AddLesson(inputModel);
                return RedirectToAction(nameof(Detail),lesson.CourseId);
            }
            
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            LessonDetailViewModel viewModel = lessonService.GetLesson(id);
            ViewData["Title"] = viewModel.Title;
            return View(viewModel);
        }
    }
}
