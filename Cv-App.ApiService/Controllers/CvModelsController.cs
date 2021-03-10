using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cv_App.Core.Models;
using Cv_App.Services.Interfaces;

namespace Cv_App.ApiService.Controllers
{
    public class CvModelsController : Controller
    {
        private readonly ICvDataService _cvDataService;

        public CvModelsController(ICvDataService cvDataService)
        {
            _cvDataService = cvDataService;
        }

        // GET: CvModels
        public IActionResult Index()
        {
            return View(_cvDataService.GetAllCvData().ToList());
        }

        // GET: CvModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cvModel = await _cvDataService.GetCvModelAsync(id.Value);
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("CvTitle,PersonalData,Educations,WorkExperiences,Properties")] CvModel cvModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _cvDataService.Create(cvModel);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException)
            {
                ModelState.AddModelError("", "Unable to save changes.");
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

            var cvModel = await _cvDataService.GetCvModelAsync(id.Value);
            if (cvModel == null)
            {
                return NotFound();
            }
            return View(cvModel);
        }

        // POST: CvModels/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CvTitle,PersonalData,Educations,WorkExperiences,Properties")] CvModel cvModel)
        {
            if (id != cvModel.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    await _cvDataService.UpdateCv(cvModel);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("", "Unable to save changes.");
                }
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

            var cvModel = await _cvDataService.GetCvModelAsync(id.Value);
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
            var cvModel = await _cvDataService.GetById(id);
            _cvDataService.Delete(cvModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
