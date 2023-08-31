﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ETourProject1.Models;
using ETourProject1.Repository;

namespace ETourProject1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItinerariesController : ControllerBase
    {
        private readonly Appdbcontext _context;

        public ItinerariesController(Appdbcontext context)
        {
            _context = context;
        }

        // GET: api/Itineraries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Itinerary_Master>>> GetItinerary()
        {
            if (_context.Itinerary_Master == null)
            {
                return NotFound();
            }
            return await _context.Itinerary_Master.ToListAsync();

          if (_context.Itinerary_Master == null)
          {
              return NotFound();
          }
            return await _context.Itinerary_Master.ToListAsync();

        }

        // GET: api/Itineraries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Itinerary_Master>> GetItinerary(int id)
        {
            if (_context.Itinerary_Master == null)
            {
                return NotFound();
            }
            var itinerary = await _context.Itinerary_Master.FindAsync(id);

          if (_context.Itinerary_Master == null)
          {
              return NotFound();
          }
            var itinerary1 = await _context.Itinerary_Master.FindAsync(id);


            if (itinerary == null)
            {
                return NotFound();
            }

            return itinerary;
        }



        // POST: api/Itineraries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Itinerary_Master>> PostItinerary(Itinerary_Master itinerary)
        {

            if (_context.Itinerary_Master == null)
            {
                return Problem("Entity set 'Appdbcontext.Itinerary'  is null.");
            }
            _context.Itinerary_Master.Add(itinerary);

          if (_context.Itinerary_Master == null)
          {
              return Problem("Entity set 'Appdbcontext.Itinerary'  is null.");
          }
            _context.Itinerary_Master.Add(itinerary);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItinerary", new { id = itinerary.ItrId }, itinerary);
        }

        private bool ItineraryExists(int id)
        {
            return (_context.Itinerary_Master?.Any(e => e.ItrId == id)).GetValueOrDefault();
        }
    }
}
