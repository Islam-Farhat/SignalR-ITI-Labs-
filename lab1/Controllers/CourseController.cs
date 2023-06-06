using lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab1.Controllers
{
    public class CourseController : Controller
    {
        private readonly SignalRContext _context;

        public CourseController(SignalRContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowCourse()
        {
           
            return View(_context.Courses.ToList());
        }
    }
}
