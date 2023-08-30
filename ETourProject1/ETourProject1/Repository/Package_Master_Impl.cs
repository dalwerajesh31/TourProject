using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace ETourProject1.Repository
{
    
    public class Package_Master_Impl : IPackage_Master_Interface
    {
        private readonly Appdbcontext context;
        public async Task<ActionResult<Package_master>> AddPackage(Package_master package)
        {
            context.Packages.Add(package);
            await context.SaveChangesAsync();
            return package;
        }

        public async Task<Package_master> Delete(int id)
        {
            Package_master package = context.Packages.Find(id);
            if (package != null)
            {
                context.Packages.Remove(package);
                await context.SaveChangesAsync();
            }
            return package;
        }

        /*public Task<ActionResult<IEnumerable<Package_master>>> getByCatmaster(int id)
        {
            
        }*/

        public async Task<ActionResult<Package_master>?> GetById(int id)
        {
            if (context.Packages == null)
            {
                return null;
            }
            var package = await context.Packages.FindAsync(id);
            if (package == null)
            {
                return null;
            }
            return package;
        }

        public async Task<ActionResult<IEnumerable<Package_master>>> GetPackageMasters()
        {

            if (context.Packages == null)
            {
                return null;
            }

            return await context.Packages.ToListAsync();
        }

        public async Task<Package_master> Update(Package_master packageMaster, int id)
        {
            if (id != packageMaster.PkgId)
            {
                return null;
            }
            context.Entry(packageMaster).State = EntityState.Modified;

            try
            {
                context.Update(packageMaster);
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PackageExists(id))
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
        private bool PackageExists(int id)
        {
            return (context.Packages?.Any(e => e.PkgId == id)).GetValueOrDefault();
        }
    }
}
