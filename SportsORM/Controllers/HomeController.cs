using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {   
                ViewBag.WomenLeagues = _context.Leagues
                .Where(l => l.Name.Contains("Womens"))
                .ToList();
                ViewBag.HockeyLeagues = _context.Leagues
                .Where(l => l.Name.Contains("Hockey"))
                .ToList();
                ViewBag.NotFootball = _context.Leagues
                .Where(l => !l.Name.Contains("Football"))
                .ToList();
                ViewBag.Conference = _context.Leagues
                .Where(l => l.Name.Contains("Conference"))
                .ToList();
                ViewBag.Atlantic = _context.Leagues
                .Where(l => l.Name.Contains("Atlantic"))
                .ToList();
                ViewBag.DallasTeams = _context.Teams
                .Where(l => l.Location.Contains("Dallas"))
                .ToList();
                ViewBag.RaptorTeams = _context.Teams
                .Where(l => l.TeamName.Contains("Raptors"))
                .ToList();
                ViewBag.TheTeams = _context.Teams
                .Where(l => l.Location.Contains("City"))
                .ToList();
                ViewBag.TName = _context.Teams
                .Where(l => l.TeamName.Contains("T"))
                .ToList();
                ViewBag.SortTeams = _context.Teams
                .OrderBy(l => l.TeamName);
                ViewBag.TName = _context.Teams
                .Where(l => l.TeamName.Contains("T"))
                .ToList();
                ViewBag.TName = _context.Teams
                .Where(l => l.TeamName.Contains("T"))
                .ToList();
                ViewBag.TName = _context.Teams
                .Where(l => l.TeamName.Contains("T"))
                .ToList();

            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}