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
    public class AdoptApplicationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdoptApplicationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdoptApplications
        public async Task<IActionResult> Index()
        {
            return View(await _context.AdoptApplication.ToListAsync());
        }

        // GET: AdoptApplications/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adoptApplication = await _context.AdoptApplication
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adoptApplication == null)
            {
                return NotFound();
            }

            return View(adoptApplication);
        }

        // GET: AdoptApplications/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdoptApplications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Status,DateRegistered,DateApproved,DateRejected,DateDeleted,PeopleAtHome,ChildrenAtHome,ChildrenAges,HomeAntiguety,LandlordConsentForPets,LandlordInformation,Strata,MovingNextSixMonths,PetIsAGift,TimeThoughtToGetAPet,WhyAPet,FoodEstimateExpense,MedicalEstimateExpense,MiscEstimateExpense,EmergencyEstimateExpense,InitialsProvideEssentials,InitialsNurturingEnvironment,InitialsAnimalControlByLaw,InitialsContactAnimalShelter,Initials14DaysReturn,SignatureApplication,userEmail")] AdoptApplication adoptApplication)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adoptApplication);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adoptApplication);
        }

        // GET: AdoptApplications/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adoptApplication = await _context.AdoptApplication.FindAsync(id);
            if (adoptApplication == null)
            {
                return NotFound();
            }
            return View(adoptApplication);
        }

        // POST: AdoptApplications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Status,DateRegistered,DateApproved,DateRejected,DateDeleted,PeopleAtHome,ChildrenAtHome,ChildrenAges,HomeAntiguety,LandlordConsentForPets,LandlordInformation,Strata,MovingNextSixMonths,PetIsAGift,TimeThoughtToGetAPet,WhyAPet,FoodEstimateExpense,MedicalEstimateExpense,MiscEstimateExpense,EmergencyEstimateExpense,InitialsProvideEssentials,InitialsNurturingEnvironment,InitialsAnimalControlByLaw,InitialsContactAnimalShelter,Initials14DaysReturn,SignatureApplication,userEmail")] AdoptApplication adoptApplication)
        {
            if (id != adoptApplication.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adoptApplication);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdoptApplicationExists(adoptApplication.Id))
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
            return View(adoptApplication);
        }

        // GET: AdoptApplications/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adoptApplication = await _context.AdoptApplication
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adoptApplication == null)
            {
                return NotFound();
            }

            return View(adoptApplication);
        }

        // POST: AdoptApplications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var adoptApplication = await _context.AdoptApplication.FindAsync(id);
            _context.AdoptApplication.Remove(adoptApplication);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdoptApplicationExists(string id)
        {
            return _context.AdoptApplication.Any(e => e.Id == id);
        }
    }
}
