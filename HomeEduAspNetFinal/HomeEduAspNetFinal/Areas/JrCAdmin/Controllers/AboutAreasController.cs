using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HomeEduAspNetFinal.DAL;
using HomeEduAspNetFinal.Models;

namespace HomeEduAspNetFinal.Areas.JrCAdmin.Controllers
{
    [Area("JrCAdmin")]
    public class AboutAreasController : Controller
    {
        private readonly AppDbContext _context;

        public AboutAreasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: JrCAdmin/AboutAreas
        public async Task<IActionResult> Index()
        {
            return View(await _context.AboutAreas.ToListAsync());
        }

        // GET: JrCAdmin/AboutAreas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutArea = await _context.AboutAreas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aboutArea == null)
            {
                return NotFound();
            }

            return View(aboutArea);
        }

        // GET: JrCAdmin/AboutAreas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JrCAdmin/AboutAreas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Image")] AboutArea aboutArea)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aboutArea);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aboutArea);
        }

        // GET: JrCAdmin/AboutAreas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutArea = await _context.AboutAreas.FindAsync(id);
            if (aboutArea == null)
            {
                return NotFound();
            }
            return View(aboutArea);
        }

        // POST: JrCAdmin/AboutAreas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Image")] AboutArea aboutArea)
        {
            if (id != aboutArea.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aboutArea);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutAreaExists(aboutArea.Id))
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
            return View(aboutArea);
        }

        // GET: JrCAdmin/AboutAreas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutArea = await _context.AboutAreas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aboutArea == null)
            {
                return NotFound();
            }

            return View(aboutArea);
        }

        // POST: JrCAdmin/AboutAreas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aboutArea = await _context.AboutAreas.FindAsync(id);
            _context.AboutAreas.Remove(aboutArea);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AboutAreaExists(int id)
        {
            return _context.AboutAreas.Any(e => e.Id == id);
        }
    }
}
