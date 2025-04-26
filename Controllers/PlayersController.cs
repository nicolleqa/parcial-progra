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
            ViewBag.Equipos = _context.Teams.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Players player)
        {
            if (ModelState.IsValid)
            {
                _context.Players.Add(player);
                _context.SaveChanges();

                var equipo = _context.Teams.FirstOrDefault(t => t.Nombre == player.Equipo);
                if (equipo != null)
                {
                    var playersTeams = new PlayersTeams
                    {
                        IdPlayer = player.Id,
                        IdTeam = equipo.Id
                    };
                    _context.PlayersTeams.Add(playersTeams);
                    _context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View("Index", player);
        }
    }
}