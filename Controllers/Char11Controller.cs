using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcChar1.Data;
using MvcChar1.Models;

namespace MvcChar1.Controllers
{
    public class Char11Controller : Controller
    {
        private readonly MvcChar1Context _context;

        public Char11Controller(MvcChar1Context context)
        {
            _context = context;
        }

        // GET: Char11
        public async Task<IActionResult> Index(string searchString)
        {
            var chars = from c in _context.Char1
                        select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                chars = chars.Where(d => d.Name.Contains(searchString));
            }

            return View(await chars.ToListAsync());
        }

        // GET: Char11/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var char1 = await _context.Char1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (char1 == null)
            {
                return NotFound();
            }

            return View(char1);
        }

        // GET: Char11/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Char11/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Class,Race,Ac,Hp,Str,Con,Dex,Wis,Ine,Cha")] Char1 char1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(char1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(char1);
        }

        // GET: Char11/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var char1 = await _context.Char1.FindAsync(id);
            if (char1 == null)
            {
                return NotFound();
            }
            return View(char1);
        }

        // POST: Char11/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Class,Race,Ac,Hp,Str,Con,Dex,Wis,Ine,Cha")] Char1 char1)
        {
            if (id != char1.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(char1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Char1Exists(char1.Id))
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
            return View(char1);
        }

        // GET: Char11/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var char1 = await _context.Char1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (char1 == null)
            {
                return NotFound();
            }

            return View(char1);
        }

        // POST: Char11/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var char1 = await _context.Char1.FindAsync(id);
            _context.Char1.Remove(char1);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Char1Exists(int id)
        {
            return _context.Char1.Any(e => e.Id == id);
        }
    }
}
