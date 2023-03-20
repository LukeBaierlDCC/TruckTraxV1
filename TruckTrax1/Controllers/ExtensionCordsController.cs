using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TruckTrax1.Data;
using TruckTrax1.Models;

namespace TruckTrax1.Controllers
{
    public class ExtensionCordsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExtensionCordsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ExtensionCords
        public async Task<IActionResult> Index()
        {
            return View(await _context.ExtensionCords.ToListAsync());
        }

        // GET: ExtensionCords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extensionCords = await _context.ExtensionCords
                .FirstOrDefaultAsync(m => m.Id == id);
            if (extensionCords == null)
            {
                return NotFound();
            }

            return View(extensionCords);
        }

        // GET: ExtensionCords/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExtensionCords/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ECBrandName,ECLengthInFeet,ECFunctionality,ECDetails,ECItemNumber,CordPrice")] ExtensionCords extensionCords)
        {
            if (ModelState.IsValid)
            {
                _context.Add(extensionCords);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(extensionCords);
        }

        // GET: ExtensionCords/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extensionCords = await _context.ExtensionCords.FindAsync(id);
            if (extensionCords == null)
            {
                return NotFound();
            }
            return View(extensionCords);
        }

        // POST: ExtensionCords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ECBrandName,ECLengthInFeet,ECFunctionality,ECDetails,ECItemNumber,CordPrice")] ExtensionCords extensionCords)
        {
            if (id != extensionCords.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(extensionCords);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExtensionCordsExists(extensionCords.Id))
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
            return View(extensionCords);
        }

        // GET: ExtensionCords/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extensionCords = await _context.ExtensionCords
                .FirstOrDefaultAsync(m => m.Id == id);
            if (extensionCords == null)
            {
                return NotFound();
            }

            return View(extensionCords);
        }

        // POST: ExtensionCords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var extensionCords = await _context.ExtensionCords.FindAsync(id);
            _context.ExtensionCords.Remove(extensionCords);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExtensionCordsExists(int id)
        {
            return _context.ExtensionCords.Any(e => e.Id == id);
        }
    }
}
