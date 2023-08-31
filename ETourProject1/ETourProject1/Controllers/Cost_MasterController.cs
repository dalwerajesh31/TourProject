using System;
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
    public class Cost_MasterController : ControllerBase
    {
        private readonly ICost_MasterInterface _repository;

        public Cost_MasterController(ICost_MasterInterface repository)
        {
            _repository = repository;
        }



        // GET: api/Cost_Master
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cost_Master>>> GetCost()
        {
          if (await _repository.GetAllCost() == null)
          {
              return NotFound();
          }
            return await _repository.GetAllCost();
        }

        // GET: api/Cost_Master/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Cost_Master>> GetByCostId(int id)
        {
            var cost = await _repository.GetCost(id);
            return cost == null ? NotFound() : cost;
        }


        // PUT: api/Cost_Master/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCost_Master(int id, Cost_Master cost)
        {
            if (id != cost.CostId)
            {
                return BadRequest();
            }

           // _repository.Entry(cost_Master).State = EntityState.Modified;

            try
            {
                await _repository.Update(id, cost);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_repository.GetCost(id) == null)
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

        // POST: api/Cost_Master
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cost_Master>> PostCost_Master(Cost_Master cost)
        {
            await _repository.Add(cost);

            return CreatedAtAction("GetCost_Master", new { id = cost.CostId }, cost);
        }

        // DELETE: api/Cost_Master/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCost_Master(int id)
        {
            if (_repository.GetAllCost() == null)
            {
                return NotFound();
            }

            await _repository.Delete(id);

            return Ok();
        }
    }
}
