using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetAdopt.Data;
using PetAdopt.Models;

namespace PetAdopt.Controllers
{
    public class PetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pets
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pet.ToListAsync());
        }

        [Authorize]
        // GET: Pets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pet pet = await _context.Pet.FirstOrDefaultAsync(m => m.Id == id);
            if (pet == null) return NotFound();

            PetDetailsViewModel viewModel = await getPetDetailsViewModelFromPet(pet);

            return View(viewModel);
        }

        [Authorize]
        // POST: Pet/Details
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details([Bind("Type,Adopted,Name,Location,PhotoURL,Breed,Color,Age,Size,Gender,Description,HouseTrained,AdoptionFee")] PetDetailsViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                AdoptPet adopt = new AdoptPet();

                adopt.Status = (AdoptPet.ApplicationStatus)viewModel.Status;
                adopt.DateRegistered = viewModel.DateRegistered;

                Pet pet = await _context.Pet.FirstOrDefaultAsync(m => m.Id == viewModel.PetID);
                if (pet == null) return NotFound();

                adopt.Pet = pet;
                _context.AdoptApplication.Add(adopt);
                await _context.SaveChangesAsync();

                viewModel = await getPetDetailsViewModelFromPet(pet);
            }
            return View(viewModel);
        }

        private async Task<PetDetailsViewModel> getPetDetailsViewModelFromPet(Pet pet)
        {
            PetDetailsViewModel viewModel = new PetDetailsViewModel();
            viewModel.Pet = pet;

            List<AdoptPet> adoptPets = await _context.AdoptApplication
                .Where(m => m.Pet == pet).ToListAsync();

            viewModel.AdoptPets = adoptPets;

            return viewModel;
        }

        [Authorize]
        // GET: Pets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,Adopted,Name,Location,PhotoURL,Breed,Color,Age,Size,Gender,Description,HouseTrained,AdoptionFee")] Pet pet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pet);
        }

        [Authorize]
        // GET: Pets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _context.Pet.FindAsync(id);
            if (pet == null)
            {
                return NotFound();
            }
            return View(pet);
        }

        // POST: Pets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,Adopted,Name,Location,PhotoURL,Breed,Color,Age,Size,Gender,Description,HouseTrained,AdoptionFee")] Pet pet)
        {
            if (id != pet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PetExists(pet.Id))
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
            return View(pet);
        }

        [Authorize]
        // GET: Pets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _context.Pet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }

        [Authorize]
        // POST: Pets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pet = await _context.Pet.FindAsync(id);
            _context.Pet.Remove(pet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PetExists(int id)
        {
            return _context.Pet.Any(e => e.Id == id);
        }
    }
}
