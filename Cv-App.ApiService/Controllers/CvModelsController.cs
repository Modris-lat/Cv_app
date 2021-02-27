using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cv_App.Core.Models;
using Cv_App.Data.Models;

namespace Cv_App.ApiService.Controllers
{
    public class CvModelsController : Controller
    {
        private readonly CvAppContext _context;

        public CvModelsController(CvAppContext context)
        {
            _context = context;
        }

        // GET: CvModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.CvModels.ToListAsync());
        }

        // GET: CvModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cvModel = await _context.CvModels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cvModel == null)
            {
                return NotFound();
            }

            return View(cvModel);
        }

        // GET: CvModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CvModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] CvModel cvModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cvModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cvModel);
        }

        // GET: CvModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cvModel = await _context.CvModels.FindAsync(id);
            if (cvModel == null)
            {
                return NotFound();
            }
            return View(cvModel);
        }

        // POST: CvModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] CvModel cvModel)
        {
            if (id != cvModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cvModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CvModelExists(cvModel.Id))
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
            return View(cvModel);
        }

        // GET: CvModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cvModel = await _context.CvModels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cvModel == null)
            {
                return NotFound();
            }

            return View(cvModel);
        }

        // POST: CvModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cvModel = await _context.CvModels.FindAsync(id);
            _context.CvModels.Remove(cvModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CvModelExists(int id)
        {
            return _context.CvModels.Any(e => e.Id == id);
        }
    }
}
