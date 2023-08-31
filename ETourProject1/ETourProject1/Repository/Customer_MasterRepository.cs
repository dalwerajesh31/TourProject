using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace ETourProject1.Repository
{
    public class Customer_MasterRepository : ICustomer_MasterInterface
    {

        private readonly Appdbcontext context;

        public Customer_MasterRepository(Appdbcontext context)
        {
            this.context = context;
        }



        public async Task<ActionResult<Customer_Master>> AddCustomer(Customer_Master customer)
        {
            context.Customer_Master.Add(customer);
            await context.SaveChangesAsync();
            return customer;
        }

        /*public Task<Customer_Master> Delete(int id)
        {
            throw new NotImplementedException();
        }*/

        public async Task<Customer_Master> GetById(int id)
        {


            if (context.Customer_Master == null)
            {
                return null;
            }
            Customer_Master customer = await  context.Customer_Master.FindAsync(id);
            if (customer == null)
            {
                return null;
            }
            return customer;
          
        }

    
        public async Task<ActionResult<IEnumerable<Customer_Master>?>> GetCustomers()
        {
            if (context.Customer_Master == null)
            {
                return null;
            }

            return await context.Customer_Master.ToListAsync();
        }

        Task<ActionResult<Customer_Master>> ICustomer_MasterInterface.AddCustomer(Customer_Master customer)
        {
            throw new NotImplementedException();
        }

 
        Task<Customer_Master> ICustomer_MasterInterface.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Task<ActionResult<IEnumerable<Customer_Master>?>> ICustomer_MasterInterface.GetCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
