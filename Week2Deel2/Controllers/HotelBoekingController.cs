using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Week2Deel2.Models;
using Week2Deel2.Data;
using Microsoft.EntityFrameworkCore;

namespace Week2Deel2.Controllers
{
    public class HotelBoekingController : Controller
    {
        private readonly HotelBoekingContext _context;

        public HotelBoekingController(HotelBoekingContext context)
        {
            _context = context;
        }

        [HttpGet("HotelBoeking/Index", Name = "Index")]
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Verwerken(HotelBoeking h)
        {
            return View(h);
        }

        public IActionResult Wijzigen(HotelBoeking h)
        {
            return View(h);
        }

        [HttpGet("HotelBoeking/Create", Name = "Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet("HotelBoeking/Edit/{id}", Name ="Edit")]
        public IActionResult Edit(int id)
        {
            HotelBoeking h = _context.HotelBoekingen.Where(b => b.HotelBoekingId == id).First();
            return View(h);
        }

        public IActionResult Overzicht()
        {
            return View(_context.HotelBoekingen.ToList());
        }

        [HttpPost("HotelBoeking/Create", Name ="Create")]
        public IActionResult Create(HotelBoeking h)
        {
            _context.HotelBoekingen.Add(h);
            _context.SaveChanges();
            return RedirectToAction("Verwerken", h);
        }

        [HttpPost("HotelBoeking/Edit", Name = "Wijzigen")]
        public IActionResult Edit(HotelBoeking h)
        {
            _context.HotelBoekingen.Attach(h);
            var boeking = _context.Entry(h);
            boeking.State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Wijzigen", h);
        }
    }
}