using HackathonLoginApp.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HackathonLoginApp.Controllers;

public sealed class UsersController : Controller
{
    private readonly AppDbContext _context;

    public UsersController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return _context.Users != null
            ? View(await _context.Users.ToListAsync())
            : Problem("Entity set 'AppDbContext.Users'  is null.");
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null || _context.Users == null)
            return NotFound();

        var user = await _context.Users
            .FirstOrDefaultAsync(m => m.Id == id);

        return user == null
            ? NotFound()
            : View(user);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Username,Password,DisplayName")] User user)
    {
        var usernameAlreadyExists = _context.Users.Any(x => x.Username.Equals(user.Username));

        user.Password = Encryption.Encrypt(user.Password);
        user.RegistrationDate = DateTime.Now;

        if (ModelState.IsValid && !usernameAlreadyExists)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View(user);
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null || _context.Users == null)
            return NotFound();

        var user = await _context.Users.FindAsync(id);

        return user == null ? NotFound() : View(user);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Username,Password,DisplayName,RegistrationDate")] User user)
    {
        if (id != user.Id)
            return NotFound();

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(user);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(user.Id))
                    return NotFound();
                else
                    throw;
            }

            return RedirectToAction(nameof(Index));
        }

        return View(user);
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null || _context.Users == null)
        {
            return NotFound();
        }

        var user = await _context.Users
            .FirstOrDefaultAsync(m => m.Id == id);

        return user == null ? NotFound() : View(user);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        if (_context.Users == null)
        {
            return Problem("Entity set 'AppDbContext.Users'  is null.");
        }

        var user = await _context.Users.FindAsync(id);
        if (user != null)
        {
            _context.Users.Remove(user);
        }

        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    private bool UserExists(int id)
    {
        return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}
