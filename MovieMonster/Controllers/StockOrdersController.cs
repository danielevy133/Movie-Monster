﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieMonster.Data;
using MovieMonster.Models;

namespace MovieMonster.Controllers
{
    public class StockOrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StockOrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StockOrders
        public async Task<IActionResult> Index()
        {
            //include Movies from MovieStockOrder
            var applicationDbContext = _context.StockOrder.Include(s => s.Supplier).Include(m => m.Movies).Include("Movies.Movie");
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: StockOrders/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stockOrder = await _context.StockOrder
                .Include(s => s.Supplier)
                .FirstOrDefaultAsync(m => m.StockOrderID == id);
            if (stockOrder == null)
            {
                return NotFound();
            }

            return View(stockOrder);
        }

        // GET: StockOrders/Create
        public IActionResult Create()
        {
            ViewData["SupplierID"] = new SelectList(_context.Set<Supplier>(), "SupplierID", "SupplierID");
            return View();
        }

        // POST: StockOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StockOrderID,SupplierID,TotalPrice")] StockOrder stockOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stockOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SupplierID"] = new SelectList(_context.Set<Supplier>(), "SupplierID", "SupplierID", stockOrder.SupplierID);
            return View(stockOrder);
        }

        // GET: StockOrders/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stockOrder = await _context.StockOrder.FindAsync(id);
            if (stockOrder == null)
            {
                return NotFound();
            }
            ViewData["SupplierID"] = new SelectList(_context.Set<Supplier>(), "SupplierID", "SupplierID", stockOrder.SupplierID);
            return View(stockOrder);
        }

        // POST: StockOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StockOrderID,SupplierID,TotalPrice")] StockOrder stockOrder)
        {
            if (id != stockOrder.StockOrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stockOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StockOrderExists(stockOrder.StockOrderID))
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
            ViewData["SupplierID"] = new SelectList(_context.Set<Supplier>(), "SupplierID", "SupplierID", stockOrder.SupplierID);
            return View(stockOrder);
        }

        // GET: StockOrders/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stockOrder = await _context.StockOrder
                .Include(s => s.Supplier)
                .FirstOrDefaultAsync(m => m.StockOrderID == id);
            if (stockOrder == null)
            {
                return NotFound();
            }

            return View(stockOrder);
        }

        // POST: StockOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var stockOrder = await _context.StockOrder.FindAsync(id);
            _context.StockOrder.Remove(stockOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StockOrderExists(string id)
        {
            return _context.StockOrder.Any(e => e.StockOrderID == id);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<string> AdvancedSearch([Bind("StockOrderID,SupplierID,TotalPrice")] StockOrder searchStockOrder)
        {
            var result = _context.StockOrder.AsQueryable();
            if (searchStockOrder != null)
            {
                if (searchStockOrder.StockOrderID != null)
                    result = result.Where(stockOrder => stockOrder.StockOrderID == searchStockOrder.StockOrderID);
                if (searchStockOrder.SupplierID != null)
                    result = result.Where(stockOrder => stockOrder.SupplierID == searchStockOrder.SupplierID);
                if (searchStockOrder.TotalPrice != 0)
                    result = result.Where(stockOrder => stockOrder.TotalPrice == searchStockOrder.TotalPrice);
            }
            var list = await result.ToListAsync();
            var listJason = Newtonsoft.Json.JsonConvert.SerializeObject(list);
            return listJason;
        }
    }
}
