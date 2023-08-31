﻿using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ETourProject1.Repository
{
        /*using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETourProject1.Repository
{
    public class Category_MasterRepository : ICategory_MasterInterface
    {
        private readonly Appdbcontext context;

        public Category_MasterRepository(Appdbcontext context)
        {
            this.context = context;
        }
        public async Task<ActionResult<Category_Master>> Add(Category_Master category)
        {
            context.Category.Add(category);
            await context.SaveChangesAsync();
            return category;
        }

        public async Task<Category_Master> Delete(int id)
        {
            Category_Master cost = context.Category.Find(id);
            if (category != null)
            {
                context.Category.Remove(category);
                await context.SaveChangesAsync();
            }
            return category;
        }
*/

        public class Category_MasterRepository : ICategory_MasterInterface
        {
            private readonly Appdbcontext context;

            public Category_MasterRepository(Appdbcontext context)
            {
                this.context = context;
            }

            public async Task<ActionResult<Category_Master>> Add(Category_Master category)
            {
                context.Category.Add(category);
                await context.SaveChangesAsync();
                return category;
            }

            public ActionResult<IEnumerable<dynamic>> Get(int id)
            {
                throw new NotImplementedException();
            }

            public async Task<ActionResult<IEnumerable<Category_Master>>> GetAllCategory()
            {
                if (context.Category == null)
                {
                    return null;
                }
                return await context.Category.ToListAsync();
            }

            public async Task<ActionResult<Category_Master>> GetCategory(int id)
            {
                var category = await context.Category.FindAsync(id);
                return category;
            }


            private bool CategoryExists(int id)
            {
                return (context.Category?.Any(e => e.catMasterID == id)).GetValueOrDefault();
            }
        }
    }


