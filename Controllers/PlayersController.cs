using Microsoft.AspNetCore.Mvc;
using parcial.Models;
using Microsoft.Extensions.Logging;
using parcial.Data;

namespace parcial.Controllers
{
    public class PlayersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlayersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Listar()
        {
            var players = _context.Players.ToList();
            return View(players);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Players player, int EquipoActual)
        {
            if (ModelState.IsValid)
            {
                _context.Players.Add(player);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(player);
        }
    }
}