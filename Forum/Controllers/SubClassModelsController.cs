using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Forum.Data;
using Forum.Models;

namespace Forum.Controllers
{
    public class SubClassModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubClassModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SubClassModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.SubClassModel.ToListAsync());
        }

        // GET: SubClassModels/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subClassModel = await _context.SubClassModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subClassModel == null)
            {
                return NotFound();
            }

            return View(subClassModel);
        }

        // GET: SubClassModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SubClassModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Creator,Title,Description,dateTime")] SubClassModel subClassModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subClassModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subClassModel);
        }

        // GET: SubClassModels/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subClassModel = await _context.SubClassModel.FindAsync(id);
            if (subClassModel == null)
            {
                return NotFound();
            }
            return View(subClassModel);
        }

        // POST: SubClassModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Creator,Title,Description,dateTime")] SubClassModel subClassModel)
        {
            if (id != subClassModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subClassModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubClassModelExists(subClassModel.Id))
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
            return View(subClassModel);
        }

        // GET: SubClassModels/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subClassModel = await _context.SubClassModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subClassModel == null)
            {
                return NotFound();
            }

            return View(subClassModel);
        }

        // POST: SubClassModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var subClassModel = await _context.SubClassModel.FindAsync(id);
            _context.SubClassModel.Remove(subClassModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubClassModelExists(string id)
        {
            return _context.SubClassModel.Any(e => e.Id == id);
        }
    }
}
