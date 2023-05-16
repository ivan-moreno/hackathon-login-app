using Microsoft.AspNetCore.Mvc;

namespace HackathonLoginApp.Controllers;

public sealed class RegisterController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
