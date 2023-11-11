using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.Entities;

namespace Lab3.Controllers
{
    public class AlbumEntitiesController : Controller
    {
        private readonly AppDbContext _context;

        public AlbumEntitiesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ContactEntities
        public async Task<IActionResult> Index()
        {
              return _context.Albums != null ? 
                          View(await _context.Albums.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Albums'  is null.");
        }

        // GET: ContactEntities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Albums == null)
            {
                return NotFound();
            }

            var albumEntity = await _context.Albums
                .FirstOrDefaultAsync(m => m.AlbumId == id);
            if (albumEntity == null)
            {
                return NotFound();
            }

            return View(albumEntity);
        }

        // GET: ContactEntities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactEntities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlbumId,Name,Band,TrackList,Record,ReleaseDate,Duration")] AlbumEntity albumEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(albumEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(albumEntity);
        }

        // GET: ContactEntities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Albums == null)
            {
                return NotFound();
            }

            var albumEntity = await _context.Albums.FindAsync(id);
            if (albumEntity == null)
            {
                return NotFound();
            }
            return View(albumEntity);
        }

        // POST: ContactEntities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlbumId,Name,Band,TrackList,Record,ReleaseDate,Duration")] AlbumEntity albumEntity)
        {
            if (id != albumEntity.AlbumId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(albumEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlbumEntityExists(albumEntity.AlbumId))
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
            return View(albumEntity);
        }

        // GET: ContactEntities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Albums == null)
            {
                return NotFound();
            }

            var albumEntity = await _context.Albums
                .FirstOrDefaultAsync(m => m.AlbumId == id);
            if (albumEntity == null)
            {
                return NotFound();
            }

            return View(albumEntity);
        }

        // POST: ContactEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Albums == null)
            {
                return Problem("Entity set 'AppDbContext.Albums'  is null.");
            }
            var albumEntity = await _context.Albums.FindAsync(id);
            if (albumEntity != null)
            {
                _context.Albums.Remove(albumEntity);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlbumEntityExists(int id)
        {
          return (_context.Albums?.Any(e => e.AlbumId == id)).GetValueOrDefault();
        }
    }
}
