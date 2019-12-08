using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AuctioinSite.Data;
using AuctionSite.Models;

namespace AuctionSite.Controllers
{
    public class ListingViewModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListingViewModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ListingViewModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.ListingViewModel.ToListAsync());
        }

        // GET: ListingViewModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listingViewModel = await _context.ListingViewModel
                .FirstOrDefaultAsync(m => m.listingId == id);
            if (listingViewModel == null)
            {
                return NotFound();
            }

            return View(listingViewModel);
        }

        // GET: ListingViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ListingViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("listingId,listingName,listingAuthor,listItemCondition,isShipping,listingBuyOutPrice,lisingStartingPrice,listingPostDate,listingEndDate,listingDescription,listingCategory,listingImageURL")] ListingViewModel listingViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listingViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(listingViewModel);
        }

        // GET: ListingViewModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listingViewModel = await _context.ListingViewModel.FindAsync(id);
            if (listingViewModel == null)
            {
                return NotFound();
            }
            return View(listingViewModel);
        }

        // POST: ListingViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("listingId,listingName,listItemCondition,isShipping,listingBuyOutPrice,lisingStartingPrice,listingPostDate,listingEndDate,listingDescription,listingCategory,listingImageURL")] ListingViewModel listingViewModel)
        {
            if (id != listingViewModel.listingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listingViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListingViewModelExists(listingViewModel.listingId))
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
            return View(listingViewModel);
        }

        // GET: ListingViewModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listingViewModel = await _context.ListingViewModel
                .FirstOrDefaultAsync(m => m.listingId == id);
            if (listingViewModel == null)
            {
                return NotFound();
            }

            return View(listingViewModel);
        }

        // POST: ListingViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listingViewModel = await _context.ListingViewModel.FindAsync(id);
            _context.ListingViewModel.Remove(listingViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListingViewModelExists(int id)
        {
            return _context.ListingViewModel.Any(e => e.listingId == id);
        }
    }
}
