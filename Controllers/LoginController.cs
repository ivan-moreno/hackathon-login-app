using HackathonLoginApp.Contexts;
using HackathonLoginApp.Models.Views;
using Microsoft.AspNetCore.Mvc;

namespace HackathonLoginApp.Controllers;

public sealed class LoginController : Controller
{
    private readonly AppDbContext _context;

    public LoginController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login([Bind("Username,Password")] LoginViewModel model)
    {
        var foundUser = _context.Users.FirstOrDefault(x => x.Username.Equals(model.Username));

        if (foundUser is null)
        {
            model.UsernameNotFound = true;
            return View("Index", model);
        }

        if (string.IsNullOrWhiteSpace(model.Password))
        {
            model.EmptyPassword = true;
            return View("Index", model);
        }

        var encryptedPassword = Encryption.Encrypt(model.Password);
        var passwordsMatch = string.Equals(
            encryptedPassword,
            foundUser.Password,
            StringComparison.Ordinal);

        if (!passwordsMatch)
        {
            model.WrongPassword = true;
            return View("Index", model);
        }

        model.LoginSuccess = true;

        return View("Index", model);
    }
}
