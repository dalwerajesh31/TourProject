using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ETourProject1.Models;
using ETourProject1.Repository;

namespace ETourProject1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassangerMasterController : ControllerBase
    {
        private readonly Appdbcontext _context;

        public PassangerMasterController(Appdbcontext context)
        {
            _context = context;
        }

        // GET: api/PassangerMaster
        [HttpGet]
        public IActionResult GetPassangers()
        {
            var passangers = _context.passanger_Masters.Include(p => p.BooKingHeader).ToList();
            return Ok(passangers);
        }

        // GET: api/PassangerMaster/5
        [HttpGet("{id}")]
        public IActionResult GetPassanger(int id)
        {
            var passanger = _context.passanger_Masters.Include(p => p.BooKingHeader).FirstOrDefault(p => p.PassangerId == id);

            if (passanger == null)
            {
                return NotFound();
            }

            return Ok(passanger);
        }

        // POST: api/PassangerMaster
        [HttpPost]
        public IActionResult PostPassanger(Passanger_Master passanger)
        {
            _context.passanger_Masters.Add(passanger);
            _context.SaveChanges();

            return CreatedAtAction("GetPassanger", new { id = passanger.PassangerId }, passanger);
        }

        // PUT: api/PassangerMaster/5
        [HttpPut("{id}")]
        public IActionResult PutPassanger(int id, Passanger_Master passanger)
        {
            if (id != passanger.PassangerId)
            {
                return BadRequest();
            }

            _context.Entry(passanger).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PassangerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/PassangerMaster/5
        [HttpDelete("{id}")]
        public IActionResult DeletePassanger(int id)
        {
            var passanger = _context.passanger_Masters.Find(id);
            if (passanger == null)
            {
                return NotFound();
            }

            _context.passanger_Masters.Remove(passanger);
            _context.SaveChanges();

            return NoContent();
        }

        private bool PassangerExists(int id)
        {
            return _context.passanger_Masters.Any(p => p.PassangerId == id);
        }
    }
}
