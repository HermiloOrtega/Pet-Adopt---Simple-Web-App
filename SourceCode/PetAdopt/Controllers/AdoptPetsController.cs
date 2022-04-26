using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetAdopt.Data;
using PetAdopt.Models;

namespace PetAdopt.Controllers
{
    public class AdoptPetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdoptPetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdoptPets
        public async Task<IActionResult> Index()
        {
            return View(await _context.AdoptApplication.ToListAsync());
        }

        // GET: AdoptPets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adoptPet = await _context.AdoptApplication
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adoptPet == null)
            {
                return NotFound();
            }

            return View(adoptPet);
        }

        // GET: AdoptPets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdoptPets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Status,DateRegistered")] AdoptionForm adoptPet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adoptPet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adoptPet);
        }

        // GET: AdoptPets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adoptPet = await _context.AdoptApplication.FindAsync(id);
            if (adoptPet == null)
            {
                return NotFound();
            }
            return View(adoptPet);
        }

        // POST: AdoptPets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Status,DateRegistered")] AdoptionForm adoptPet)
        {
            if (id != adoptPet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adoptPet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdoptPetExists(adoptPet.Id))
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
            return View(adoptPet);
        }

        // GET: AdoptPets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adoptPet = await _context.AdoptApplication
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adoptPet == null)
            {
                return NotFound();
            }

            return View(adoptPet);
        }

        // POST: AdoptPets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adoptPet = await _context.AdoptApplication.FindAsync(id);
            _context.AdoptApplication.Remove(adoptPet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdoptPetExists(int id)
        {
            return _context.AdoptApplication.Any(e => e.Id == id);
        }
    }
}
