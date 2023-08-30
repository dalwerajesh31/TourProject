using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETourProject1.Repository
{
    public class Cost_MasterRepository : ICost_MasterInterface
    {
        private readonly Appdbcontext context;

        public Cost_MasterRepository(Appdbcontext context)
        {
            this.context = context;
        }


        public async Task<ActionResult<Cost_Master>> Add(Cost_Master cost)
        {
            context.Cost.Add(cost);
            await context.SaveChangesAsync();
            return cost;
        }

        public async Task<Cost_Master> Delete(int Id)
        {
            Cost_Master cost = context.Cost.Find(Id);

            if (cost != null)
            {
                context.Cost.Remove(cost);
                await context.SaveChangesAsync();
            }
            return cost;
        }

        public async Task<ActionResult<IEnumerable<Cost_Master>>> GetAllCost()
        {
            if (context.Cost == null)
            {
                return null;
            }
            return await context.Cost.ToListAsync();
        }

        public async Task<ActionResult<Cost_Master>> GetCost(int Id)
        {
            if (context.Cost == null)
                return null;
            Cost_Master cost = await context.Cost.FindAsync(Id);

            if (cost == null)
            {
                return null;
            }
            /*var cost = await context.Cost.FindAsync(id);*/
            return cost;
        }

        public async Task<Cost_Master?> Update(int id, Cost_Master costchanges)
        {
            if (id != costchanges.CostId)
            {
                return null;
            }
            context.Entry(costchanges).State = EntityState.Modified;

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
            return null;
        }

        private bool CostExists(int id)
        {
            return (context.Cost?.Any(e => e.CostId == id)).GetValueOrDefault();
        }
    }
}
