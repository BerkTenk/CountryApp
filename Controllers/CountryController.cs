using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CountryApp.Models;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SQLitePCL;

namespace CountryApp.Controllers
{
    [Route("[controller]")]
    public class CountryController : Controller
    {
        private readonly ILogger<CountryController> _logger;
        private readonly DataContext _context;

        public CountryController(ILogger<CountryController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
            
        [HttpGet("Country/Details/{id}")]
        public IActionResult Details(int? id){
            if(id==null){
                return NotFound();
            }
            var ulke = _context.Countryler.FirstOrDefault(u => u.Id == id);
            return View(ulke);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}