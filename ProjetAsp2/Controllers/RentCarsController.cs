using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetAsp2.Data;
using ProjetAsp2.Models;

namespace ProjetAsp2.Controllers
{
    public class RentCarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RentCarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RentCars
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.RentCar.Include(r => r.Car).Include(r => r.driver);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RentCars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentCar = await _context.RentCar
                .Include(r => r.Car)
                .Include(r => r.driver)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rentCar == null)
            {
                return NotFound();
            }

            return View(rentCar);
        }

        // GET: RentCars/Create
        
        public IActionResult Create()
        {
            ViewData["CarId"] = new SelectList(_context.Car, "Id", "Nom");
            ViewData["DriverId"] = new SelectList(_context.Driver, "Id", "FullName");
            return View();
        }
     
        // POST: RentCars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,Adresse,Email,Tel,StartDate,EndDate,CarId,DriverId")] RentCar rentCar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rentCar);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "", null);
               
            }
            ViewData["CarId"] = new SelectList(_context.Car, "Id", "CarPicture", rentCar.CarId);
            ViewData["DriverId"] = new SelectList(_context.Driver, "Id", "Adresse", rentCar.DriverId);
            return View(rentCar);
        }

        // GET: RentCars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentCar = await _context.RentCar.FindAsync(id);
            if (rentCar == null)
            {
                return NotFound();
            }
            ViewData["CarId"] = new SelectList(_context.Car, "Id", "CarPicture", rentCar.CarId);
            ViewData["DriverId"] = new SelectList(_context.Driver, "Id", "Adresse", rentCar.DriverId);
            return View(rentCar);
        }

        // POST: RentCars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Adresse,Email,Tel,StartDate,EndDate,CarId,DriverId")] RentCar rentCar)
        {
            if (id != rentCar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentCar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentCarExists(rentCar.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CarId"] = new SelectList(_context.Car, "Id", "CarPicture", rentCar.CarId);
            ViewData["DriverId"] = new SelectList(_context.Driver, "Id", "Adresse", rentCar.DriverId);
            return View(rentCar);
        }

        // GET: RentCars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentCar = await _context.RentCar
                .Include(r => r.Car)
                .Include(r => r.driver)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rentCar == null)
            {
                return NotFound();
            }

            return View(rentCar);
        }

        // POST: RentCars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rentCar = await _context.RentCar.FindAsync(id);
            _context.RentCar.Remove(rentCar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentCarExists(int id)
        {
            return _context.RentCar.Any(e => e.Id == id);
        }
    }
}
