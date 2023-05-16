using Microsoft.AspNetCore.Mvc;

namespace HackathonLoginApp.Controllers;

public class RegisterController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
