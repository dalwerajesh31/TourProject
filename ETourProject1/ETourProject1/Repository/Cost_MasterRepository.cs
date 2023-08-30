using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETourProject1.Repository
{
    public class Cost_MasterRepository : ICost_MasterInterface
    {
        private readonly Appdbcontext context;
        public async Task<ActionResult<Cost_Master>> Add(Cost_Master cost)
        {
            context.Cost.Add(cost);
            await context.SaveChangesAsync();
            return cost;
        }

        public async Task<Cost_Master> Delete(int id)
        {
            Cost_Master cost = context.Cost.Find(id);
            if (cost != null)
            {
                context.Cost.Remove(cost);
                await context.SaveChangesAsync();
            }
            return cost;
        }

        public ActionResult<IEnumerable<dynamic>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Cost_Master>>> GetAllCost()
        {
            if (context.Cost == null)
            {
                return null;
            }
            return await context.Cost.ToListAsync();
        }

        public async Task<ActionResult<Cost_Master>> GetCost(int id)
        {
            var cost = await context.Cost.FindAsync(id);
            return cost;
        }

        public async Task<Cost_Master?> Update(int id, Cost_Master cost)
        {
            if (id != cost.CostId)
            {
                return null;
            }
            context.Entry(cost).State = EntityState.Modified;
            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CostExists(id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
            return cost;
        }

        private bool CostExists(int id)
        {
            return (context.Cost?.Any(e => e.CostId == id)).GetValueOrDefault();
        }
    }
}
