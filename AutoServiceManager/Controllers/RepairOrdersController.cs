using AutoServiceManager.Data;
using AutoServiceManager.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AutoServiceManager.Controllers
{
    public class RepairOrdersController : Controller
    {
        private readonly AutoServiceDbContext _context;

        public RepairOrdersController(AutoServiceDbContext context)
        {
            _context = context;
        }

        // GET: RepairOrders
        public async Task<IActionResult> Index()
        {
            var autoServiceDbContext = _context.RepairOrders.Include(r => r.Car);
            return View(await autoServiceDbContext.ToListAsync());
        }

        // GET: RepairOrders/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var repairOrder = await _context.RepairOrders
                .Include(r => r.Car)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (repairOrder == null)
            {
                return NotFound();
            }

            return View(repairOrder);
        }

        // GET: RepairOrders/Create
        public IActionResult Create()
        {
            ViewData["CarId"] = new SelectList(_context.Cars, "Id", "Make");
            return View();
        }

        // POST: RepairOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CarId,Date,Problem,Status,Price")] RepairOrder repairOrder)
        {
            if (ModelState.IsValid)
            {
                repairOrder.Id = Guid.NewGuid();
                _context.Add(repairOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CarId"] = new SelectList(_context.Cars, "Id", "Make", repairOrder.CarId);
            return View(repairOrder);
        }

        // GET: RepairOrders/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var repairOrder = await _context.RepairOrders.FindAsync(id);
            if (repairOrder == null)
            {
                return NotFound();
            }
            ViewData["CarId"] = new SelectList(_context.Cars, "Id", "Make", repairOrder.CarId);
            return View(repairOrder);
        }

        // POST: RepairOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,CarId,Date,Problem,Status,Price")] RepairOrder repairOrder)
        {
            if (id != repairOrder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(repairOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RepairOrderExists(repairOrder.Id))
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
            ViewData["CarId"] = new SelectList(_context.Cars, "Id", "Make", repairOrder.CarId);
            return View(repairOrder);
        }

        // GET: RepairOrders/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var repairOrder = await _context.RepairOrders
                .Include(r => r.Car)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (repairOrder == null)
            {
                return NotFound();
            }

            return View(repairOrder);
        }

        // POST: RepairOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var repairOrder = await _context.RepairOrders.FindAsync(id);
            if (repairOrder != null)
            {
                _context.RepairOrders.Remove(repairOrder);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RepairOrderExists(Guid id)
        {
            return _context.RepairOrders.Any(e => e.Id == id);
        }
    }
}
