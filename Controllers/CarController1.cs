using Microsoft.AspNetCore.Mvc;
using MVCQuiz.Models;

namespace MVCQuiz.Controllers
{
    public class CarController : Controller
    {

        public IActionResult Model(string year, string name, string color)
        {
            Car car = new Car { name = name ?? "Car", year = year ?? "Unknown", color = color ?? "red" };
            return View(car);
        }
    }
}
