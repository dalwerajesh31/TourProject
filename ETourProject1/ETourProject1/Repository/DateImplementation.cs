using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETourProject1.Models; // Make sure to adjust the namespace as needed
using ETourProject1.Repository;

namespace WebApplicationOneToMany.Models
{
    public class SQLDateMasterRepository : IDate_Masterinterface
    {
        private readonly Appdbcontext context;

        public SQLDateMasterRepository(Appdbcontext context)
        {
            this.context = context;
        }

        public async Task<ActionResult<Date_Master>?> GetDate(DateTime date)
        {
            var dateMaster = await context.Date.FirstOrDefaultAsync(d => d.DepartDate == date);
            return dateMaster;
        }

        public async Task<ActionResult<IEnumerable<Date_Master>>> GetAllDate_Master()
        {
            return await context.Date.ToListAsync();
        }

        public async Task<ActionResult<Date_Master>> Add(Date_Master date)
        {
            context.Date.Add(date);
            await context.SaveChangesAsync();
            return date;
        }

        public async Task<Date_Master> Update(int id, Date_Master date)
        {
            if (id != date.DepartureId)
            {
                return null;
            }

            context.Entry(date).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DateMasterExists(id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
            return date;
        }

        public async Task<Date_Master> Delete(int Id)
        {
            Date_Master date = await context.Date.FindAsync(Id);
            if (date != null)
            {
                context.Date.Remove(date);
                await context.SaveChangesAsync();
            }
            return date;
        }

        private bool DateMasterExists(int id)
        {
            return context.Date.Any(e => e.DepartureId == id);
        }
    }
}
