using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ETourProject1.Models;
using ETourProject1.Repository;
using WebApplicationOneToMany.Models;
using NuGet.Protocol.Core.Types;

namespace ETourProject1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Date_MasterController : ControllerBase
    {
        private readonly IDate_Masterinterface _context;

        public Date_MasterController(IDate_Masterinterface context)
        {
            _context = context;
        }

        // GET: api/Date_Master
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Date_Master>>> GetDate()
        {
          if (_context.GetAllDate_Master == null)
          {
              return NotFound();
          }
            return await _context.GetAllDate_Master();
        }

        // GET: api/Date_Master/5
        [HttpGet("{date:datetime}")]
        public async Task<ActionResult<Date_Master>> GetByDate(DateTime date)
        {
            var dateEntity = await _context.GetDate(date);
            return date == null ? NotFound() : dateEntity ;
        }

        // PUT: api/Date_Master/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id, Date_Master date)
        {
            if (id != date.DepartureId)
            {
                return BadRequest();
            }

            try
            {
                var updatedDate = await _context.Update(id, date);
                if (updatedDate == null)
                {
                    return NotFound();
                }

                return NoContent();
            }
            catch (DbUpdateConcurrencyException)
            {
                var dateActionResult = await _context.GetDate(id);
                if (dateActionResult.Value == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }


        // POST: api/Date_Master
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

        [HttpPost]
        public async Task<ActionResult<Date_Master>> Date_Master(Date_Master date)
        {
            await _context.Add(date);
            return CreatedAtAction("PostBook", new { id = date.DepartureId }, date);
        }
        // DELETE: api/Date_Master/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (_context.GetAllDate_Master() == null)
            {
                return NotFound();
            }

            await _context.Delete(id);
            return NoContent();
        }

    }
}
