using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class LectureController : Controller
    {
        // GET
        public IActionResult Index()
        {
            Lecture lec=new Lecture();
            lec.id = 123456;
            lec.fname = "babette";
            lec.lname = "regis";
            lec.course = "net";

            ViewBag.data = lec;

            return View();
        }

        public IActionResult GetAll()
        {
            return View();
        }
    }
}